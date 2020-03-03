using PubLib;
using SuH_FoDicom;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SuH_FoDicom
{

    /// <summary>
    /// 英飞达 PACS图像转发处理
    /// 数据库操作使用udataset 防止 前置机oracle  端口限制问题
    /// </summary>
    public static class SH_INF_Trans
    {
        static SH_CStoreSCU sH_CStoreSCU = new SH_CStoreSCU();
        /// <summary>
        /// 通过ACCNO查询数据 获取对应图像地址URL,然后下载到程序目录下 
        /// </summary>
        /// <param name="pAccno">检查影像号</param>
        /// <returns></returns>
        public static bool f_LoadImageByUrlPath(string pAccno)
        {
            bool flag = false;
            string[] mSQL = { @"select s.patient_id,
                           s.patient_name,
                           l.filename, l.pathname,
                           case
                             when l.b1_bak_stat = 'N' then
                              (select v.iishost || '/' || v.sharename
                                 from volume v
                                where v.volume_code = l.b1_vol_code) || '/' || l.pathname || '/' ||
                              l.filename
                             else
                              (select v.iishost || '/' || v.sharename
                                 from volume v
                                where v.volume_code = l.volume_code) || '/' || l.pathname || '/' ||
                              l.filename
                           end as urlpathname
                      from study s, instance i, instanceloc l
                     where s.study_key = i.study_key
                       and i.instance_key = l.instance_key
                       and s.access_no ='" + pAccno + "'" };
            uDataSet ds = new uDataSet(mSQL, new uParameter[] { }, SuHDicomClientCfg.INF_DB_TNS);
            //返回数据路径格式为  urlpathname http://120.55.190.118/D2/20200302/E1073433/I00014757556.dcm 
            //pathname 20200302/E1073433
            // filename I00014757562.dcm
            //http 方式下载图像
            if (ds.RowCount() < 1)
            {
                return false;
            }
            //保存图像路径地址 
            string saveDicomPath = "";
            // infintt 路径地址
            string inf_pathname = ds.GetItemString(1, "pathname");

            //程序集根目录
            string localPath = System.Windows.Forms.Application.StartupPath;
            //图像缓存地址
            string cacheImagePath = localPath + "\\cacheimage";
            //目录不存在则创建
            if (false == System.IO.Directory.Exists(cacheImagePath))
            {
                //创建文件夹
                Directory.CreateDirectory(cacheImagePath);
            }
            if (Directory.Exists(cacheImagePath))
            {
                //存在/成功创建 文件夹
                cacheImagePath = cacheImagePath + @"\";
            }
            //根据之前目录结构创建相同名称和路径地址 

            saveDicomPath = cacheImagePath + inf_pathname;
            if (false == System.IO.Directory.Exists(saveDicomPath))
            {
                //创建文件夹
                Directory.CreateDirectory(saveDicomPath);
            }
            string localfile = "";
            //防止处理文件时下载和上传不同步 照成文件锁定情况
            object lock1 = new object();
            lock (lock1)
            {
                //循环下载图像
                for (int i = 1; i <= ds.RowCount(); i++)
                {
                    localfile = "";
                    localfile = saveDicomPath + "\\" + ds.GetItemString(i, "filename");
                    flag = Download(ds.GetItemString(i, "urlpathname"), localfile);

                    if (flag)
                    {
                        //使用 dicom fasong 
                        if (SuHDicomClientCfg.StoreSCU_Used == "1")
                        {
                            //异步调用转发方法
                            Task.Factory.StartNew(() => sH_CStoreSCU.f_ScuSendOneFile(localfile));
                        }
                        else
                        {

                        }
                    }
                }



            }

            return flag;
        }


        /// <summary>
        /// Http方式下载文件
        /// </summary>
        /// <param name="url">http地址</param>
        /// <param name="localfile">本地文件</param>
        /// <returns></returns>
        private static bool Download(string url, string localfile)
        {
            bool flag = false;
            long startPosition = 0; // 上次下载的文件起始位置
            FileStream writeStream; // 写入本地文件流对象

            // 判断要下载的文件夹是否存在
            if (File.Exists(localfile))
            {

                writeStream = File.OpenWrite(localfile);             // 存在则打开要下载的文件
                startPosition = writeStream.Length;                  // 获取已经下载的长度
                writeStream.Seek(startPosition, SeekOrigin.Current); // 本地文件写入位置定位
            }
            else
            {
                writeStream = new FileStream(localfile, FileMode.Create);// 文件不保存创建一个文件
                startPosition = 0;
            }


            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)HttpWebRequest.Create(url);// 打开网络连接

                if (startPosition > 0)
                {
                    myRequest.AddRange((int)startPosition);// 设置Range值,与上面的writeStream.Seek用意相同,是为了定义远程文件读取位置
                }


                Stream readStream = myRequest.GetResponse().GetResponseStream();// 向服务器请求,获得服务器的回应数据流


                byte[] btArray = new byte[512];// 定义一个字节数据,用来向readStream读取内容和向writeStream写入内容
                int contentSize = readStream.Read(btArray, 0, btArray.Length);// 向远程文件读第一次

                while (contentSize > 0)// 如果读取长度大于零则继续读
                {
                    writeStream.Write(btArray, 0, contentSize);// 写入本地文件
                    contentSize = readStream.Read(btArray, 0, btArray.Length);// 继续向远程文件读取
                }

                //关闭流
                writeStream.Close();
                readStream.Close();

                flag = true;        //返回true下载成功
            }
            catch (Exception)
            {
                writeStream.Close();
                flag = false;       //返回false下载失败
            }

            return flag;
        }

        ///<summary>
        /// 通过 查询 SH_DICOM_TRANS 表获取需要上传的数据列表 
        /// </summary>
        /// <returns></returns>
        public static void f_getJobList()
        {
            object o = new object();
            string[] mSQL = { @"select * from SH_DICOM_TRANS where state='0' " };
            uDataSet ds = new uDataSet(mSQL, new uParameter[] { }, SuHDicomClientCfg.INF_IMAGE_STATES_DB_TNS);
            for (int i = 1; i <= ds.RowCount(); i++)
            {
                lock (o)
                {
                    string uids = ds.GetItemString(i, "uids");
                    string[] mSQL_UID = { @"select * from SH_DICOM_TRANS where uids='" + uids + "' " };
                    uDataSet dsUID = new uDataSet(mSQL_UID, new uParameter[] { }, SuHDicomClientCfg.INF_IMAGE_STATES_DB_TNS);

                    try
                    {
                        //更新数据状态 为 1 
                        if (dsUID.RowCount() >= 1)
                        {
                            dsUID.SetItem(1, "state", "1");
                            dsUID.Update(SuHDicomClientCfg.INF_IMAGE_STATES_DB_TNS);
                        }

                        f_LoadImageByUrlPath(ds.GetItemString(i, "caccno"));

                        //更新数据状态 为 2 
                        dsUID = new uDataSet(mSQL_UID, new uParameter[] { }, SuHDicomClientCfg.INF_IMAGE_STATES_DB_TNS);
                        if (dsUID.RowCount() >= 1)
                        {
                            dsUID.SetItem(1, "state", "2");
                            dsUID.Update(SuHDicomClientCfg.INF_IMAGE_STATES_DB_TNS);
                        }
                    }
                    catch (Exception ex)
                    {
                        dsUID = new uDataSet(mSQL_UID, new uParameter[] { }, SuHDicomClientCfg.INF_IMAGE_STATES_DB_TNS);
                        if (dsUID.RowCount() >= 1)
                        {
                            dsUID.SetItem(1, "state", "100");
                            dsUID.Update(SuHDicomClientCfg.INF_IMAGE_STATES_DB_TNS);
                        }
                    }
                }
            }
        }
    }

}
