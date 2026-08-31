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
        private List<PrinterProtocol> _protocols = new List<PrinterProtocol>();

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

            // 2. Load Printers & Protocols
            RefreshPrinterProfiles();
            LoadProtocolsToGrid();

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

        // --- PRINTER MANAGEMENT ---
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
                }
            }
        }

        private void btnEditPrinter_Click(object sender, EventArgs e)
        {
            if (cmbPrinterType.SelectedItem is PrinterProfile selectedProfile)
            {
                using (var dialog = new PrinterConfigDialog(selectedProfile))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        PrinterRepository.SavePrinters(_printers);
                        RefreshPrinterProfiles();

                        int index = _printers.FindIndex(p => p.Id == selectedProfile.Id);
                        if (index >= 0) cmbPrinterType.SelectedIndex = index;
                    }
                }
            }
        }

        private void btnDeletePrinter_Click(object sender, EventArgs e)
        {
            if (cmbPrinterType.SelectedItem is PrinterProfile selectedProfile)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete '{selectedProfile.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _printers.Remove(selectedProfile);
                    PrinterRepository.SavePrinters(_printers);
                    RefreshPrinterProfiles();
                }
            }
        }

        // --- PROTOCOL MANAGEMENT (NEW: UPDATE AND DELETE OPERATIONS) ---
        private void LoadProtocolsToGrid()
        {
            _protocols = ProtocolRepository.LoadProtocols();

            dgvProtocols.Columns.Clear();
            dgvProtocols.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Protocol Name", Width = 220 });
            dgvProtocols.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPrefix", HeaderText = "Prefix (Hex)", Width = 90 });
            dgvProtocols.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCmd", HeaderText = "Command Prefix", Width = 150 });
            dgvProtocols.Columns.Add(new DataGridViewTextBoxColumn { Name = "colVarTemp", HeaderText = "Variable Template", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvProtocols.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSuffix", HeaderText = "Suffix (Hex)", Width = 90 });

            foreach (var p in _protocols)
            {
                dgvProtocols.Rows.Add(p.Name, p.PrefixHex, p.CommandPrefix, p.VariableTemplate, p.SuffixHex);
            }
        }

        private void btnSaveProtocols_Click(object sender, EventArgs e)
        {
            // Acts as Create/Update based on grid edits
            var updatedList = new List<PrinterProtocol>();
            foreach (DataGridViewRow row in dgvProtocols.Rows)
            {
                if (row.IsNewRow) continue;

                updatedList.Add(new PrinterProtocol
                {
                    Name = row.Cells[0].Value?.ToString()?.Trim() ?? "Unnamed Protocol",
                    PrefixHex = row.Cells[1].Value?.ToString()?.Trim() ?? "",
                    CommandPrefix = row.Cells[2].Value?.ToString()?.Trim() ?? "",
                    VariableTemplate = row.Cells[3].Value?.ToString()?.Trim() ?? "",
                    SuffixHex = row.Cells[4].Value?.ToString()?.Trim() ?? ""
                });
            }

            _protocols = updatedList;
            ProtocolRepository.SaveProtocols(_protocols);
            MessageBox.Show("Protocols saved! Changes will take effect immediately.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteProtocol_Click(object sender, EventArgs e)
        {
            // Requirement 2: Delete Protocol Operation
            if (dgvProtocols.SelectedRows.Count > 0 && !dgvProtocols.SelectedRows[0].IsNewRow)
            {
                dgvProtocols.Rows.Remove(dgvProtocols.SelectedRows[0]);
            }
            else if (dgvProtocols.CurrentRow != null && !dgvProtocols.CurrentRow.IsNewRow)
            {
                dgvProtocols.Rows.Remove(dgvProtocols.CurrentRow);
            }
        }

        // --- DYNAMIC FIELDS & UI ---
        private void SetupDynamicGrid()
        {
            dgvCustomFields.Columns.Clear();
            dgvCustomFields.Columns.Add(new DataGridViewTextBoxColumn { Name = "colFieldName", HeaderText = "Field Name", Width = 160 });
            dgvCustomFields.Columns.Add(new DataGridViewTextBoxColumn { Name = "colFieldValue", HeaderText = "Field Value", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

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
                if (currentPrinter == null) throw new Exception("No printer profile selected.");

                string protocolName = currentPrinter.Protocol;
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

                // 3. DYNAMIC Payload Generation
                string payload = GenerateDynamicPayload(protocolName, msgName, printVariables);

                // For logging display
                string printablePayload = payload
                    .Replace("\x02", "<STX>")
                    .Replace("\x03", "<ETX>")
                    .Replace("\x0D", "<CR>")
                    .Replace("\x0A", "<LF>");

                Log($"[PAYLOAD BUILT] {printablePayload}");

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

        // --- NEW: DYNAMIC PROTOCOL ENGINE ---
        private string GenerateDynamicPayload(string protocolName, string msgName, Dictionary<string, string> variables)
        {
            var protocol = _protocols.FirstOrDefault(p => p.Name.Equals(protocolName, StringComparison.OrdinalIgnoreCase));

            if (protocol == null)
                throw new Exception($"Protocol logic for '{protocolName}' not found. Please add it in the Protocols tab.");

            StringBuilder sb = new StringBuilder();

            // 1. Prefix
            sb.Append(HexToString(protocol.PrefixHex));

            // 2. Command Body Prefix
            string cmdPrefix = (protocol.CommandPrefix ?? "").Replace("{MSG_NAME}", msgName);
            cmdPrefix = cmdPrefix.Replace("<CR>", "\x0D").Replace("<LF>", "\x0A");
            sb.Append(cmdPrefix);

            // 3. Variables
            foreach (var kvp in variables)
            {
                string varBlock = (protocol.VariableTemplate ?? "")
                    .Replace("{KEY}", kvp.Key)
                    .Replace("{VALUE}", kvp.Value)
                    .Replace("<CR>", "\x0D")
                    .Replace("<LF>", "\x0A");

                sb.Append(varBlock);
            }

            // 4. Suffix
            sb.Append(HexToString(protocol.SuffixHex));

            return sb.ToString();
        }

        private string HexToString(string hex)
        {
            if (string.IsNullOrWhiteSpace(hex)) return string.Empty;

            hex = hex.Replace(" ", ""); // Remove spaces (e.g. "0D 0A" -> "0D0A")
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return Encoding.ASCII.GetString(bytes);
        }

        // --- COMMUNICATION INTERFACES ---
        private async Task SendViaTcpAsync(string payload)
        {
            string ip = txtIpAddress.Text.Trim();
            if (!int.TryParse(txtTcpPort.Text.Trim(), out int port))
                throw new Exception("Invalid TCP Port number.");

            Log($"[TCP] Connecting to {ip}:{port}...");

            using (TcpClient client = new TcpClient())
            {
                Task connectTask = client.ConnectAsync(ip, port);
                if (await Task.WhenAny(connectTask, Task.Delay(3000)) != connectTask)
                {
                    throw new Exception("TCP Connection timed out. Ensure target is online.");
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
                throw new Exception("No COM Port selected.");

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