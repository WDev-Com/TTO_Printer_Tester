namespace TTO_Printer_Demo
{
    partial class PrinterConfigDialog
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
            this.lblPrinterName = new System.Windows.Forms.Label();
            this.txtPrinterName = new System.Windows.Forms.TextBox();
            this.lblProtocol = new System.Windows.Forms.Label();
            this.cmbProtocol = new System.Windows.Forms.ComboBox();
            this.grpConn = new System.Windows.Forms.GroupBox();
            this.rdoTcp = new System.Windows.Forms.RadioButton();
            this.rdoSerial = new System.Windows.Forms.RadioButton();
            this.lblIp = new System.Windows.Forms.Label();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtTcpPort = new System.Windows.Forms.TextBox();
            this.lblCom = new System.Windows.Forms.Label();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.lblBaud = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.lblDefaultJob = new System.Windows.Forms.Label();
            this.txtDefaultJob = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpConn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrinterName
            // 
            this.lblPrinterName.AutoSize = true;
            this.lblPrinterName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrinterName.Location = new System.Drawing.Point(20, 20);
            this.lblPrinterName.Name = "lblPrinterName";
            this.lblPrinterName.Size = new System.Drawing.Size(109, 20);
            this.lblPrinterName.TabIndex = 0;
            this.lblPrinterName.Text = "Printer Profile:";
            // 
            // txtPrinterName
            // 
            this.txtPrinterName.Location = new System.Drawing.Point(145, 17);
            this.txtPrinterName.Name = "txtPrinterName";
            this.txtPrinterName.Size = new System.Drawing.Size(375, 27);
            this.txtPrinterName.TabIndex = 1;
            // 
            // lblProtocol
            // 
            this.lblProtocol.AutoSize = true;
            this.lblProtocol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProtocol.Location = new System.Drawing.Point(20, 60);
            this.lblProtocol.Name = "lblProtocol";
            this.lblProtocol.Size = new System.Drawing.Size(73, 20);
            this.lblProtocol.TabIndex = 2;
            this.lblProtocol.Text = "Protocol:";
            // 
            // cmbProtocol
            // 
            this.cmbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProtocol.FormattingEnabled = true;
            this.cmbProtocol.Location = new System.Drawing.Point(145, 57);
            this.cmbProtocol.Name = "cmbProtocol";
            this.cmbProtocol.Size = new System.Drawing.Size(375, 28);
            this.cmbProtocol.TabIndex = 3;
            // 
            // grpConn
            // 
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
            this.grpConn.Location = new System.Drawing.Point(20, 100);
            this.grpConn.Name = "grpConn";
            this.grpConn.Size = new System.Drawing.Size(500, 205);
            this.grpConn.TabIndex = 4;
            this.grpConn.TabStop = false;
            this.grpConn.Text = "Default Interface Parameters";
            // 
            // rdoTcp
            // 
            this.rdoTcp.AutoSize = true;
            this.rdoTcp.Checked = true;
            this.rdoTcp.Location = new System.Drawing.Point(20, 30);
            this.rdoTcp.Name = "rdoTcp";
            this.rdoTcp.Size = new System.Drawing.Size(72, 24);
            this.rdoTcp.TabIndex = 0;
            this.rdoTcp.TabStop = true;
            this.rdoTcp.Text = "TCP/IP";
            this.rdoTcp.CheckedChanged += new System.EventHandler(this.rdoTcp_CheckedChanged);
            // 
            // rdoSerial
            // 
            this.rdoSerial.AutoSize = true;
            this.rdoSerial.Location = new System.Drawing.Point(230, 30);
            this.rdoSerial.Name = "rdoSerial";
            this.rdoSerial.Size = new System.Drawing.Size(118, 24);
            this.rdoSerial.TabIndex = 1;
            this.rdoSerial.Text = "RS-232 Serial";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(20, 68);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(81, 20);
            this.lblIp.TabIndex = 2;
            this.lblIp.Text = "IP Address:";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(105, 65);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(105, 27);
            this.txtIpAddress.TabIndex = 3;
            this.txtIpAddress.Text = "192.168.1.100";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(20, 108);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(38, 20);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port:";
            // 
            // txtTcpPort
            // 
            this.txtTcpPort.Location = new System.Drawing.Point(105, 105);
            this.txtTcpPort.Name = "txtTcpPort";
            this.txtTcpPort.Size = new System.Drawing.Size(105, 27);
            this.txtTcpPort.TabIndex = 5;
            this.txtTcpPort.Text = "3001";
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(230, 68);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(44, 20);
            this.lblCom.TabIndex = 6;
            this.lblCom.Text = "COM:";
            // 
            // cmbComPort
            // 
            this.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComPort.Location = new System.Drawing.Point(280, 65);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(80, 28);
            this.cmbComPort.TabIndex = 7;
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Location = new System.Drawing.Point(230, 108);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(45, 20);
            this.lblBaud.TabIndex = 8;
            this.lblBaud.Text = "Baud:";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.Location = new System.Drawing.Point(280, 105);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(80, 28);
            this.cmbBaudRate.TabIndex = 9;
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(370, 68);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(43, 20);
            this.lblDataBits.TabIndex = 10;
            this.lblDataBits.Text = "Data:";
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.Location = new System.Drawing.Point(420, 65);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(65, 28);
            this.cmbDataBits.TabIndex = 11;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(370, 108);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(48, 20);
            this.lblParity.TabIndex = 12;
            this.lblParity.Text = "Parity:";
            // 
            // cmbParity
            // 
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.Location = new System.Drawing.Point(420, 105);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(65, 28);
            this.cmbParity.TabIndex = 13;
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(230, 150);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(43, 20);
            this.lblStopBits.TabIndex = 14;
            this.lblStopBits.Text = "Stop:";
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.Location = new System.Drawing.Point(280, 147);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(80, 28);
            this.cmbStopBits.TabIndex = 15;
            // 
            // lblDefaultJob
            // 
            this.lblDefaultJob.AutoSize = true;
            this.lblDefaultJob.Location = new System.Drawing.Point(20, 320);
            this.lblDefaultJob.Name = "lblDefaultJob";
            this.lblDefaultJob.Size = new System.Drawing.Size(127, 20);
            this.lblDefaultJob.TabIndex = 5;
            this.lblDefaultJob.Text = "Default Job Name:";
            // 
            // txtDefaultJob
            // 
            this.txtDefaultJob.Location = new System.Drawing.Point(155, 317);
            this.txtDefaultJob.Name = "txtDefaultJob";
            this.txtDefaultJob.Size = new System.Drawing.Size(365, 27);
            this.txtDefaultJob.TabIndex = 6;
            this.txtDefaultJob.Text = "DEFAULT_JOB";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(290, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Profile";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(410, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 40);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PrinterConfigDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 420);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDefaultJob);
            this.Controls.Add(this.lblDefaultJob);
            this.Controls.Add(this.grpConn);
            this.Controls.Add(this.cmbProtocol);
            this.Controls.Add(this.lblProtocol);
            this.Controls.Add(this.txtPrinterName);
            this.Controls.Add(this.lblPrinterName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrinterConfigDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Industrial Printer Configuration";
            this.grpConn.ResumeLayout(false);
            this.grpConn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPrinterName;
        private System.Windows.Forms.TextBox txtPrinterName;
        private System.Windows.Forms.Label lblProtocol;
        private System.Windows.Forms.ComboBox cmbProtocol;
        private System.Windows.Forms.GroupBox grpConn;
        private System.Windows.Forms.RadioButton rdoTcp;
        private System.Windows.Forms.RadioButton rdoSerial;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtTcpPort;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.Label lblDefaultJob;
        private System.Windows.Forms.TextBox txtDefaultJob;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}