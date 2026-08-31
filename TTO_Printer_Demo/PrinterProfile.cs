using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Text.Json;

namespace TTO_Printer_Demo
{
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
                if (!File.Exists(FilePath))
                {
                    var defaults = GetDefaultProfiles();
                    SavePrinters(defaults);
                    return defaults;
                }

                string json = File.ReadAllText(FilePath);
                var profiles = JsonSerializer.Deserialize<List<PrinterProfile>>(json);
                return profiles ?? GetDefaultProfiles();
            }
            catch
            {
                return GetDefaultProfiles();
            }
        }

        public static void SavePrinters(List<PrinterProfile> profiles)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(profiles, options);
            File.WriteAllText(FilePath, json);
        }

        private static List<PrinterProfile> GetDefaultProfiles()
        {
            return new List<PrinterProfile>
            {
                new PrinterProfile
                {
                    Name = "Packaging Line 1 - Linx",
                    Protocol = "Linx TT 500 (CLARiNET Protocol)",
                    IsTcp = true,
                    IpAddress = "192.168.1.101",
                    TcpPort = 3001,
                    ComPort = "COM1",
                    BaudRate = 9600,
                    DataBits = 8,
                    Parity = Parity.None,
                    StopBits = StopBits.One
                },
                new PrinterProfile
                {
                    Name = "Bottling Line - Dotsmark CIJ",
                    Protocol = "Dotsmark Systems (CIJ / TIJ / Laser / Dikai OEM)",
                    IsTcp = false,
                    ComPort = "COM3",
                    BaudRate = 115200,
                    DataBits = 8,
                    Parity = Parity.None,
                    StopBits = StopBits.One
                },
                new PrinterProfile
                {
                    Name = "Carton Line - Markem Imaje X40",
                    Protocol = "Markem-Imaje SmartDate X40 (TTO - NGP/CoLOS)",
                    IsTcp = true,
                    IpAddress = "192.168.1.150",
                    TcpPort = 2001,
                    BaudRate = 9600,
                    DataBits = 8,
                    Parity = Parity.None,
                    StopBits = StopBits.One
                }
            };
        }
    }
}