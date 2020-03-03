
using SuH_FoDicom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuHServiceControl
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
            // Task.Factory.StartNew(() => FactoryService.f_StartStorageSCP(), TaskCreationOptions.LongRunning);
            //btn_storage_scp.Text = btn_storage_scp.Text + "启动";
        }

        private void Form1_Load(object sender, EventArgs e)
        {



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
            ckb_scu_used.Checked = SuHDicomClientCfg.StoreSCU_Used == "1" ? true : false;
            // INFINITT 
            ckb_inf_DB_trans.Checked = SuHDicomClientCfg.INF_Used == "1" ? true : false;
            txt_inf_db_url.Text = SuHDicomClientCfg.INF_DB_TNS;
            txt_inf_trans_states_url.Text = SuHDicomClientCfg.INF_IMAGE_STATES_DB_TNS;
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
            SuHDicomClientCfg.StoreSCU_Used = ckb_scu_used.Checked == true ? "1" : "0";
            //infinitt 
            SuHDicomClientCfg.INF_Used = ckb_inf_DB_trans.Checked == true ? "1" : "0";
            SuHDicomClientCfg.INF_DB_TNS = txt_inf_db_url.Text;
            SuHDicomClientCfg.INF_IMAGE_STATES_DB_TNS = txt_inf_trans_states_url.Text;
        }

        private void ckb_scp_tempPath_listener_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_scp_tempPath_listener.Checked)
            {
                SuHDicomClientCfg.StorageSCP_PathMonitor = "1";
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
            if (!SuH_DicomTrans.ServiceHelp.isServiceIsExisted(SuH_DicomTrans.ServiceHelp.f_GetServerName()))
            {
                string serviceFileName = Application.StartupPath + "\\" + SuH_DicomTrans.ServiceHelp.f_GetApplicationName();
                SuH_DicomTrans.ServiceHelp.InstallmyService(null, serviceFileName);
                MessageBox.Show("服务已安装！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("系统已经安装了此服务！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_service_uninstall_Click(object sender, EventArgs e)
        {
            if (SuH_DicomTrans.ServiceHelp.isServiceIsExisted(SuH_DicomTrans.ServiceHelp.f_GetServerName()))
            {
                string serviceFileName = Application.StartupPath + "\\" + SuH_DicomTrans.ServiceHelp.f_GetApplicationName();
                SuH_DicomTrans.ServiceHelp.UnInstallmyService(serviceFileName);
                MessageBox.Show("服务已卸载！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("系统不存在此服务，不需要卸载！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_service_start_Click(object sender, EventArgs e)
        {
            string errormsg = SuH_DicomTrans.ServiceHelp.StartService();
            if (!string.IsNullOrEmpty(errormsg))
            {
                MessageBox.Show(errormsg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("启动成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_service_stop_Click(object sender, EventArgs e)
        {
            string errormsg = SuH_DicomTrans.ServiceHelp.StopService();
            if (!string.IsNullOrEmpty(errormsg))
            {
                MessageBox.Show(errormsg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("已停止", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SH_INF_Trans.f_getJobList();
        }
    }
}
