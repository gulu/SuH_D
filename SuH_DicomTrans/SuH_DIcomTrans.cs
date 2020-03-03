using SuH_FoDicom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SuH_DicomTrans
{
    public partial class SuH_DIcomTrans : ServiceBase
    {
        public SuH_DIcomTrans()
        {
            InitializeComponent();
        }

        //Stroage SCP
        Thread mStoregeSCPThread = null;

        //Stroage SCU
        Thread mStoregeSCUThread = null;

        //英飞达pacs  图像处理模式
        Thread mInfinittTrans = null;

        protected override void OnStart(string[] args)
        {
            //Task.Factory.StartNew(() => FactoryService.f_StartStorageSCP(), TaskCreationOptions.LongRunning);
            mStoregeSCPThread = new Thread(new ThreadStart(FactoryService.f_StartStorageSCP));
            mStoregeSCPThread.IsBackground = true;
            mStoregeSCPThread.SetApartmentState(ApartmentState.STA);
            mStoregeSCPThread.Start();


            if (SuHDicomClientCfg.INF_Used == "1")
            {
                mInfinittTrans = new Thread(new ThreadStart(FactoryService.f_StartSInfinittTrans));
                mInfinittTrans.IsBackground = true;
                mInfinittTrans.SetApartmentState(ApartmentState.STA);
                mInfinittTrans.Start();
            }
            //SCU
            //mStoregeSCUThread = new Thread(new ThreadStart(FactoryService.f_StartStorageSCP));
            //mStoregeSCUThread.IsBackground = true;
            //mStoregeSCUThread.SetApartmentState(ApartmentState.STA);
            //mStoregeSCUThread.Start();

        }

        protected override void OnStop()
        {
            // TODO: 在此处添加代码以执行停止服务所需的关闭操作。
            if (mStoregeSCPThread != null)
            {
                mStoregeSCPThread = null;//取消之前进程
            }
            if (mStoregeSCUThread != null)
            {
                mStoregeSCUThread = null;//取消之前进程
            }

            if (SuHDicomClientCfg.INF_Used == "1")
            {

                if (mInfinittTrans != null)
                {
                    mInfinittTrans = null;//取消之前进程
                }
            }
        }
    }
}
