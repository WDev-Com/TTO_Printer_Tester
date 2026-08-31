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
            tabControlMain = new TabControl();
            tabPrint = new TabPage();
            grpSystem = new GroupBox();
            btnDeletePrinter = new Button();
            btnEditPrinter = new Button();
            btnAddPrinter = new Button();
            cmbPrinterType = new ComboBox();
            lblPrinterType = new Label();
            grpConn = new GroupBox();
            cmbStopBits = new ComboBox();
            lblStopBits = new Label();
            cmbParity = new ComboBox();
            lblParity = new Label();
            cmbDataBits = new ComboBox();
            lblDataBits = new Label();
            cmbBaudRate = new ComboBox();
            lblBaud = new Label();
            cmbComPort = new ComboBox();
            lblCom = new Label();
            txtTcpPort = new TextBox();
            lblPort = new Label();
            txtIpAddress = new TextBox();
            lblIp = new Label();
            rdoSerial = new RadioButton();
            rdoTcp = new RadioButton();
            grpData = new GroupBox();
            btnRemoveField = new Button();
            btnAddField = new Button();
            lblCustomGrid = new Label();
            dgvCustomFields = new DataGridView();
            dtpExpDate = new DateTimePicker();
            lblExp = new Label();
            dtpMfgDate = new DateTimePicker();
            lblMfg = new Label();
            txtBatchNo = new TextBox();
            lblBatch = new Label();
            txtMessageName = new TextBox();
            lblMsg = new Label();
            btnSend = new Button();
            txtLog = new TextBox();
            tabProtocols = new TabPage();
            btnDeleteProtocol = new Button();
            btnSaveProtocols = new Button();
            lblProtocolTitle = new Label();
            dgvProtocols = new DataGridView();
            tabControlMain.SuspendLayout();
            tabPrint.SuspendLayout();
            grpSystem.SuspendLayout();
            grpConn.SuspendLayout();
            grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomFields).BeginInit();
            tabProtocols.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProtocols).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMain.Controls.Add(tabPrint);
            tabControlMain.Controls.Add(tabProtocols);
            tabControlMain.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tabControlMain.ItemSize = new Size(200, 42);
            tabControlMain.Location = new Point(12, 12);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(956, 845);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 0;
            // 
            // tabPrint
            // 
            tabPrint.Controls.Add(grpSystem);
            tabPrint.Controls.Add(grpConn);
            tabPrint.Controls.Add(grpData);
            tabPrint.Controls.Add(btnSend);
            tabPrint.Controls.Add(txtLog);
            tabPrint.Location = new Point(4, 46);
            tabPrint.Name = "tabPrint";
            tabPrint.Padding = new Padding(3);
            tabPrint.Size = new Size(948, 795);
            tabPrint.TabIndex = 0;
            tabPrint.Text = "Check Print";
            tabPrint.UseVisualStyleBackColor = true;
            // 
            // grpSystem
            // 
            grpSystem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpSystem.Controls.Add(btnDeletePrinter);
            grpSystem.Controls.Add(btnEditPrinter);
            grpSystem.Controls.Add(btnAddPrinter);
            grpSystem.Controls.Add(cmbPrinterType);
            grpSystem.Controls.Add(lblPrinterType);
            grpSystem.Location = new Point(6, 6);
            grpSystem.Name = "grpSystem";
            grpSystem.Size = new Size(936, 75);
            grpSystem.TabIndex = 0;
            grpSystem.TabStop = false;
            grpSystem.Text = "1. Printer Profile Selection";
            // 
            // btnDeletePrinter
            // 
            btnDeletePrinter.BackColor = Color.LightCoral;
            btnDeletePrinter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeletePrinter.ForeColor = Color.White;
            btnDeletePrinter.Location = new Point(648, 27);
            btnDeletePrinter.Name = "btnDeletePrinter";
            btnDeletePrinter.Size = new Size(100, 32);
            btnDeletePrinter.TabIndex = 4;
            btnDeletePrinter.Text = "Delete";
            btnDeletePrinter.UseVisualStyleBackColor = false;
            btnDeletePrinter.Click += btnDeletePrinter_Click;
            // 
            // btnEditPrinter
            // 
            btnEditPrinter.BackColor = Color.Gainsboro;
            btnEditPrinter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditPrinter.Location = new Point(538, 27);
            btnEditPrinter.Name = "btnEditPrinter";
            btnEditPrinter.Size = new Size(100, 32);
            btnEditPrinter.TabIndex = 3;
            btnEditPrinter.Text = "Edit";
            btnEditPrinter.UseVisualStyleBackColor = false;
            btnEditPrinter.Click += btnEditPrinter_Click;
            // 
            // btnAddPrinter
            // 
            btnAddPrinter.BackColor = Color.Gainsboro;
            btnAddPrinter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddPrinter.Location = new Point(428, 27);
            btnAddPrinter.Name = "btnAddPrinter";
            btnAddPrinter.Size = new Size(100, 32);
            btnAddPrinter.TabIndex = 2;
            btnAddPrinter.Text = "Add";
            btnAddPrinter.UseVisualStyleBackColor = false;
            btnAddPrinter.Click += btnAddPrinter_Click;
            // 
            // cmbPrinterType
            // 
            cmbPrinterType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrinterType.FormattingEnabled = true;
            cmbPrinterType.Location = new Point(153, 30);
            cmbPrinterType.Name = "cmbPrinterType";
            cmbPrinterType.Size = new Size(260, 33);
            cmbPrinterType.TabIndex = 1;
            cmbPrinterType.SelectedIndexChanged += cmbPrinterType_SelectedIndexChanged;
            // 
            // lblPrinterType
            // 
            lblPrinterType.AutoSize = true;
            lblPrinterType.Location = new Point(15, 33);
            lblPrinterType.Name = "lblPrinterType";
            lblPrinterType.Size = new Size(141, 25);
            lblPrinterType.TabIndex = 0;
            lblPrinterType.Text = "Target Printer:";
            // 
            // grpConn
            // 
            grpConn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpConn.Controls.Add(cmbStopBits);
            grpConn.Controls.Add(lblStopBits);
            grpConn.Controls.Add(cmbParity);
            grpConn.Controls.Add(lblParity);
            grpConn.Controls.Add(cmbDataBits);
            grpConn.Controls.Add(lblDataBits);
            grpConn.Controls.Add(cmbBaudRate);
            grpConn.Controls.Add(lblBaud);
            grpConn.Controls.Add(cmbComPort);
            grpConn.Controls.Add(lblCom);
            grpConn.Controls.Add(txtTcpPort);
            grpConn.Controls.Add(lblPort);
            grpConn.Controls.Add(txtIpAddress);
            grpConn.Controls.Add(lblIp);
            grpConn.Controls.Add(rdoSerial);
            grpConn.Controls.Add(rdoTcp);
            grpConn.Location = new Point(6, 87);
            grpConn.Name = "grpConn";
            grpConn.Size = new Size(936, 175);
            grpConn.TabIndex = 1;
            grpConn.TabStop = false;
            grpConn.Text = "2. Industrial Interface & Serial Settings";
            // 
            // cmbStopBits
            // 
            cmbStopBits.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStopBits.Location = new Point(784, 132);
            cmbStopBits.Name = "cmbStopBits";
            cmbStopBits.Size = new Size(90, 33);
            cmbStopBits.TabIndex = 15;
            // 
            // lblStopBits
            // 
            lblStopBits.AutoSize = true;
            lblStopBits.Location = new Point(696, 135);
            lblStopBits.Name = "lblStopBits";
            lblStopBits.Size = new Size(88, 25);
            lblStopBits.TabIndex = 16;
            lblStopBits.Text = "Stop Bit:";
            // 
            // cmbParity
            // 
            cmbParity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParity.Location = new Point(784, 95);
            cmbParity.Name = "cmbParity";
            cmbParity.Size = new Size(90, 33);
            cmbParity.TabIndex = 17;
            // 
            // lblParity
            // 
            lblParity.AutoSize = true;
            lblParity.Location = new Point(714, 98);
            lblParity.Name = "lblParity";
            lblParity.Size = new Size(69, 25);
            lblParity.TabIndex = 18;
            lblParity.Text = "Parity:";
            // 
            // cmbDataBits
            // 
            cmbDataBits.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDataBits.Location = new Point(784, 58);
            cmbDataBits.Name = "cmbDataBits";
            cmbDataBits.Size = new Size(90, 33);
            cmbDataBits.TabIndex = 19;
            // 
            // lblDataBits
            // 
            lblDataBits.AutoSize = true;
            lblDataBits.Location = new Point(696, 61);
            lblDataBits.Name = "lblDataBits";
            lblDataBits.Size = new Size(87, 25);
            lblDataBits.TabIndex = 20;
            lblDataBits.Text = "Data Bit:";
            // 
            // cmbBaudRate
            // 
            cmbBaudRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBaudRate.Location = new Point(546, 95);
            cmbBaudRate.Name = "cmbBaudRate";
            cmbBaudRate.Size = new Size(100, 33);
            cmbBaudRate.TabIndex = 21;
            // 
            // lblBaud
            // 
            lblBaud.AutoSize = true;
            lblBaud.Location = new Point(439, 98);
            lblBaud.Name = "lblBaud";
            lblBaud.Size = new Size(107, 25);
            lblBaud.TabIndex = 22;
            lblBaud.Text = "Baud Rate:";
            // 
            // cmbComPort
            // 
            cmbComPort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbComPort.Location = new Point(546, 58);
            cmbComPort.Name = "cmbComPort";
            cmbComPort.Size = new Size(100, 33);
            cmbComPort.TabIndex = 23;
            // 
            // lblCom
            // 
            lblCom.AutoSize = true;
            lblCom.Location = new Point(439, 61);
            lblCom.Name = "lblCom";
            lblCom.Size = new Size(105, 25);
            lblCom.TabIndex = 24;
            lblCom.Text = "COM Port:";
            // 
            // txtTcpPort
            // 
            txtTcpPort.Location = new Point(197, 95);
            txtTcpPort.Name = "txtTcpPort";
            txtTcpPort.Size = new Size(130, 32);
            txtTcpPort.TabIndex = 25;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(142, 98);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(56, 25);
            lblPort.TabIndex = 26;
            lblPort.Text = "Port:";
            // 
            // txtIpAddress
            // 
            txtIpAddress.Location = new Point(197, 58);
            txtIpAddress.Name = "txtIpAddress";
            txtIpAddress.Size = new Size(130, 32);
            txtIpAddress.TabIndex = 27;
            // 
            // lblIp
            // 
            lblIp.AutoSize = true;
            lblIp.Location = new Point(87, 61);
            lblIp.Name = "lblIp";
            lblIp.Size = new Size(111, 25);
            lblIp.TabIndex = 28;
            lblIp.Text = "IP Address:";
            // 
            // rdoSerial
            // 
            rdoSerial.AutoSize = true;
            rdoSerial.Location = new Point(439, 27);
            rdoSerial.Name = "rdoSerial";
            rdoSerial.Size = new Size(151, 29);
            rdoSerial.TabIndex = 29;
            rdoSerial.Text = "RS-232 Serial";
            // 
            // rdoTcp
            // 
            rdoTcp.AutoSize = true;
            rdoTcp.Location = new Point(87, 27);
            rdoTcp.Name = "rdoTcp";
            rdoTcp.Size = new Size(93, 29);
            rdoTcp.TabIndex = 30;
            rdoTcp.Text = "TCP/IP";
            rdoTcp.CheckedChanged += rdoTcp_CheckedChanged;
            // 
            // grpData
            // 
            grpData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpData.Controls.Add(btnRemoveField);
            grpData.Controls.Add(btnAddField);
            grpData.Controls.Add(lblCustomGrid);
            grpData.Controls.Add(dgvCustomFields);
            grpData.Controls.Add(dtpExpDate);
            grpData.Controls.Add(lblExp);
            grpData.Controls.Add(dtpMfgDate);
            grpData.Controls.Add(lblMfg);
            grpData.Controls.Add(txtBatchNo);
            grpData.Controls.Add(lblBatch);
            grpData.Controls.Add(txtMessageName);
            grpData.Controls.Add(lblMsg);
            grpData.Location = new Point(6, 268);
            grpData.Name = "grpData";
            grpData.Size = new Size(936, 290);
            grpData.TabIndex = 2;
            grpData.TabStop = false;
            grpData.Text = "3. Variable Print Payload";
            // 
            // btnRemoveField
            // 
            btnRemoveField.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemoveField.Location = new Point(787, 247);
            btnRemoveField.Name = "btnRemoveField";
            btnRemoveField.Size = new Size(142, 32);
            btnRemoveField.TabIndex = 0;
            btnRemoveField.Text = "- Remove";
            btnRemoveField.Click += btnRemoveField_Click;
            // 
            // btnAddField
            // 
            btnAddField.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddField.Location = new Point(676, 247);
            btnAddField.Name = "btnAddField";
            btnAddField.Size = new Size(105, 32);
            btnAddField.TabIndex = 1;
            btnAddField.Text = "+ Add Field";
            btnAddField.Click += btnAddField_Click;
            // 
            // lblCustomGrid
            // 
            lblCustomGrid.AutoSize = true;
            lblCustomGrid.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomGrid.Location = new Point(393, 28);
            lblCustomGrid.Name = "lblCustomGrid";
            lblCustomGrid.Size = new Size(177, 20);
            lblCustomGrid.TabIndex = 2;
            lblCustomGrid.Text = "Dynamic Payload Fields:";
            // 
            // dgvCustomFields
            // 
            dgvCustomFields.AllowUserToAddRows = false;
            dgvCustomFields.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomFields.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomFields.Location = new Point(393, 52);
            dgvCustomFields.Name = "dgvCustomFields";
            dgvCustomFields.RowHeadersWidth = 51;
            dgvCustomFields.Size = new Size(536, 185);
            dgvCustomFields.TabIndex = 3;
            // 
            // dtpExpDate
            // 
            dtpExpDate.Format = DateTimePickerFormat.Short;
            dtpExpDate.Location = new Point(167, 185);
            dtpExpDate.Name = "dtpExpDate";
            dtpExpDate.Size = new Size(215, 32);
            dtpExpDate.TabIndex = 4;
            // 
            // lblExp
            // 
            lblExp.AutoSize = true;
            lblExp.Location = new Point(72, 185);
            lblExp.Name = "lblExp";
            lblExp.Size = new Size(97, 25);
            lblExp.TabIndex = 5;
            lblExp.Text = "EXP Date:";
            // 
            // dtpMfgDate
            // 
            dtpMfgDate.Format = DateTimePickerFormat.Short;
            dtpMfgDate.Location = new Point(167, 140);
            dtpMfgDate.Name = "dtpMfgDate";
            dtpMfgDate.Size = new Size(215, 32);
            dtpMfgDate.TabIndex = 6;
            // 
            // lblMfg
            // 
            lblMfg.AutoSize = true;
            lblMfg.Location = new Point(65, 140);
            lblMfg.Name = "lblMfg";
            lblMfg.Size = new Size(105, 25);
            lblMfg.TabIndex = 7;
            lblMfg.Text = "MFG Date:";
            // 
            // txtBatchNo
            // 
            txtBatchNo.Location = new Point(167, 95);
            txtBatchNo.Name = "txtBatchNo";
            txtBatchNo.Size = new Size(215, 32);
            txtBatchNo.TabIndex = 8;
            // 
            // lblBatch
            // 
            lblBatch.AutoSize = true;
            lblBatch.Location = new Point(72, 98);
            lblBatch.Name = "lblBatch";
            lblBatch.Size = new Size(98, 25);
            lblBatch.TabIndex = 9;
            lblBatch.Text = "Batch No:";
            // 
            // txtMessageName
            // 
            txtMessageName.Location = new Point(167, 50);
            txtMessageName.Name = "txtMessageName";
            txtMessageName.Size = new Size(215, 32);
            txtMessageName.TabIndex = 10;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(20, 53);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(150, 25);
            lblMsg.TabIndex = 11;
            lblMsg.Text = "Message Name:";
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSend.BackColor = Color.SteelBlue;
            btnSend.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(6, 564);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(936, 52);
            btnSend.TabIndex = 3;
            btnSend.Text = "PRINT";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += BtnSend_Click;
            // 
            // txtLog
            // 
            txtLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLog.BackColor = Color.Silver;
            txtLog.Font = new Font("Consolas", 9F);
            txtLog.Location = new Point(6, 622);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(936, 167);
            txtLog.TabIndex = 4;
            // 
            // tabProtocols
            // 
            tabProtocols.Controls.Add(btnDeleteProtocol);
            tabProtocols.Controls.Add(btnSaveProtocols);
            tabProtocols.Controls.Add(lblProtocolTitle);
            tabProtocols.Controls.Add(dgvProtocols);
            tabProtocols.Location = new Point(4, 46);
            tabProtocols.Name = "tabProtocols";
            tabProtocols.Padding = new Padding(3);
            tabProtocols.Size = new Size(948, 795);
            tabProtocols.TabIndex = 1;
            tabProtocols.Text = "Protocol Management";
            tabProtocols.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProtocol
            // 
            btnDeleteProtocol.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteProtocol.BackColor = Color.LightCoral;
            btnDeleteProtocol.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteProtocol.ForeColor = Color.White;
            btnDeleteProtocol.Location = new Point(615, 746);
            btnDeleteProtocol.Name = "btnDeleteProtocol";
            btnDeleteProtocol.Size = new Size(150, 40);
            btnDeleteProtocol.TabIndex = 0;
            btnDeleteProtocol.Text = "Delete Protocol";
            btnDeleteProtocol.UseVisualStyleBackColor = false;
            btnDeleteProtocol.Click += btnDeleteProtocol_Click;
            // 
            // btnSaveProtocols
            // 
            btnSaveProtocols.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveProtocols.BackColor = Color.SteelBlue;
            btnSaveProtocols.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveProtocols.ForeColor = Color.White;
            btnSaveProtocols.Location = new Point(771, 746);
            btnSaveProtocols.Name = "btnSaveProtocols";
            btnSaveProtocols.Size = new Size(150, 40);
            btnSaveProtocols.TabIndex = 1;
            btnSaveProtocols.Text = "Save Protocols";
            btnSaveProtocols.UseVisualStyleBackColor = false;
            btnSaveProtocols.Click += btnSaveProtocols_Click;
            // 
            // lblProtocolTitle
            // 
            lblProtocolTitle.AutoSize = true;
            lblProtocolTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProtocolTitle.Location = new Point(20, 20);
            lblProtocolTitle.Name = "lblProtocolTitle";
            lblProtocolTitle.Size = new Size(315, 28);
            lblProtocolTitle.TabIndex = 2;
            lblProtocolTitle.Text = "Custom Protocol Configurations";
            // 
            // dgvProtocols
            // 
            dgvProtocols.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProtocols.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProtocols.Location = new Point(25, 60);
            dgvProtocols.Name = "dgvProtocols";
            dgvProtocols.RowHeadersWidth = 51;
            dgvProtocols.Size = new Size(896, 680);
            dgvProtocols.TabIndex = 1;
            // 
            // TestPrint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 868);
            Controls.Add(tabControlMain);
            MinimumSize = new Size(800, 915);
            Name = "TestPrint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Advanced Industrial Dynamic Printer Controller";
            Load += TestPrint_Load;
            tabControlMain.ResumeLayout(false);
            tabPrint.ResumeLayout(false);
            tabPrint.PerformLayout();
            grpSystem.ResumeLayout(false);
            grpSystem.PerformLayout();
            grpConn.ResumeLayout(false);
            grpConn.PerformLayout();
            grpData.ResumeLayout(false);
            grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomFields).EndInit();
            tabProtocols.ResumeLayout(false);
            tabProtocols.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProtocols).EndInit();
            ResumeLayout(false);
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