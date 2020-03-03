namespace SuH_FoDicom
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_storage_scp = new System.Windows.Forms.Button();
            this.txt_log = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_fileBrower = new System.Windows.Forms.Button();
            this.btn_storeSCU = new System.Windows.Forms.Button();
            this.txt_sendFilePath = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_service_install = new DevExpress.XtraEditors.SimpleButton();
            this.btn_service_uninstall = new DevExpress.XtraEditors.SimpleButton();
            this.btn_service_start = new DevExpress.XtraEditors.SimpleButton();
            this.btn_service_stop = new DevExpress.XtraEditors.SimpleButton();
            this.txt_scp_port = new DevExpress.XtraEditors.TextEdit();
            this.txt_localIP = new DevExpress.XtraEditors.TextEdit();
            this.txt_scp_ae = new DevExpress.XtraEditors.TextEdit();
            this.txt_scp_temporary_path = new DevExpress.XtraEditors.TextEdit();
            this.txt_scp_path = new DevExpress.XtraEditors.TextEdit();
            this.txt_scu_ae = new DevExpress.XtraEditors.TextEdit();
            this.txt_scu_serverIP = new DevExpress.XtraEditors.TextEdit();
            this.txt_scu_serverPort = new DevExpress.XtraEditors.TextEdit();
            this.txt_scu_serverAE = new DevExpress.XtraEditors.TextEdit();
            this.ckb_suc_deleteLocalFile = new DevExpress.XtraEditors.CheckEdit();
            this.ckb_scp_tempPath_listener = new DevExpress.XtraEditors.CheckEdit();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_scp_port.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_localIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_scp_ae.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_scp_temporary_path.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_scp_path.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_scu_ae.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_scu_serverIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_scu_serverPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_scu_serverAE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_suc_deleteLocalFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_scp_tempPath_listener.Properties)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_storage_scp, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_log, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(697, 572);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_storage_scp
            // 
            this.btn_storage_scp.Location = new System.Drawing.Point(3, 3);
            this.btn_storage_scp.Name = "btn_storage_scp";
            this.btn_storage_scp.Size = new System.Drawing.Size(230, 56);
            this.btn_storage_scp.TabIndex = 0;
            this.btn_storage_scp.Text = "Storage SCP 启动";
            this.btn_storage_scp.UseVisualStyleBackColor = true;
            this.btn_storage_scp.Click += new System.EventHandler(this.btn_storage_scp_Click);
            // 
            // txt_log
            // 
            this.txt_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_log.Location = new System.Drawing.Point(239, 3);
            this.txt_log.Name = "txt_log";
            this.tableLayoutPanel1.SetRowSpan(this.txt_log, 4);
            this.txt_log.Size = new System.Drawing.Size(455, 566);
            this.txt_log.TabIndex = 1;
            this.txt_log.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_fileBrower, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_storeSCU, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_sendFilePath, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 67);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(230, 84);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btn_fileBrower
            // 
            this.btn_fileBrower.Location = new System.Drawing.Point(3, 3);
            this.btn_fileBrower.Name = "btn_fileBrower";
            this.btn_fileBrower.Size = new System.Drawing.Size(109, 40);
            this.btn_fileBrower.TabIndex = 0;
            this.btn_fileBrower.Text = "文件浏览";
            this.btn_fileBrower.UseVisualStyleBackColor = true;
            this.btn_fileBrower.Click += new System.EventHandler(this.btn_fileBrower_Click);
            // 
            // btn_storeSCU
            // 
            this.btn_storeSCU.Location = new System.Drawing.Point(118, 3);
            this.btn_storeSCU.Name = "btn_storeSCU";
            this.btn_storeSCU.Size = new System.Drawing.Size(109, 40);
            this.btn_storeSCU.TabIndex = 1;
            this.btn_storeSCU.Text = "发送";
            this.btn_storeSCU.UseVisualStyleBackColor = true;
            this.btn_storeSCU.Click += new System.EventHandler(this.btn_storeSCU_Click);
            // 
            // txt_sendFilePath
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txt_sendFilePath, 2);
            this.txt_sendFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_sendFilePath.Location = new System.Drawing.Point(3, 50);
            this.txt_sendFilePath.Name = "txt_sendFilePath";
            this.txt_sendFilePath.Size = new System.Drawing.Size(224, 31);
            this.txt_sendFilePath.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 613);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(703, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "参数设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 364F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 715F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.label9, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label10, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.label11, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.label12, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 10);
            this.tableLayoutPanel3.Controls.Add(this.txt_scp_port, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.txt_localIP, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_scp_ae, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.txt_scp_temporary_path, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.txt_scp_path, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.txt_scu_ae, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.txt_scu_serverIP, 2, 7);
            this.tableLayoutPanel3.Controls.Add(this.txt_scu_serverPort, 2, 8);
            this.tableLayoutPanel3.Controls.Add(this.txt_scu_serverAE, 2, 9);
            this.tableLayoutPanel3.Controls.Add(this.ckb_suc_deleteLocalFile, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.ckb_scp_tempPath_listener, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 11;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(697, 462);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "接收图像参数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "AEtitile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "PORT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "本机IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 163);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "图像缓存路径";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "图像保存路径";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 243);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "发送图像参数";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 243);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "AEtitile";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 283);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Server_IP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(179, 323);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Server_Port";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 363);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "Server_AE";
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Controls.Add(this.btn_save);
            this.flowLayoutPanel1.Controls.Add(this.btn_service_install);
            this.flowLayoutPanel1.Controls.Add(this.btn_service_uninstall);
            this.flowLayoutPanel1.Controls.Add(this.btn_service_start);
            this.flowLayoutPanel1.Controls.Add(this.btn_service_stop);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 403);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(806, 56);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(3, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(113, 44);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "保存";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_service_install
            // 
            this.btn_service_install.Location = new System.Drawing.Point(122, 3);
            this.btn_service_install.Name = "btn_service_install";
            this.btn_service_install.Size = new System.Drawing.Size(113, 44);
            this.btn_service_install.TabIndex = 34;
            this.btn_service_install.Text = "安装服务";
            this.btn_service_install.Click += new System.EventHandler(this.btn_service_install_Click);
            // 
            // btn_service_uninstall
            // 
            this.btn_service_uninstall.Location = new System.Drawing.Point(241, 3);
            this.btn_service_uninstall.Name = "btn_service_uninstall";
            this.btn_service_uninstall.Size = new System.Drawing.Size(113, 44);
            this.btn_service_uninstall.TabIndex = 35;
            this.btn_service_uninstall.Text = "卸载服务";
            this.btn_service_uninstall.Click += new System.EventHandler(this.btn_service_uninstall_Click);
            // 
            // btn_service_start
            // 
            this.btn_service_start.Location = new System.Drawing.Point(360, 3);
            this.btn_service_start.Name = "btn_service_start";
            this.btn_service_start.Size = new System.Drawing.Size(113, 44);
            this.btn_service_start.TabIndex = 36;
            this.btn_service_start.Text = "启动服务";
            this.btn_service_start.Click += new System.EventHandler(this.btn_service_start_Click);
            // 
            // btn_service_stop
            // 
            this.btn_service_stop.Location = new System.Drawing.Point(479, 3);
            this.btn_service_stop.Name = "btn_service_stop";
            this.btn_service_stop.Size = new System.Drawing.Size(113, 44);
            this.btn_service_stop.TabIndex = 37;
            this.btn_service_stop.Text = "停止服务";
            this.btn_service_stop.Click += new System.EventHandler(this.btn_service_stop_Click);
            // 
            // txt_scp_port
            // 
            this.txt_scp_port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_scp_port.Location = new System.Drawing.Point(323, 123);
            this.txt_scp_port.Name = "txt_scp_port";
            this.txt_scp_port.Properties.Mask.EditMask = "d";
            this.txt_scp_port.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_scp_port.Size = new System.Drawing.Size(358, 32);
            this.txt_scp_port.TabIndex = 22;
            // 
            // txt_localIP
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txt_localIP, 2);
            this.txt_localIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_localIP.Location = new System.Drawing.Point(179, 3);
            this.txt_localIP.Name = "txt_localIP";
            this.txt_localIP.Size = new System.Drawing.Size(502, 32);
            this.txt_localIP.TabIndex = 23;
            // 
            // txt_scp_ae
            // 
            this.txt_scp_ae.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_scp_ae.Location = new System.Drawing.Point(323, 83);
            this.txt_scp_ae.Name = "txt_scp_ae";
            this.txt_scp_ae.Size = new System.Drawing.Size(358, 32);
            this.txt_scp_ae.TabIndex = 24;
            // 
            // txt_scp_temporary_path
            // 
            this.txt_scp_temporary_path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_scp_temporary_path.Location = new System.Drawing.Point(323, 163);
            this.txt_scp_temporary_path.Name = "txt_scp_temporary_path";
            this.txt_scp_temporary_path.Size = new System.Drawing.Size(358, 32);
            this.txt_scp_temporary_path.TabIndex = 25;
            // 
            // txt_scp_path
            // 
            this.txt_scp_path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_scp_path.Location = new System.Drawing.Point(323, 203);
            this.txt_scp_path.Name = "txt_scp_path";
            this.txt_scp_path.Size = new System.Drawing.Size(358, 32);
            this.txt_scp_path.TabIndex = 26;
            // 
            // txt_scu_ae
            // 
            this.txt_scu_ae.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_scu_ae.Location = new System.Drawing.Point(323, 243);
            this.txt_scu_ae.Name = "txt_scu_ae";
            this.txt_scu_ae.Size = new System.Drawing.Size(358, 32);
            this.txt_scu_ae.TabIndex = 27;
            // 
            // txt_scu_serverIP
            // 
            this.txt_scu_serverIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_scu_serverIP.Location = new System.Drawing.Point(323, 283);
            this.txt_scu_serverIP.Name = "txt_scu_serverIP";
            this.txt_scu_serverIP.Size = new System.Drawing.Size(358, 32);
            this.txt_scu_serverIP.TabIndex = 28;
            // 
            // txt_scu_serverPort
            // 
            this.txt_scu_serverPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_scu_serverPort.Location = new System.Drawing.Point(323, 323);
            this.txt_scu_serverPort.Name = "txt_scu_serverPort";
            this.txt_scu_serverPort.Size = new System.Drawing.Size(358, 32);
            this.txt_scu_serverPort.TabIndex = 29;
            // 
            // txt_scu_serverAE
            // 
            this.txt_scu_serverAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_scu_serverAE.Location = new System.Drawing.Point(323, 363);
            this.txt_scu_serverAE.Name = "txt_scu_serverAE";
            this.txt_scu_serverAE.Size = new System.Drawing.Size(358, 32);
            this.txt_scu_serverAE.TabIndex = 30;
            // 
            // ckb_suc_deleteLocalFile
            // 
            this.ckb_suc_deleteLocalFile.Location = new System.Drawing.Point(3, 283);
            this.ckb_suc_deleteLocalFile.Name = "ckb_suc_deleteLocalFile";
            this.ckb_suc_deleteLocalFile.Properties.Caption = "删除本地文件";
            this.ckb_suc_deleteLocalFile.Size = new System.Drawing.Size(170, 34);
            this.ckb_suc_deleteLocalFile.TabIndex = 33;
            this.ckb_suc_deleteLocalFile.CheckedChanged += new System.EventHandler(this.ckb_suc_deleteLocalFile_CheckedChanged);
            // 
            // ckb_scp_tempPath_listener
            // 
            this.ckb_scp_tempPath_listener.Location = new System.Drawing.Point(3, 163);
            this.ckb_scp_tempPath_listener.Name = "ckb_scp_tempPath_listener";
            this.ckb_scp_tempPath_listener.Properties.Caption = "启用目录监听";
            this.ckb_scp_tempPath_listener.Size = new System.Drawing.Size(170, 34);
            this.ckb_scp_tempPath_listener.TabIndex = 31;
            this.ckb_scp_tempPath_listener.CheckedChanged += new System.EventHandler(this.ckb_scp_tempPath_listener_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(703, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 613);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suh Dicom Trancefer  V0303";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_scp_port.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_localIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_scp_ae.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_scp_temporary_path.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_scp_path.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_scu_ae.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_scu_serverIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_scu_serverPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_scu_serverAE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_suc_deleteLocalFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_scp_tempPath_listener.Properties)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_storage_scp;
        private System.Windows.Forms.RichTextBox txt_log;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_fileBrower;
        private System.Windows.Forms.Button btn_storeSCU;
        private System.Windows.Forms.TextBox txt_sendFilePath;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit txt_scp_port;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.TextEdit txt_localIP;
        private DevExpress.XtraEditors.TextEdit txt_scp_ae;
        private DevExpress.XtraEditors.TextEdit txt_scp_temporary_path;
        private DevExpress.XtraEditors.TextEdit txt_scp_path;
        private DevExpress.XtraEditors.TextEdit txt_scu_ae;
        private DevExpress.XtraEditors.TextEdit txt_scu_serverIP;
        private DevExpress.XtraEditors.TextEdit txt_scu_serverPort;
        private DevExpress.XtraEditors.TextEdit txt_scu_serverAE;
        private DevExpress.XtraEditors.CheckEdit ckb_scp_tempPath_listener;
        private DevExpress.XtraEditors.CheckEdit ckb_suc_deleteLocalFile;
        private DevExpress.XtraEditors.SimpleButton btn_service_install;
        private DevExpress.XtraEditors.SimpleButton btn_service_uninstall;
        private DevExpress.XtraEditors.SimpleButton btn_service_start;
        private DevExpress.XtraEditors.SimpleButton btn_service_stop;
    }
}

