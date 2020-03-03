using Dicom.Log;
using Dicom.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SuH_FoDicom
{
    public static class FactoryService
    {
        public static void f_StartStorageSCP()
        {
            using (var server = DicomServer.Create<SH_CStoreSCP>(SuHDicomClientCfg.StorageSCP_Port))
            {

                //// end process
                //Console.WriteLine("Press <return> to end...");
                //Console.ReadLine();
                do
                {

                } while (1 < 2);
            }
        }


        public static void f_StartSInfinittTrans()
        {
            //时间定时任务
             var autoEvent = new AutoResetEvent(false);
            Timer t = new Timer(p => SH_INF_Trans.f_getJobList(), autoEvent, 0, 10000);// 第一个参数是：回调方法，表示要定时执行的方法，第二个参数是：回调方法要使用的信息的对象，或者为空引用，第三个参数是：调用 callback 之前延迟的时间量（以毫秒为单位），指定 Timeout.Infinite 以防止计时器开始计时。指定零 (0) 以立即启动计时器。第四个参数是：定时的时间时隔，以毫秒为单位
            autoEvent.WaitOne();

        }

    }
}
