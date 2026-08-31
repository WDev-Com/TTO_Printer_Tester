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
            this.grpSystem = new System.Windows.Forms.GroupBox();
            this.btnAddPrinter = new System.Windows.Forms.Button();
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
            this.grpSystem.SuspendLayout();
            this.grpConn.SuspendLayout();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomFields)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSystem
            // 
            this.grpSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSystem.Controls.Add(this.btnAddPrinter);
            this.grpSystem.Controls.Add(this.cmbPrinterType);
            this.grpSystem.Controls.Add(this.lblPrinterType);
            this.grpSystem.Location = new System.Drawing.Point(18, 12);
            this.grpSystem.Name = "grpSystem";
            this.grpSystem.Size = new System.Drawing.Size(746, 75);
            this.grpSystem.TabIndex = 0;
            this.grpSystem.TabStop = false;
            this.grpSystem.Text = "1. Printer Profile Selection";
            // 
            // btnAddPrinter
            // 
            this.btnAddPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPrinter.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddPrinter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddPrinter.Location = new System.Drawing.Point(600, 27);
            this.btnAddPrinter.Name = "btnAddPrinter";
            this.btnAddPrinter.Size = new System.Drawing.Size(130, 32);
            this.btnAddPrinter.TabIndex = 2;
            this.btnAddPrinter.Text = "+ Add Printer";
            this.btnAddPrinter.UseVisualStyleBackColor = false;
            this.btnAddPrinter.Click += new System.EventHandler(this.btnAddPrinter_Click);
            // 
            // cmbPrinterType
            // 
            this.cmbPrinterType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPrinterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrinterType.FormattingEnabled = true;
            this.cmbPrinterType.Location = new System.Drawing.Point(135, 30);
            this.cmbPrinterType.Name = "cmbPrinterType";
            this.cmbPrinterType.Size = new System.Drawing.Size(450, 28);
            this.cmbPrinterType.TabIndex = 1;
            this.cmbPrinterType.SelectedIndexChanged += new System.EventHandler(this.cmbPrinterType_SelectedIndexChanged);
            // 
            // lblPrinterType
            // 
            this.lblPrinterType.AutoSize = true;
            this.lblPrinterType.Location = new System.Drawing.Point(20, 33);
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
            this.grpConn.Location = new System.Drawing.Point(18, 93);
            this.grpConn.Name = "grpConn";
            this.grpConn.Size = new System.Drawing.Size(746, 175);
            this.grpConn.TabIndex = 1;
            this.grpConn.TabStop = false;
            this.grpConn.Text = "2. Industrial Interface & Serial Settings";
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Location = new System.Drawing.Point(580, 132);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(90, 28);
            this.cmbStopBits.TabIndex = 15;
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(505, 135);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(65, 20);
            this.lblStopBits.TabIndex = 14;
            this.lblStopBits.Text = "Stop Bit:";
            // 
            // cmbParity
            // 
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(580, 95);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(90, 28);
            this.cmbParity.TabIndex = 13;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(505, 98);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(48, 20);
            this.lblParity.TabIndex = 12;
            this.lblParity.Text = "Parity:";
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Location = new System.Drawing.Point(580, 58);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(90, 28);
            this.cmbDataBits.TabIndex = 11;
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(505, 61);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(66, 20);
            this.lblDataBits.TabIndex = 10;
            this.lblDataBits.Text = "Data Bit:";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(365, 95);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(100, 28);
            this.cmbBaudRate.TabIndex = 9;
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Location = new System.Drawing.Point(275, 98);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(80, 20);
            this.lblBaud.TabIndex = 8;
            this.lblBaud.Text = "Baud Rate:";
            // 
            // cmbComPort
            // 
            this.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(365, 58);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(100, 28);
            this.cmbComPort.TabIndex = 7;
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(275, 61);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(75, 20);
            this.lblCom.TabIndex = 6;
            this.lblCom.Text = "COM Port:";
            // 
            // txtTcpPort
            // 
            this.txtTcpPort.Location = new System.Drawing.Point(105, 95);
            this.txtTcpPort.Name = "txtTcpPort";
            this.txtTcpPort.Size = new System.Drawing.Size(130, 27);
            this.txtTcpPort.TabIndex = 4;
            this.txtTcpPort.Text = "3001";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(20, 98);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(38, 20);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port:";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(105, 58);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(130, 27);
            this.txtIpAddress.TabIndex = 2;
            this.txtIpAddress.Text = "192.168.1.100";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(20, 61);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(81, 20);
            this.lblIp.TabIndex = 1;
            this.lblIp.Text = "IP Address:";
            // 
            // rdoSerial
            // 
            this.rdoSerial.AutoSize = true;
            this.rdoSerial.Location = new System.Drawing.Point(275, 27);
            this.rdoSerial.Name = "rdoSerial";
            this.rdoSerial.Size = new System.Drawing.Size(118, 24);
            this.rdoSerial.TabIndex = 5;
            this.rdoSerial.Text = "RS-232 Serial";
            this.rdoSerial.UseVisualStyleBackColor = true;
            // 
            // rdoTcp
            // 
            this.rdoTcp.AutoSize = true;
            this.rdoTcp.Checked = true;
            this.rdoTcp.Location = new System.Drawing.Point(20, 27);
            this.rdoTcp.Name = "rdoTcp";
            this.rdoTcp.Size = new System.Drawing.Size(72, 24);
            this.rdoTcp.TabIndex = 0;
            this.rdoTcp.TabStop = true;
            this.rdoTcp.Text = "TCP/IP";
            this.rdoTcp.UseVisualStyleBackColor = true;
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
            this.grpData.Location = new System.Drawing.Point(18, 275);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(746, 290);
            this.grpData.TabIndex = 2;
            this.grpData.TabStop = false;
            this.grpData.Text = "3. Variable Print Payload (Core & Dynamic Variables)";
            // 
            // btnRemoveField
            // 
            this.btnRemoveField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveField.Location = new System.Drawing.Point(620, 247);
            this.btnRemoveField.Name = "btnRemoveField";
            this.btnRemoveField.Size = new System.Drawing.Size(100, 32);
            this.btnRemoveField.TabIndex = 11;
            this.btnRemoveField.Text = "- Remove";
            this.btnRemoveField.UseVisualStyleBackColor = true;
            this.btnRemoveField.Click += new System.EventHandler(this.btnRemoveField_Click);
            // 
            // btnAddField
            // 
            this.btnAddField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddField.Location = new System.Drawing.Point(505, 247);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(105, 32);
            this.btnAddField.TabIndex = 10;
            this.btnAddField.Text = "+ Add Field";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // lblCustomGrid
            // 
            this.lblCustomGrid.AutoSize = true;
            this.lblCustomGrid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomGrid.Location = new System.Drawing.Point(380, 28);
            this.lblCustomGrid.Name = "lblCustomGrid";
            this.lblCustomGrid.Size = new System.Drawing.Size(177, 20);
            this.lblCustomGrid.TabIndex = 9;
            this.lblCustomGrid.Text = "Dynamic Payload Fields:";
            // 
            // dgvCustomFields
            // 
            this.dgvCustomFields.AllowUserToAddRows = false;
            this.dgvCustomFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomFields.Location = new System.Drawing.Point(380, 52);
            this.dgvCustomFields.Name = "dgvCustomFields";
            this.dgvCustomFields.RowHeadersWidth = 30;
            this.dgvCustomFields.Size = new System.Drawing.Size(340, 185);
            this.dgvCustomFields.TabIndex = 8;
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpDate.Location = new System.Drawing.Point(140, 185);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(215, 27);
            this.dtpExpDate.TabIndex = 7;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(20, 188);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(73, 20);
            this.lblExp.TabIndex = 6;
            this.lblExp.Text = "EXP Date:";
            // 
            // dtpMfgDate
            // 
            this.dtpMfgDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMfgDate.Location = new System.Drawing.Point(140, 140);
            this.dtpMfgDate.Name = "dtpMfgDate";
            this.dtpMfgDate.Size = new System.Drawing.Size(215, 27);
            this.dtpMfgDate.TabIndex = 5;
            // 
            // lblMfg
            // 
            this.lblMfg.AutoSize = true;
            this.lblMfg.Location = new System.Drawing.Point(20, 143);
            this.lblMfg.Name = "lblMfg";
            this.lblMfg.Size = new System.Drawing.Size(78, 20);
            this.lblMfg.TabIndex = 4;
            this.lblMfg.Text = "MFG Date:";
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Location = new System.Drawing.Point(140, 95);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(215, 27);
            this.txtBatchNo.TabIndex = 3;
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.Location = new System.Drawing.Point(20, 98);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(73, 20);
            this.lblBatch.TabIndex = 2;
            this.lblBatch.Text = "Batch No:";
            // 
            // txtMessageName
            // 
            this.txtMessageName.Location = new System.Drawing.Point(140, 50);
            this.txtMessageName.Name = "txtMessageName";
            this.txtMessageName.Size = new System.Drawing.Size(215, 27);
            this.txtMessageName.TabIndex = 1;
            this.txtMessageName.Text = "DEFAULT_JOB";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(20, 53);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(114, 20);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Message Name:";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(18, 575);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(746, 52);
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
            this.txtLog.ForeColor = System.Drawing.Color.Black;
            this.txtLog.Location = new System.Drawing.Point(18, 638);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(746, 215);
            this.txtLog.TabIndex = 4;
            // 
            // TestPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 868);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.grpConn);
            this.Controls.Add(this.grpSystem);
            this.MinimumSize = new System.Drawing.Size(780, 850);
            this.Name = "TestPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Industrial Dynamic Printer Controller";
            this.Load += new System.EventHandler(this.TestPrint_Load);
            this.grpSystem.ResumeLayout(false);
            this.grpSystem.PerformLayout();
            this.grpConn.ResumeLayout(false);
            this.grpConn.PerformLayout();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomFields)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpSystem;
        private System.Windows.Forms.Button btnAddPrinter;
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
    }
}