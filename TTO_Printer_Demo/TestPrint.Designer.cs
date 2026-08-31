namespace TTO_Printer_Demo
{
    partial class TestPrint
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPrint = new System.Windows.Forms.TabPage();
            this.tabProtocols = new System.Windows.Forms.TabPage();
            this.btnDeleteProtocol = new System.Windows.Forms.Button();

            // Main UI Controls
            this.grpSystem = new System.Windows.Forms.GroupBox();
            this.btnAddPrinter = new System.Windows.Forms.Button();
            this.btnEditPrinter = new System.Windows.Forms.Button();
            this.btnDeletePrinter = new System.Windows.Forms.Button();
            this.cmbPrinterType = new System.Windows.Forms.ComboBox();
            this.lblPrinterType = new System.Windows.Forms.Label();
            this.grpConn = new System.Windows.Forms.GroupBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.lblBaud = new System.Windows.Forms.Label();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.lblCom = new System.Windows.Forms.Label();
            this.txtTcpPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.rdoSerial = new System.Windows.Forms.RadioButton();
            this.rdoTcp = new System.Windows.Forms.RadioButton();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.btnRemoveField = new System.Windows.Forms.Button();
            this.btnAddField = new System.Windows.Forms.Button();
            this.lblCustomGrid = new System.Windows.Forms.Label();
            this.dgvCustomFields = new System.Windows.Forms.DataGridView();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.lblExp = new System.Windows.Forms.Label();
            this.dtpMfgDate = new System.Windows.Forms.DateTimePicker();
            this.lblMfg = new System.Windows.Forms.Label();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.lblBatch = new System.Windows.Forms.Label();
            this.txtMessageName = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();

            // Protocol Tab Controls
            this.dgvProtocols = new System.Windows.Forms.DataGridView();
            this.lblProtocolTitle = new System.Windows.Forms.Label();
            this.btnSaveProtocols = new System.Windows.Forms.Button();

            this.tabControlMain.SuspendLayout();
            this.tabPrint.SuspendLayout();
            this.tabProtocols.SuspendLayout();
            this.grpSystem.SuspendLayout();
            this.grpConn.SuspendLayout();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocols)).BeginInit();
            this.SuspendLayout();
            // 
            // Protocol Tab Setup (New Functionality UI)
            // 
            this.lblProtocolTitle.AutoSize = true;
            this.lblProtocolTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProtocolTitle.Location = new System.Drawing.Point(20, 20);
            this.lblProtocolTitle.Name = "lblProtocolTitle";
            this.lblProtocolTitle.Size = new System.Drawing.Size(286, 28);
            this.lblProtocolTitle.Text = "Custom Protocol Configurations";

            this.dgvProtocols.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProtocols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProtocols.Location = new System.Drawing.Point(25, 60);
            this.dgvProtocols.Name = "dgvProtocols";
            this.dgvProtocols.Size = new System.Drawing.Size(700, 680);
            this.dgvProtocols.TabIndex = 1;

            // 
            // btnDeleteProtocol (NEW)
            // 
            this.btnDeleteProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProtocol.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteProtocol.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProtocol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteProtocol.Location = new System.Drawing.Point(415, 755);
            this.btnDeleteProtocol.Name = "btnDeleteProtocol";
            this.btnDeleteProtocol.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteProtocol.Text = "Delete Protocol";
            this.btnDeleteProtocol.UseVisualStyleBackColor = false;
            this.btnDeleteProtocol.Click += new System.EventHandler(this.btnDeleteProtocol_Click);

            this.btnSaveProtocols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveProtocols.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveProtocols.ForeColor = System.Drawing.Color.White;
            this.btnSaveProtocols.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveProtocols.Location = new System.Drawing.Point(575, 755);
            this.btnSaveProtocols.Name = "btnSaveProtocols";
            this.btnSaveProtocols.Size = new System.Drawing.Size(150, 40);
            this.btnSaveProtocols.Text = "Save Protocols";
            this.btnSaveProtocols.UseVisualStyleBackColor = false;
            this.btnSaveProtocols.Click += new System.EventHandler(this.btnSaveProtocols_Click);
            // 
            // tabProtocols
            // 
            this.tabProtocols.Controls.Add(this.btnDeleteProtocol); // Add delete button
            this.tabProtocols.Controls.Add(this.btnSaveProtocols);
            this.tabProtocols.Controls.Add(this.lblProtocolTitle);
            this.tabProtocols.Controls.Add(this.dgvProtocols);
            this.tabProtocols.Location = new System.Drawing.Point(4, 29);
            this.tabProtocols.Name = "tabProtocols";
            this.tabProtocols.Padding = new System.Windows.Forms.Padding(3);
            this.tabProtocols.Size = new System.Drawing.Size(752, 812);
            this.tabProtocols.TabIndex = 1;
            this.tabProtocols.Text = "Protocol Management";
            this.tabProtocols.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPrint);
            this.tabControlMain.Controls.Add(this.tabProtocols);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(760, 845);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPrint
            // 
            this.tabPrint.Controls.Add(this.grpSystem);
            this.tabPrint.Controls.Add(this.grpConn);
            this.tabPrint.Controls.Add(this.grpData);
            this.tabPrint.Controls.Add(this.btnSend);
            this.tabPrint.Controls.Add(this.txtLog);
            this.tabPrint.Location = new System.Drawing.Point(4, 29);
            this.tabPrint.Name = "tabPrint";
            this.tabPrint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrint.Size = new System.Drawing.Size(752, 812);
            this.tabPrint.TabIndex = 0;
            this.tabPrint.Text = "Main Operations";
            this.tabPrint.UseVisualStyleBackColor = true;
            // 
            // tabProtocols
            // 
            this.tabProtocols.Controls.Add(this.btnSaveProtocols);
            this.tabProtocols.Controls.Add(this.lblProtocolTitle);
            this.tabProtocols.Controls.Add(this.dgvProtocols);
            this.tabProtocols.Location = new System.Drawing.Point(4, 29);
            this.tabProtocols.Name = "tabProtocols";
            this.tabProtocols.Padding = new System.Windows.Forms.Padding(3);
            this.tabProtocols.Size = new System.Drawing.Size(752, 812);
            this.tabProtocols.TabIndex = 1;
            this.tabProtocols.Text = "Protocol Management";
            this.tabProtocols.UseVisualStyleBackColor = true;
            // 
            // grpSystem
            // 
            this.grpSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSystem.Controls.Add(this.btnDeletePrinter);
            this.grpSystem.Controls.Add(this.btnEditPrinter);
            this.grpSystem.Controls.Add(this.btnAddPrinter);
            this.grpSystem.Controls.Add(this.cmbPrinterType);
            this.grpSystem.Controls.Add(this.lblPrinterType);
            this.grpSystem.Location = new System.Drawing.Point(6, 6);
            this.grpSystem.Name = "grpSystem";
            this.grpSystem.Size = new System.Drawing.Size(740, 75);
            this.grpSystem.TabIndex = 0;
            this.grpSystem.TabStop = false;
            this.grpSystem.Text = "1. Printer Profile Selection";
            // 
            // btnAddPrinter
            // 
            this.btnAddPrinter.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddPrinter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddPrinter.Location = new System.Drawing.Point(400, 27);
            this.btnAddPrinter.Name = "btnAddPrinter";
            this.btnAddPrinter.Size = new System.Drawing.Size(100, 32);
            this.btnAddPrinter.TabIndex = 2;
            this.btnAddPrinter.Text = "Add";
            this.btnAddPrinter.UseVisualStyleBackColor = false;
            this.btnAddPrinter.Click += new System.EventHandler(this.btnAddPrinter_Click);
            // 
            // btnEditPrinter
            // 
            this.btnEditPrinter.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditPrinter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditPrinter.Location = new System.Drawing.Point(510, 27);
            this.btnEditPrinter.Name = "btnEditPrinter";
            this.btnEditPrinter.Size = new System.Drawing.Size(100, 32);
            this.btnEditPrinter.TabIndex = 3;
            this.btnEditPrinter.Text = "Edit";
            this.btnEditPrinter.UseVisualStyleBackColor = false;
            this.btnEditPrinter.Click += new System.EventHandler(this.btnEditPrinter_Click);
            // 
            // btnDeletePrinter
            // 
            this.btnDeletePrinter.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeletePrinter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeletePrinter.ForeColor = System.Drawing.Color.White;
            this.btnDeletePrinter.Location = new System.Drawing.Point(620, 27);
            this.btnDeletePrinter.Name = "btnDeletePrinter";
            this.btnDeletePrinter.Size = new System.Drawing.Size(100, 32);
            this.btnDeletePrinter.TabIndex = 4;
            this.btnDeletePrinter.Text = "Delete";
            this.btnDeletePrinter.UseVisualStyleBackColor = false;
            this.btnDeletePrinter.Click += new System.EventHandler(this.btnDeletePrinter_Click);
            // 
            // cmbPrinterType
            // 
            this.cmbPrinterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrinterType.FormattingEnabled = true;
            this.cmbPrinterType.Location = new System.Drawing.Point(125, 30);
            this.cmbPrinterType.Name = "cmbPrinterType";
            this.cmbPrinterType.Size = new System.Drawing.Size(260, 28);
            this.cmbPrinterType.TabIndex = 1;
            this.cmbPrinterType.SelectedIndexChanged += new System.EventHandler(this.cmbPrinterType_SelectedIndexChanged);
            // 
            // lblPrinterType
            // 
            this.lblPrinterType.AutoSize = true;
            this.lblPrinterType.Location = new System.Drawing.Point(15, 33);
            this.lblPrinterType.Name = "lblPrinterType";
            this.lblPrinterType.Size = new System.Drawing.Size(100, 20);
            this.lblPrinterType.TabIndex = 0;
            this.lblPrinterType.Text = "Target Printer:";
            // 
            // grpConn
            // 
            this.grpConn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConn.Controls.Add(this.cmbStopBits);
            this.grpConn.Controls.Add(this.lblStopBits);
            this.grpConn.Controls.Add(this.cmbParity);
            this.grpConn.Controls.Add(this.lblParity);
            this.grpConn.Controls.Add(this.cmbDataBits);
            this.grpConn.Controls.Add(this.lblDataBits);
            this.grpConn.Controls.Add(this.cmbBaudRate);
            this.grpConn.Controls.Add(this.lblBaud);
            this.grpConn.Controls.Add(this.cmbComPort);
            this.grpConn.Controls.Add(this.lblCom);
            this.grpConn.Controls.Add(this.txtTcpPort);
            this.grpConn.Controls.Add(this.lblPort);
            this.grpConn.Controls.Add(this.txtIpAddress);
            this.grpConn.Controls.Add(this.lblIp);
            this.grpConn.Controls.Add(this.rdoSerial);
            this.grpConn.Controls.Add(this.rdoTcp);
            this.grpConn.Location = new System.Drawing.Point(6, 87);
            this.grpConn.Name = "grpConn";
            this.grpConn.Size = new System.Drawing.Size(740, 175);
            this.grpConn.TabIndex = 1;
            this.grpConn.TabStop = false;
            this.grpConn.Text = "2. Industrial Interface & Serial Settings";
            // 
            // cmbStopBits ... (Standard setup from original) ...
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.Location = new System.Drawing.Point(580, 132);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(90, 28);
            this.cmbStopBits.TabIndex = 15;
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(505, 135);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(65, 20);
            this.lblStopBits.Text = "Stop Bit:";

            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.Location = new System.Drawing.Point(580, 95);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(90, 28);
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(505, 98);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(48, 20);
            this.lblParity.Text = "Parity:";

            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.Location = new System.Drawing.Point(580, 58);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(90, 28);
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(505, 61);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(66, 20);
            this.lblDataBits.Text = "Data Bit:";

            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.Location = new System.Drawing.Point(365, 95);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(100, 28);
            this.lblBaud.AutoSize = true;
            this.lblBaud.Location = new System.Drawing.Point(275, 98);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(80, 20);
            this.lblBaud.Text = "Baud Rate:";

            this.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComPort.Location = new System.Drawing.Point(365, 58);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(100, 28);
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(275, 61);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(75, 20);
            this.lblCom.Text = "COM Port:";

            this.txtTcpPort.Location = new System.Drawing.Point(105, 95);
            this.txtTcpPort.Name = "txtTcpPort";
            this.txtTcpPort.Size = new System.Drawing.Size(130, 27);
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(20, 98);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(38, 20);
            this.lblPort.Text = "Port:";

            this.txtIpAddress.Location = new System.Drawing.Point(105, 58);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(130, 27);
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(20, 61);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(81, 20);
            this.lblIp.Text = "IP Address:";

            this.rdoSerial.AutoSize = true;
            this.rdoSerial.Location = new System.Drawing.Point(275, 27);
            this.rdoSerial.Name = "rdoSerial";
            this.rdoSerial.Size = new System.Drawing.Size(118, 24);
            this.rdoSerial.Text = "RS-232 Serial";

            this.rdoTcp.AutoSize = true;
            this.rdoTcp.Location = new System.Drawing.Point(20, 27);
            this.rdoTcp.Name = "rdoTcp";
            this.rdoTcp.Size = new System.Drawing.Size(72, 24);
            this.rdoTcp.Text = "TCP/IP";
            this.rdoTcp.CheckedChanged += new System.EventHandler(this.rdoTcp_CheckedChanged);

            // 
            // grpData
            // 
            this.grpData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpData.Controls.Add(this.btnRemoveField);
            this.grpData.Controls.Add(this.btnAddField);
            this.grpData.Controls.Add(this.lblCustomGrid);
            this.grpData.Controls.Add(this.dgvCustomFields);
            this.grpData.Controls.Add(this.dtpExpDate);
            this.grpData.Controls.Add(this.lblExp);
            this.grpData.Controls.Add(this.dtpMfgDate);
            this.grpData.Controls.Add(this.lblMfg);
            this.grpData.Controls.Add(this.txtBatchNo);
            this.grpData.Controls.Add(this.lblBatch);
            this.grpData.Controls.Add(this.txtMessageName);
            this.grpData.Controls.Add(this.lblMsg);
            this.grpData.Location = new System.Drawing.Point(6, 268);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(740, 290);
            this.grpData.TabIndex = 2;
            this.grpData.TabStop = false;
            this.grpData.Text = "3. Variable Print Payload (Core & Dynamic Variables)";

            // ... (Data Controls remain positioned exactly as original) ...
            this.btnRemoveField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveField.Location = new System.Drawing.Point(620, 247);
            this.btnRemoveField.Name = "btnRemoveField";
            this.btnRemoveField.Size = new System.Drawing.Size(100, 32);
            this.btnRemoveField.Text = "- Remove";
            this.btnRemoveField.Click += new System.EventHandler(this.btnRemoveField_Click);

            this.btnAddField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddField.Location = new System.Drawing.Point(505, 247);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(105, 32);
            this.btnAddField.Text = "+ Add Field";
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);

            this.lblCustomGrid.AutoSize = true;
            this.lblCustomGrid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomGrid.Location = new System.Drawing.Point(380, 28);
            this.lblCustomGrid.Name = "lblCustomGrid";
            this.lblCustomGrid.Size = new System.Drawing.Size(177, 20);
            this.lblCustomGrid.Text = "Dynamic Payload Fields:";

            this.dgvCustomFields.AllowUserToAddRows = false;
            this.dgvCustomFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomFields.Location = new System.Drawing.Point(380, 52);
            this.dgvCustomFields.Name = "dgvCustomFields";
            this.dgvCustomFields.Size = new System.Drawing.Size(340, 185);

            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpDate.Location = new System.Drawing.Point(140, 185);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(215, 27);
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(20, 188);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(73, 20);
            this.lblExp.Text = "EXP Date:";

            this.dtpMfgDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMfgDate.Location = new System.Drawing.Point(140, 140);
            this.dtpMfgDate.Name = "dtpMfgDate";
            this.dtpMfgDate.Size = new System.Drawing.Size(215, 27);
            this.lblMfg.AutoSize = true;
            this.lblMfg.Location = new System.Drawing.Point(20, 143);
            this.lblMfg.Name = "lblMfg";
            this.lblMfg.Size = new System.Drawing.Size(78, 20);
            this.lblMfg.Text = "MFG Date:";

            this.txtBatchNo.Location = new System.Drawing.Point(140, 95);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(215, 27);
            this.lblBatch.AutoSize = true;
            this.lblBatch.Location = new System.Drawing.Point(20, 98);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(73, 20);
            this.lblBatch.Text = "Batch No:";

            this.txtMessageName.Location = new System.Drawing.Point(140, 50);
            this.txtMessageName.Name = "txtMessageName";
            this.txtMessageName.Size = new System.Drawing.Size(215, 27);
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(20, 53);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(114, 20);
            this.lblMsg.Text = "Message Name:";

            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(6, 564);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(740, 52);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "PRINT";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);

            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.Color.Silver;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtLog.Location = new System.Drawing.Point(6, 622);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(740, 184);
            this.txtLog.TabIndex = 4;

            // 
            // Protocol Tab Setup (New Functionality UI)
            // 
            this.lblProtocolTitle.AutoSize = true;
            this.lblProtocolTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProtocolTitle.Location = new System.Drawing.Point(20, 20);
            this.lblProtocolTitle.Name = "lblProtocolTitle";
            this.lblProtocolTitle.Size = new System.Drawing.Size(286, 28);
            this.lblProtocolTitle.Text = "Custom Protocol Configurations";

            this.dgvProtocols.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProtocols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProtocols.Location = new System.Drawing.Point(25, 60);
            this.dgvProtocols.Name = "dgvProtocols";
            this.dgvProtocols.Size = new System.Drawing.Size(700, 680);
            this.dgvProtocols.TabIndex = 1;

            this.btnSaveProtocols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveProtocols.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveProtocols.ForeColor = System.Drawing.Color.White;
            this.btnSaveProtocols.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveProtocols.Location = new System.Drawing.Point(575, 755);
            this.btnSaveProtocols.Name = "btnSaveProtocols";
            this.btnSaveProtocols.Size = new System.Drawing.Size(150, 40);
            this.btnSaveProtocols.Text = "Save Protocols";
            this.btnSaveProtocols.UseVisualStyleBackColor = false;

            // 
            // TestPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 868);
            this.Controls.Add(this.tabControlMain);
            this.MinimumSize = new System.Drawing.Size(800, 915);
            this.Name = "TestPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Industrial Dynamic Printer Controller";
            this.Load += new System.EventHandler(this.TestPrint_Load);

            this.tabControlMain.ResumeLayout(false);
            this.tabPrint.ResumeLayout(false);
            this.tabPrint.PerformLayout();
            this.tabProtocols.ResumeLayout(false);
            this.tabProtocols.PerformLayout();
            this.grpSystem.ResumeLayout(false);
            this.grpSystem.PerformLayout();
            this.grpConn.ResumeLayout(false);
            this.grpConn.PerformLayout();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocols)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Tab Architecture
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPrint;
        private System.Windows.Forms.TabPage tabProtocols;

        // Protocol Layout fields
        private System.Windows.Forms.DataGridView dgvProtocols;
        private System.Windows.Forms.Label lblProtocolTitle;
        private System.Windows.Forms.Button btnSaveProtocols;

        // Main Controls
        private System.Windows.Forms.GroupBox grpSystem;
        private System.Windows.Forms.Button btnAddPrinter;
        private System.Windows.Forms.Button btnEditPrinter;
        private System.Windows.Forms.Button btnDeletePrinter;
        private System.Windows.Forms.Label lblPrinterType;
        private System.Windows.Forms.ComboBox cmbPrinterType;
        private System.Windows.Forms.GroupBox grpConn;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.RadioButton rdoSerial;
        private System.Windows.Forms.RadioButton rdoTcp;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox txtTcpPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtMessageName;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.DateTimePicker dtpMfgDate;
        private System.Windows.Forms.Label lblMfg;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.DataGridView dgvCustomFields;
        private System.Windows.Forms.Label lblCustomGrid;
        private System.Windows.Forms.Button btnRemoveField;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Button btnDeleteProtocol;
    }
}