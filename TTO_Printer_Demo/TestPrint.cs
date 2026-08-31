using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTO_Printer_Demo
{
    public partial class TestPrint : Form
    {
        private List<PrinterProfile> _printers = new List<PrinterProfile>();

        public TestPrint()
        {
            InitializeComponent();
        }

        private void TestPrint_Load(object sender, EventArgs e)
        {
            // 1. Initialize Serial Options
            cmbComPort.Items.Clear();
            string[] availablePorts = SerialPort.GetPortNames();
            if (availablePorts.Length > 0)
            {
                cmbComPort.Items.AddRange(availablePorts);
                cmbComPort.SelectedIndex = 0;
            }

            cmbBaudRate.Items.AddRange(new object[] { 4800, 9600, 19200, 38400, 57600, 115200 });
            cmbBaudRate.SelectedItem = 9600;

            cmbDataBits.Items.AddRange(new object[] { 7, 8 });
            cmbDataBits.SelectedItem = 8;

            cmbParity.DataSource = Enum.GetValues(typeof(Parity));
            cmbParity.SelectedItem = Parity.None;

            cmbStopBits.DataSource = Enum.GetValues(typeof(StopBits));
            cmbStopBits.SelectedItem = StopBits.One;

            // 2. Load Printers from JSON
            RefreshPrinterProfiles();

            // 3. Dynamic Default Core Values
            txtBatchNo.Text = "B-" + DateTime.Now.ToString("MMyy-fff");
            dtpMfgDate.Value = DateTime.Now;
            dtpExpDate.Value = DateTime.Now.AddYears(1);

            // 4. Setup Dynamic Grid
            SetupDynamicGrid();
        }

        private void RefreshPrinterProfiles()
        {
            _printers = PrinterRepository.LoadPrinters();
            cmbPrinterType.DataSource = null;
            cmbPrinterType.DataSource = _printers;
            cmbPrinterType.DisplayMember = "Name";

            if (_printers.Count > 0)
            {
                cmbPrinterType.SelectedIndex = 0;
                ApplySelectedPrinterProfile(_printers[0]);
            }
        }

        private void cmbPrinterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPrinterType.SelectedItem is PrinterProfile selectedProfile)
            {
                ApplySelectedPrinterProfile(selectedProfile);
            }
        }

        private void ApplySelectedPrinterProfile(PrinterProfile p)
        {
            rdoTcp.Checked = p.IsTcp;
            rdoSerial.Checked = !p.IsTcp;
            txtIpAddress.Text = p.IpAddress;
            txtTcpPort.Text = p.TcpPort.ToString();

            if (cmbComPort.Items.Contains(p.ComPort)) cmbComPort.SelectedItem = p.ComPort;
            cmbBaudRate.SelectedItem = p.BaudRate;
            cmbDataBits.SelectedItem = p.DataBits;
            cmbParity.SelectedItem = p.Parity;
            cmbStopBits.SelectedItem = p.StopBits;

            if (!string.IsNullOrEmpty(p.DefaultJobName))
            {
                txtMessageName.Text = p.DefaultJobName;
            }

            ToggleConnectionUI();
        }

        private void btnAddPrinter_Click(object sender, EventArgs e)
        {
            using (var dialog = new PrinterConfigDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _printers.Add(dialog.SelectedProfile);
                    PrinterRepository.SavePrinters(_printers);
                    RefreshPrinterProfiles();
                    cmbPrinterType.SelectedItem = dialog.SelectedProfile;
                    Log($"[SYSTEM] Added new printer: {dialog.SelectedProfile.Name} ({dialog.SelectedProfile.Protocol})");
                }
            }
        }

        private void SetupDynamicGrid()
        {
            dgvCustomFields.Columns.Clear();

            DataGridViewTextBoxColumn colKey = new DataGridViewTextBoxColumn
            {
                Name = "colFieldName",
                HeaderText = "Field / Variable Name",
                Width = 160
            };

            DataGridViewTextBoxColumn colVal = new DataGridViewTextBoxColumn
            {
                Name = "colFieldValue",
                HeaderText = "Field Value",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            dgvCustomFields.Columns.Add(colKey);
            dgvCustomFields.Columns.Add(colVal);

            dgvCustomFields.Rows.Add("MRP", "Rs. 99.00");
            dgvCustomFields.Rows.Add("SHIFT", "A");
            dgvCustomFields.Rows.Add("LINE_NO", "L-01");
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            dgvCustomFields.Rows.Add("NEW_VAR", "VALUE");
        }

        private void btnRemoveField_Click(object sender, EventArgs e)
        {
            if (dgvCustomFields.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCustomFields.SelectedRows)
                {
                    if (!row.IsNewRow) dgvCustomFields.Rows.Remove(row);
                }
            }
            else if (dgvCustomFields.CurrentRow != null && !dgvCustomFields.CurrentRow.IsNewRow)
            {
                dgvCustomFields.Rows.Remove(dgvCustomFields.CurrentRow);
            }
        }

        private void rdoTcp_CheckedChanged(object sender, EventArgs e)
        {
            ToggleConnectionUI();
        }

        private void ToggleConnectionUI()
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

        private void Log(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Log(message)));
                return;
            }
            txtLog.AppendText($"[{DateTime.Now:HH:mm:ss.fff}] {message}{Environment.NewLine}");
        }

        private async void BtnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;

            try
            {
                var currentPrinter = cmbPrinterType.SelectedItem as PrinterProfile;
                string protocol = currentPrinter?.Protocol ?? "Linx TT 500 (CLARiNET Protocol)";
                string msgName = txtMessageName.Text.Trim();

                // 1. Default Core Variables
                var printVariables = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    { "BatchNo", txtBatchNo.Text.Trim() },
                    { "MFG", dtpMfgDate.Value.ToString("dd/MM/yyyy") },
                    { "EXP", dtpExpDate.Value.ToString("dd/MM/yyyy") }
                };

                // 2. Collect Dynamic Variables
                foreach (DataGridViewRow row in dgvCustomFields.Rows)
                {
                    if (row.IsNewRow) continue;
                    string key = row.Cells[0].Value?.ToString()?.Trim();
                    string val = row.Cells[1].Value?.ToString()?.Trim() ?? string.Empty;

                    if (!string.IsNullOrEmpty(key))
                    {
                        printVariables[key] = val;
                    }
                }

                // 3. Generate Payload
                string payload = GeneratePrinterPayload(protocol, msgName, printVariables);

                string printablePayload = payload
                    .Replace("\x02", "<STX>")
                    .Replace("\x03", "<ETX>")
                    .Replace("\x0D", "<CR>")
                    .Replace("\x0A", "<LF>");

                Log($"[PROTOCOL GENERATED] {printablePayload}");

                if (rdoTcp.Checked)
                {
                    await SendViaTcpAsync(payload);
                }
                else
                {
                    await SendViaSerialAsync(payload);
                }
            }
            catch (Exception ex)
            {
                Log($"[ERROR] {ex.Message}");
            }
            finally
            {
                btnSend.Enabled = true;
            }
        }

        private string GeneratePrinterPayload(string protocol, string msgName, Dictionary<string, string> variables)
        {
            if (protocol.IndexOf("Linx", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return BuildLinxClariNetCommand(msgName, variables);
            }
            else if (protocol.IndexOf("Dotsmark", StringComparison.OrdinalIgnoreCase) >= 0 || protocol.IndexOf("Dikai", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return BuildDotsmarkDikaiCommand(msgName, variables);
            }
            else if (protocol.IndexOf("Markem", StringComparison.OrdinalIgnoreCase) >= 0 || protocol.IndexOf("NGP", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return BuildMarkemImajeCommand(msgName, variables);
            }

            return BuildLinxClariNetCommand(msgName, variables);
        }

        private string BuildLinxClariNetCommand(string msgName, Dictionary<string, string> variables)
        {
            char STX = (char)0x02;
            char ETX = (char)0x03;
            char CR = (char)0x0D;

            StringBuilder sb = new StringBuilder();
            sb.Append($"{STX}JMD");
            foreach (var kvp in variables)
            {
                sb.Append($"|{kvp.Key}={kvp.Value}");
            }
            sb.Append($"{CR}{ETX}");
            return sb.ToString();
        }

        private string BuildDotsmarkDikaiCommand(string msgName, Dictionary<string, string> variables)
        {
            char STX = (char)0x02;
            char ETX = (char)0x03;

            StringBuilder sb = new StringBuilder();
            sb.Append($"{STX}SETVAR|NAME={msgName}");
            foreach (var kvp in variables)
            {
                sb.Append($"|{kvp.Key}={kvp.Value}");
            }
            sb.Append($"\r\n{ETX}");
            return sb.ToString();
        }

        private string BuildMarkemImajeCommand(string msgName, Dictionary<string, string> variables)
        {
            char STX = (char)0x02;
            char ETX = (char)0x03;
            char CR = (char)0x0D;

            StringBuilder sb = new StringBuilder();
            sb.Append(STX);
            foreach (var kvp in variables)
            {
                sb.Append($"!V|{kvp.Key}|{kvp.Value}{CR}");
            }
            sb.Append(ETX);
            return sb.ToString();
        }

        private async Task SendViaTcpAsync(string payload)
        {
            string ip = txtIpAddress.Text.Trim();
            if (!int.TryParse(txtTcpPort.Text.Trim(), out int port))
            {
                throw new Exception("Invalid TCP Port number.");
            }

            Log($"[TCP] Connecting to {ip}:{port}...");

            using (TcpClient client = new TcpClient())
            {
                Task connectTask = client.ConnectAsync(ip, port);
                if (await Task.WhenAny(connectTask, Task.Delay(3000)) != connectTask)
                {
                    throw new Exception("TCP Connection timed out. Ensure the target printer is online.");
                }

                using (NetworkStream stream = client.GetStream())
                {
                    byte[] data = Encoding.ASCII.GetBytes(payload);
                    await stream.WriteAsync(data, 0, data.Length);
                    await stream.FlushAsync();
                    Log("[TCP] Transmission successful.");
                }
            }
        }

        private async Task SendViaSerialAsync(string payload)
        {
            if (cmbComPort.SelectedItem == null)
            {
                throw new Exception("No COM Port selected.");
            }

            string portName = cmbComPort.SelectedItem.ToString();
            int baudRate = Convert.ToInt32(cmbBaudRate.SelectedItem);
            int dataBits = Convert.ToInt32(cmbDataBits.SelectedItem);
            Parity parity = (Parity)cmbParity.SelectedItem;
            StopBits stopBits = (StopBits)cmbStopBits.SelectedItem;

            Log($"[RS-232] Opening {portName} ({baudRate},{dataBits},{(int)parity},{(int)stopBits})...");

            using (SerialPort serialPort = new SerialPort(portName, baudRate, parity, dataBits, stopBits))
            {
                serialPort.WriteTimeout = 2500;
                serialPort.ReadTimeout = 2500;

                try
                {
                    serialPort.Open();
                }
                catch (UnauthorizedAccessException)
                {
                    throw new Exception($"Port {portName} is already locked by another software.");
                }

                byte[] buffer = Encoding.ASCII.GetBytes(payload);
                await Task.Run(() => serialPort.Write(buffer, 0, buffer.Length));

                Log("[RS-232] Transmission successful.");
            }
        }
    }
}