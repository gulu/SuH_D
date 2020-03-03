using Dicom;
using Dicom.Log;
using Dicom.Network;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuH_FoDicom
{

    /// <summary>
    /// 基于FO-DICOM的 存储类。
    /// </summary>
    public class SH_CStoreSCP : DicomService, IDicomServiceProvider, IDicomCStoreProvider, IDicomCEchoProvider
    {
        SH_CStoreSCU sH_CStoreSCU = new SH_CStoreSCU();


        private static readonly DicomTransferSyntax[] AcceptedTransferSyntaxes = new DicomTransferSyntax[]
        {
               DicomTransferSyntax.ExplicitVRLittleEndian,
               DicomTransferSyntax.ExplicitVRBigEndian,
               DicomTransferSyntax.ImplicitVRLittleEndian
        };

        private static readonly DicomTransferSyntax[] AcceptedImageTransferSyntaxes = new DicomTransferSyntax[]
        {
               // Lossless
               DicomTransferSyntax.JPEGLSLossless,
               DicomTransferSyntax.JPEG2000Lossless,
               DicomTransferSyntax.JPEGProcess14SV1,
               DicomTransferSyntax.JPEGProcess14,
               DicomTransferSyntax.RLELossless,
               // Lossy
               DicomTransferSyntax.JPEGLSNearLossless,
               DicomTransferSyntax.JPEG2000Lossy,
               DicomTransferSyntax.JPEGProcess1,
               DicomTransferSyntax.JPEGProcess2_4,
               // Uncompressed
               DicomTransferSyntax.ExplicitVRLittleEndian,
               DicomTransferSyntax.ExplicitVRBigEndian,
               DicomTransferSyntax.ImplicitVRLittleEndian
        };



        public SH_CStoreSCP(INetworkStream stream, Encoding fallbackEncoding, Logger log)
            : base(stream, fallbackEncoding, log)
        {
        }

        public Task OnReceiveAssociationRequestAsync(DicomAssociation association)
        {
            if (association.CalledAE != SuHDicomClientCfg.StorageSCP_AETitle)
            {
                return SendAssociationRejectAsync(
                    DicomRejectResult.Permanent,
                    DicomRejectSource.ServiceUser,
                    DicomRejectReason.CalledAENotRecognized);
            }

            foreach (var pc in association.PresentationContexts)
            {
                if (pc.AbstractSyntax == DicomUID.Verification)
                {
                    pc.AcceptTransferSyntaxes(AcceptedTransferSyntaxes);
                }
                else if (pc.AbstractSyntax.StorageCategory != DicomStorageCategory.None)
                {
                    pc.AcceptTransferSyntaxes(AcceptedImageTransferSyntaxes);
                }
            }

            return SendAssociationAcceptAsync(association);
        }

        public Task OnReceiveAssociationReleaseRequestAsync()
        {
            return SendAssociationReleaseResponseAsync();
        }

        public void OnReceiveAbort(DicomAbortSource source, DicomAbortReason reason)
        {
        }

        public void OnConnectionClosed(Exception exception)
        {
        }


        /// <summary>
        /// 接收到图像接收申请后触发
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DicomCStoreResponse OnCStoreRequest(DicomCStoreRequest request)
        {
            Dicom.Log.Logger foDicomLogger = LogManager.GetLogger("testLog");
            foDicomLogger.Fatal("A fatal message at {dateTime}", DateTime.Now);
            var file = request.File;

            foDicomLogger.Debug("A debug for file {filename} - info: {@metaInfo}", file.File.Name, file.FileMetaInfo);

            var studyUid = request.Dataset.GetSingleValue<string>(DicomTag.StudyInstanceUID);
            var instUid = request.SOPInstanceUID.UID;

            var path = Path.GetFullPath(SuHDicomClientCfg.StorageSCP_Path);
            path = Path.Combine(path, studyUid);

            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            path = Path.Combine(path, instUid) + ".dcm";

            request.File.Save(path);
            if (SuHDicomClientCfg.StoreSCU_Used == "1")
            {
                //异步调用转发方法
                Task.Factory.StartNew(() => sH_CStoreSCU.f_ScuSendOneFile(path));
            }
            else
            {

            }

            return new DicomCStoreResponse(request, DicomStatus.Success);
        }

        public void OnCStoreRequestException(string tempFileName, Exception e)
        {
            // let library handle logging and error response
        }


        /// <summary>
        /// dicom cecho 消息申请后触发
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DicomCEchoResponse OnCEchoRequest(DicomCEchoRequest request)
        {
            return new DicomCEchoResponse(request, DicomStatus.Success);
        }


    }
}
