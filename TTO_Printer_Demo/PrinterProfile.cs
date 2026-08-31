using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Text.Json;

namespace TTO_Printer_Demo
{
    // --- EXISTING PRINTER PROFILE LOGIC (Preserved) ---
    public class PrinterProfile
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string Protocol { get; set; } = "Linx TT 500 (CLARiNET Protocol)";
        public bool IsTcp { get; set; } = true;
        public string IpAddress { get; set; } = "192.168.1.100";
        public int TcpPort { get; set; } = 3001;
        public string ComPort { get; set; } = "COM1";
        public int BaudRate { get; set; } = 9600;
        public int DataBits { get; set; } = 8;
        public Parity Parity { get; set; } = Parity.None;
        public StopBits StopBits { get; set; } = StopBits.One;
        public string DefaultJobName { get; set; } = "DEFAULT_JOB";

        public override string ToString() => $"{Name} ({Protocol})";
    }

    public static class PrinterRepository
    {
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "printers.json");

        public static List<PrinterProfile> LoadPrinters()
        {
            try
            {
                if (!File.Exists(FilePath)) return new List<PrinterProfile>();
                string json = File.ReadAllText(FilePath);
                var profiles = JsonSerializer.Deserialize<List<PrinterProfile>>(json);
                return profiles ?? new List<PrinterProfile>();
            }
            catch { return new List<PrinterProfile>(); }
        }

        public static void SavePrinters(List<PrinterProfile> profiles)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(profiles, options);
            File.WriteAllText(FilePath, json);
        }
    }

    // --- NEW PROTOCOL LOGIC ---
    public class PrinterProtocol
    {
        public string Name { get; set; } = string.Empty;
        public string PrefixHex { get; set; } = string.Empty;
        public string CommandPrefix { get; set; } = string.Empty;
        public string VariableTemplate { get; set; } = string.Empty;
        public string SuffixHex { get; set; } = string.Empty;
    }

    public static class ProtocolRepository
    {
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "protocols.json");

        public static List<PrinterProtocol> LoadProtocols()
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    var defaults = GetDefaultProtocols();
                    SaveProtocols(defaults);
                    return defaults;
                }

                string json = File.ReadAllText(FilePath);
                var protocols = JsonSerializer.Deserialize<List<PrinterProtocol>>(json);
                return protocols ?? GetDefaultProtocols();
            }
            catch
            {
                return GetDefaultProtocols();
            }
        }

        public static void SaveProtocols(List<PrinterProtocol> protocols)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(protocols, options);
            File.WriteAllText(FilePath, json);
        }

        private static List<PrinterProtocol> GetDefaultProtocols()
        {
            // Requirement 3: Save default 3 protocols
            return new List<PrinterProtocol>
            {
                new PrinterProtocol
                {
                    Name = "Linx TT 500 (CLARiNET Protocol)",
                    PrefixHex = "02",
                    CommandPrefix = "JMD",
                    VariableTemplate = "|{KEY}={VALUE}",
                    SuffixHex = "0D 03"
                },
                new PrinterProtocol
                {
                    Name = "Dotsmark Systems (CIJ / TIJ / Laser / Dikai OEM)",
                    PrefixHex = "02",
                    CommandPrefix = "SETVAR|NAME={MSG_NAME}",
                    VariableTemplate = "|{KEY}={VALUE}",
                    SuffixHex = "0D 0A 03"
                },
                new PrinterProtocol
                {
                    Name = "Markem-Imaje SmartDate X40 (TTO - NGP/CoLOS)",
                    PrefixHex = "02",
                    CommandPrefix = "", // Markem puts variables right after STX usually
                    VariableTemplate = "!V|{KEY}|{VALUE}<CR>",
                    SuffixHex = "03"
                }
            };
        }
    }
}