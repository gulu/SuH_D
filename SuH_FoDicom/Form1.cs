using Dicom;
using Dicom.Log;
using Dicom.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuH_FoDicom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_storage_scp_Click(object sender, EventArgs e)
        {
            //标记为长时间运行任务,则任务不会使用线程池,而在单独的线程中运行。
            Task.Factory.StartNew(() => FactoryService.f_StartStorageSCP(), TaskCreationOptions.LongRunning);
            btn_storage_scp.Text = btn_storage_scp.Text + "启动";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //加载默认参数
            var dict = DicomDictionary.Default;
            //ALTERNATE
            var serilogManager = SH_Serilog.UseGlobalSerilogLogger();

            // Initialize log manager.
            LogManager.SetImplementation(serilogManager);


            txt_localIP.Text = SuHDicomClientCfg.LocalIP;
            //Store SCP 初始化参数
            txt_scp_ae.Text = SuHDicomClientCfg.StorageSCP_AETitle;
            txt_scp_port.Text = SuHDicomClientCfg.StorageSCP_Port.ToString();
            txt_scp_temporary_path.Text = SuHDicomClientCfg.StorageSCP_TempPath;
            txt_scp_path.Text = SuHDicomClientCfg.StorageSCP_Path;

            //Store SCU
            txt_scu_ae.Text = SuHDicomClientCfg.StoreSCU_AET;
            txt_scu_serverAE.Text = SuHDicomClientCfg.StoreSCU_ServerAET;
            txt_scu_serverIP.Text = SuHDicomClientCfg.StoreSCU_ServerHost;
            txt_scu_serverPort.Text = SuHDicomClientCfg.StoreSCU_ServerPort.ToString();
        }

        private void btn_fileBrower_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileDialog = new FolderBrowserDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_sendFilePath.Text = fileDialog.SelectedPath;
            }

        }

        private void btn_storeSCU_Click(object sender, EventArgs e)
        {
            SH_CStoreSCU sH_CStoreSCU = new SH_CStoreSCU();
            Task t = sH_CStoreSCU.f_startScuSend(txt_sendFilePath.Text);
            // Task.WaitAny(t);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SuHDicomClientCfg.LocalIP = txt_localIP.Text;
            //Store SCP 初始化参数
            txt_scp_ae.Text = SuHDicomClientCfg.StorageSCP_AETitle;
            SuHDicomClientCfg.StorageSCP_Port = Convert.ToInt32(txt_scp_port.Text);
            SuHDicomClientCfg.StorageSCP_TempPath = txt_scp_temporary_path.Text;
            SuHDicomClientCfg.StorageSCP_Path = txt_scp_path.Text;

            //Store SCU
            SuHDicomClientCfg.StoreSCU_AET = txt_scu_ae.Text;
            SuHDicomClientCfg.StoreSCU_ServerAET = txt_scu_serverAE.Text;
            SuHDicomClientCfg.StoreSCU_ServerHost = txt_scu_serverIP.Text;
            SuHDicomClientCfg.StoreSCU_ServerPort = Convert.ToInt32(txt_scu_serverPort.Text);
        }

        private void ckb_scp_tempPath_listener_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_scp_tempPath_listener.Checked)
            {
                SuHDicomClientCfg.StorageSCP_PathMonitor ="1";
            }
            else
            {
                SuHDicomClientCfg.StorageSCP_PathMonitor = "0";
            }
        }

        private void ckb_suc_deleteLocalFile_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_suc_deleteLocalFile.Checked)
            {
                SuHDicomClientCfg.StoreSCU_DeleteLocalFile = "1";
            }
            else
            {
                SuHDicomClientCfg.StoreSCU_DeleteLocalFile = "0";
            }
        }

        private void btn_service_install_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_service_uninstall_Click(object sender, EventArgs e)
        {

        }

        private void btn_service_start_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_service_stop_Click(object sender, EventArgs e)
        {
        
        }


    }
}
