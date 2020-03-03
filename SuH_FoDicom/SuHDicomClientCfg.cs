using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuH_FoDicom
{
    public static class SuHDicomClientCfg
    {

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);


        /// <summary>
        /// 写入INI文件
        /// </summary>
        /// <param name="Section">项目名称(如 [TypeName] )</param>
        /// <param name="Key">键</param>
        /// <param name="Value">值</param>
        public static void IniWriteValue(string Section, string Key, string Value, string FileName)
        {
            WritePrivateProfileString(Section, Key, Value, FileName);
        }

        /// <summary>
        /// 读出INI文件
        /// </summary>
        /// <param name="Section">项目名称(如 [TypeName] )</param>
        /// <param name="Key">键</param>
        public static string IniReadValue(string Section, string Key, string FileName)
        {
            StringBuilder temp = new StringBuilder(500);
            int i = GetPrivateProfileString(Section, Key, "", temp, 500, FileName);
            return temp.ToString();
        }

        /// <summary>
        /// LocalIP
        /// </summary>
        public static string LocalIP
        {
            get
            {
                return IniReadValue("Local", "LocalIP", Application.StartupPath + "\\SuhDicomTranc.ini");
            }
            set
            {
                IniWriteValue("Local", "LocalIP", value, Application.StartupPath + "\\SuhDicomTranc.ini");

            }
        }




        #region  Storage SCP

        /// <summary>
        /// AETtitle
        /// </summary>
        public static string StorageSCP_AETitle
        {
            get
            {
                return IniReadValue("SCP", "AETITLE", Application.StartupPath + "\\SuhDicomTranc.ini");
            }
            set
            {
                IniWriteValue("SCP", "AETITLE", value, Application.StartupPath + "\\SuhDicomTranc.ini");

            }
        }
        /// <summary>
        /// scp  端口
        /// </summary>
        public static int StorageSCP_Port
        {
            get
            {
                return Convert.ToInt32(IniReadValue("SCP", "PORT", Application.StartupPath + "\\SuhDicomTranc.ini"));
            }
            set
            {
                IniWriteValue("SCP", "PORT", value.ToString(), Application.StartupPath + "\\SuhDicomTranc.ini");

            }
        }

        /// <summary>
        /// StorageSCP 图像保存路径
        /// </summary>
        public static string StorageSCP_Path
        {
            get
            {
                return IniReadValue("SCP", "PATH", Application.StartupPath + "\\SuhDicomTranc.ini");
            }
            set
            {
                IniWriteValue("SCP", "PATH", value, Application.StartupPath + "\\SuhDicomTranc.ini");

            }
        }


        /// <summary>
        /// StorageSCP 缓存路径文件监听功能
        /// </summary>
        public static string StorageSCP_PathMonitor
        {
            get
            {
                return IniReadValue("SCP", "PathMonitor", Application.StartupPath + "\\SuhDicomTranc.ini");
            }
            set
            {
                IniWriteValue("SCP", "PathMonitor", value, Application.StartupPath + "\\SuhDicomTranc.ini");

            }
        }


        /// <summary>
        /// StorageSCP_TempPath 图像接收后的缓存路径
        /// </summary>
        public static string StorageSCP_TempPath
        {
            get
            {
                return IniReadValue("SCP", "TEMP_PATH", Application.StartupPath + "\\SuhDicomTranc.ini");
            }
            set
            {
                IniWriteValue("SCP", "TEMP_PATH", value, Application.StartupPath + "\\SuhDicomTranc.ini");

            }
        }


        #endregion
        #region  Storage SCU

        /// <summary>
        /// store SCP IP
        /// </summary>
        public static string StoreSCU_ServerHost
        {
            get
            {
                return IniReadValue("SCU", "ServerIP", Application.StartupPath + "\\SuhDicomTranc.ini");
            }
            set
            {
                IniWriteValue("SCU", "ServerIP", value, Application.StartupPath + "\\SuhDicomTranc.ini");

            }
        }
        /// <summary>
        /// store SCP PORT
        /// </summary>
        public static int StoreSCU_ServerPort
        {
            get
            {
                return Convert.ToInt32(IniReadValue("SCU", "ServerPort", Application.StartupPath + "\\SuhDicomTranc.ini"));
            }
            set
            {
                IniWriteValue("SCU", "ServerPort", value.ToString(), Application.StartupPath + "\\SuhDicomTranc.ini");

            }
        }



        /// <summary>
        /// store SCP AETITLE
        /// </summary>
        public static string StoreSCU_ServerAET
        {
            get
            {
                return IniReadValue("SCU", "ServerAE", Application.StartupPath + "\\SuhDicomTranc.ini");
            }
            set
            {
                IniWriteValue("SCU", "ServerAE", value, Application.StartupPath + "\\SuhDicomTranc.ini");

            }
        }


        /// <summary>
        /// store SCU AETITLE
        /// </summary>
        public static string StoreSCU_AET
        {
            get
            {
                return IniReadValue("SCU", "AETITLE", Application.StartupPath + "\\SuhDicomTranc.ini");
            }
            set
            {
                IniWriteValue("SCU", "AETITLE", value, Application.StartupPath + "\\SuhDicomTranc.ini");

            }
        }

        /// <summary>
        /// store SCU  客户端图像发送成功后是否删除本地文件
        /// </summary>
        public static string StoreSCU_DeleteLocalFile
        {
            get
            {
                return IniReadValue("SCU", "DeleteLocalFile", Application.StartupPath + "\\SuhDicomTranc.ini");
            }
            set
            {
                IniWriteValue("SCU", "DeleteLocalFile", value.ToString(), Application.StartupPath + "\\SuhDicomTranc.ini");

            }
        }

        /// <summary>
        /// 启用dicom  storage SCU
        /// </summary>
        public static string StoreSCU_Used
        {
            get
            {
                return IniReadValue("SCU", "USED", Application.StartupPath + "\\SuhDicomTranc.ini");
            }
            set
            {
                IniWriteValue("SCU", "USED", value.ToString(), Application.StartupPath + "\\SuhDicomTranc.ini");

            }
        }

        #endregion

        #region  INFINITT 基于数据库状态控制的图像转发

        /// <summary>
        /// 是否开启基于INFINTT 数据库图像状态的图像转发
        /// </summary>
        public static string INF_Used
        {
            get
            {
                return IniReadValue("INFINITT", "USED", Application.StartupPath + "\\SuhDicomTranc.ini");
            }
            set
            {
                IniWriteValue("INFINITT", "USED", value, Application.StartupPath + "\\SuhDicomTranc.ini");

            }
        }
        /// <summary>
        /// INFINTT 数据库连接TNS
        /// </summary>
        public static string INF_DB_TNS
        {
            get
            {
                return IniReadValue("INFINITT", "INF_DB_TNS", Application.StartupPath + "\\SuhDicomTranc.ini");
            }
            set
            {
                IniWriteValue("INFINITT", "INF_DB_TNS", value.ToString(), Application.StartupPath + "\\SuhDicomTranc.ini");

            }
        }



        /// <summary>
        /// 控制是否上传的状态表示表 SH_DICOM_TRANS 数据库连接地址
        /// </summary>
        public static string INF_IMAGE_STATES_DB_TNS
        {
            get
            {
                return IniReadValue("INFINITT", "INF_IMAGE_STATES_DB_TNS", Application.StartupPath + "\\SuhDicomTranc.ini");
            }
            set
            {
                IniWriteValue("INFINITT", "INF_IMAGE_STATES_DB_TNS", value, Application.StartupPath + "\\SuhDicomTranc.ini");

            }
        }





        #endregion

    }
}
