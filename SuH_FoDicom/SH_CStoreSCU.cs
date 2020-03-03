
using Dicom.Log;
using Dicom.Network;
using Dicom.Network.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DicomClient = Dicom.Network.Client.DicomClient;

namespace SuH_FoDicom
{
    public class SH_CStoreSCU
    {

        DicomClient client;
        Dicom.Log.Logger foDicomLogger;
        public SH_CStoreSCU()
        {
            client = new DicomClient(SuHDicomClientCfg.StoreSCU_ServerHost, SuHDicomClientCfg.StoreSCU_ServerPort, false, SuHDicomClientCfg.StoreSCU_AET, SuHDicomClientCfg.StoreSCU_ServerAET);
            client.NegotiateAsyncOps();
            foDicomLogger = LogManager.GetLogger("testLog");

        }

        /// <summary>
        /// 按文件目录传输  可以做批量发送
        /// </summary>
        /// <param name="pFilePath"></param>
        /// <returns></returns>
        public async Task f_startScuSend(string pFilePath)
        {


            try
            {
                List<string> dcmFileList = new List<string>();

                //获取目录或存在的字目录的所有DCM 后缀名称
                //获得该文件夹下的子目录，返回类型为DirectoryInfo
                DirectoryInfo DicRoot = new DirectoryInfo(pFilePath);
                DirectoryInfo[] dics = DicRoot.GetDirectories();
                //获得该文件夹下的文件，返回类型为FileInfo
                foreach (var item in dics)
                {
                    DirectoryInfo FilerootItem = new DirectoryInfo(item.FullName);
                    FileInfo[] filesItems = FilerootItem.GetFiles("*.dcm");
                    foreach (var items in filesItems)
                    {
                        if (dcmFileList.Contains(items.FullName))
                        {
                        }
                        else
                        {
                            dcmFileList.Add(item.FullName);
                        }
                    }

                }


                DirectoryInfo Fileroot = new DirectoryInfo(pFilePath);
                FileInfo[] files = Fileroot.GetFiles("*.dcm");
                foreach (var item in files)
                {
                    if (dcmFileList.Contains(item.FullName))
                    {
                    }
                    else
                    {
                        dcmFileList.Add(item.FullName);
                    }
                }

                foreach (var item in dcmFileList)
                {
                    while (!File.Exists(item))
                    {
                        continue;
                    }

                    var request = new DicomCStoreRequest(item);

                    // request.OnResponseReceived += (req, response) => foDicomLogger.Info("发送图像成功："+item); //Console.WriteLine("C-Store Response Received, Status: " + response.Status);


                    await client.AddRequestAsync(request);
                    await client.SendAsync();
                }
            }
            catch (Exception exception)
            {
                foDicomLogger.Debug("发送图像错误");
                foDicomLogger.Debug("错误信息" + exception.Message + exception.Source);
            }
        }

        /// <summary>
        /// 按文件目录传输  可以做批量发送
        /// </summary>
        /// <param name="pOneFilePath">单个文件全路径地址</param>
        /// <returns></returns>
        public async Task f_ScuSendOneFile(string pOneFilePath)
        {


            try
            {
                if (!File.Exists(pOneFilePath))
                {
                    return;
                }

                var request = new DicomCStoreRequest(pOneFilePath);

                //图像发送完成
                request.OnResponseReceived += (req, response) =>
                {
                    //删除图像
                    if (SuHDicomClientCfg.StoreSCU_DeleteLocalFile == "1")
                    {
                        if (File.Exists(pOneFilePath))
                        {
                            File.Delete(pOneFilePath);
                        }
                    }

                };

                await client.AddRequestAsync(request);
                await client.SendAsync();

            }
            catch (Exception exception)
            {
                foDicomLogger.Debug("发送图像错误");
                foDicomLogger.Debug("错误信息" + exception.Message + exception.Source);
            }
        }
    }
}
