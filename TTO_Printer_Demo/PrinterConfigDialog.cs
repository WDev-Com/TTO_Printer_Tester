using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace TTO_Printer_Demo
{
    public partial class PrinterConfigDialog : Form
    {
        public PrinterProfile SelectedProfile { get; private set; }

        public PrinterConfigDialog(PrinterProfile profileToEdit = null)
        {
            InitializeComponent();
            InitializeDropdowns();

            if (profileToEdit != null)
            {
                SelectedProfile = profileToEdit;
                LoadProfileToUI(profileToEdit);
            }
            else
            {
                SelectedProfile = new PrinterProfile();
                txtPrinterName.Text = "New Industrial Printer";
            }
        }

        private void InitializeDropdowns()
        {
            cmbProtocol.Items.AddRange(new string[] {
                "Linx TT 500 (CLARiNET Protocol)",
                "Dotsmark Systems (CIJ / TIJ / Laser / Dikai OEM)",
                "Markem-Imaje SmartDate X40 (TTO - NGP/CoLOS)"
            });
            cmbProtocol.SelectedIndex = 0;

            cmbComPort.Items.AddRange(SerialPort.GetPortNames());
            if (cmbComPort.Items.Count > 0) cmbComPort.SelectedIndex = 0;
            else cmbComPort.Items.Add("COM1");

            cmbBaudRate.Items.AddRange(new object[] { 4800, 9600, 19200, 38400, 57600, 115200 });
            cmbBaudRate.SelectedItem = 9600;

            cmbDataBits.Items.AddRange(new object[] { 7, 8 });
            cmbDataBits.SelectedItem = 8;

            cmbParity.DataSource = Enum.GetValues(typeof(Parity));
            cmbParity.SelectedItem = Parity.None;

            cmbStopBits.DataSource = Enum.GetValues(typeof(StopBits));
            cmbStopBits.SelectedItem = StopBits.One;

            ToggleInterface();
        }

        private void LoadProfileToUI(PrinterProfile p)
        {
            txtPrinterName.Text = p.Name;
            cmbProtocol.SelectedItem = p.Protocol;
            rdoTcp.Checked = p.IsTcp;
            rdoSerial.Checked = !p.IsTcp;
            txtIpAddress.Text = p.IpAddress;
            txtTcpPort.Text = p.TcpPort.ToString();

            if (cmbComPort.Items.Contains(p.ComPort)) cmbComPort.SelectedItem = p.ComPort;
            cmbBaudRate.SelectedItem = p.BaudRate;
            cmbDataBits.SelectedItem = p.DataBits;
            cmbParity.SelectedItem = p.Parity;
            cmbStopBits.SelectedItem = p.StopBits;
            txtDefaultJob.Text = p.DefaultJobName;

            ToggleInterface();
        }

        private void rdoTcp_CheckedChanged(object sender, EventArgs e)
        {
            ToggleInterface();
        }

        private void ToggleInterface()
        {
            bool isTcp = rdoTcp.Checked;
            txtIpAddress.Enabled = isTcp;
            txtTcpPort.Enabled = isTcp;

            cmbComPort.Enabled = !isTcp;
            cmbBaudRate.Enabled = !isTcp;
            cmbDataBits.Enabled = !isTcp;
            cmbParity.Enabled = !isTcp;
            cmbStopBits.Enabled = !isTcp;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrinterName.Text))
            {
                MessageBox.Show("Please specify a valid printer name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rdoTcp.Checked && (!int.TryParse(txtTcpPort.Text, out int port) || port <= 0))
            {
                MessageBox.Show("Please specify a valid TCP Port.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SelectedProfile.Name = txtPrinterName.Text.Trim();
            SelectedProfile.Protocol = cmbProtocol.SelectedItem?.ToString() ?? "Linx TT 500 (CLARiNET Protocol)";
            SelectedProfile.IsTcp = rdoTcp.Checked;
            SelectedProfile.IpAddress = txtIpAddress.Text.Trim();
            SelectedProfile.TcpPort = int.TryParse(txtTcpPort.Text, out int parsedPort) ? parsedPort : 3001;
            SelectedProfile.ComPort = cmbComPort.SelectedItem?.ToString() ?? "COM1";
            SelectedProfile.BaudRate = Convert.ToInt32(cmbBaudRate.SelectedItem ?? 9600);
            SelectedProfile.DataBits = Convert.ToInt32(cmbDataBits.SelectedItem ?? 8);
            SelectedProfile.Parity = (Parity)(cmbParity.SelectedItem ?? Parity.None);
            SelectedProfile.StopBits = (StopBits)(cmbStopBits.SelectedItem ?? StopBits.One);
            SelectedProfile.DefaultJobName = txtDefaultJob.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}