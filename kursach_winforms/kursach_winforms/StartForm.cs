using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace kursach_winforms
{
    public partial class StartForm : Form
    {
        public string result=" ";
        public string path = @"file.txt";

        public StartForm()
        {
            InitializeComponent();
        }

        private void cpu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowInfoForm showInfoForm = new ShowInfoForm();
            showInfoForm.Show();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                string name = "Name: " + queryObj["Name"].ToString();
                string number = "Number Of Cores: " + queryObj["NumberOfCores"].ToString();
                string id = "Processor Id: " + queryObj["ProcessorId"].ToString();
                string address = "Address Width: " + queryObj["AddressWidth"].ToString();
                string architecture = "Architecture: " + queryObj["Architecture"].ToString();
                string assetTag = "Asset Tag: " + queryObj["AssetTag"].ToString();
                string characteristics = "Characteristics: " + queryObj["Characteristics"].ToString();
                string cpuStatus = "Cpu Status: " + queryObj["CpuStatus"].ToString();
                string creation = "Creation: " + queryObj["CreationClassName"].ToString();
                string currentVoltage = "Current Voltage: " + queryObj["CurrentVoltage"].ToString();
                string dataWidth = "Data Width: " + queryObj["DataWidth"].ToString();
                string deviceID = "DeviceID: " + queryObj["DeviceID"].ToString();

                string res = name + "\r\n" + number + "\r\n" + id + "\r\n" + address + "\r\n" +
                    architecture + "\r\n" + assetTag + "\r\n" + characteristics + "\r\n" + cpuStatus +
                    "\r\n" + creation + "\r\n" + currentVoltage + "\r\n" + dataWidth + "\r\n" + deviceID;

                result += "cpu" + "\r\n" + res + "\r\n";

                using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    writer.WriteLine(result);
                }

                showInfoForm.richTextBox.Text = res;
            }
        }

        private void hdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowInfoForm showInfoForm = new ShowInfoForm();
            showInfoForm.Show();

            string res = "";
            foreach (var drive in DriveInfo.GetDrives())
            {
                try
                {
                    string n = "Name: " + drive.Name;
                    string s = "File system: " + drive.DriveFormat;
                    string t = "Disk type: " + drive.DriveType;
                    string a = "Amount of available free space (in bytes): " + drive.AvailableFreeSpace;
                    string r = "Is the disk ready: " + drive.IsReady;
                    string d = "Disk root directory: " + drive.RootDirectory;
                    string f = "Total amount of free space available on the disk (in bytes): " + drive.TotalFreeSpace;
                    string ds = "Disk size (in bytes): " + drive.TotalSize;
                    string l = "Disk volume label: " + drive.VolumeLabel;

                    res += n + "\r\n" + s + "\r\n" + t + "\r\n" + a + "\r\n" + r + "\r\n" + d + "\r\n" +
                        f + "\r\n" + ds + "\r\n" + l + "\r\n" + "\r\n";
                }
                catch { }
            }
            result += "hdd" + "\r\n" + res + "\r\n";
            using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                writer.WriteLine(result);
            }
            showInfoForm.richTextBox.Text = res;
        }

        private void motherboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowInfoForm showInfoForm = new ShowInfoForm();
            showInfoForm.Show();

            string res = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(
          "SELECT Manufacturer,Product, SerialNumber,Version FROM Win32_BaseBoard");
            ManagementObjectCollection information = searcher.Get();
            foreach (ManagementObject obj in information)
            {
                foreach (PropertyData data in obj.Properties)
                {
                    string name = data.Name;
                    string value = data.Value.ToString();
                    res += name + "=" + value + "\r\n";
                }
            }
            result += "motherboard" + "\r\n" + res + "\r\n";
            using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                writer.WriteLine(result);
            }
            showInfoForm.richTextBox.Text = res;
        }

        private void Video_card_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowInfoForm showInfoForm = new ShowInfoForm();
            showInfoForm.Show();

            string res = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                string name = "AdapterRAM: " + queryObj["AdapterRAM"].ToString();
                string caption = "Caption: " + queryObj["Caption"].ToString();
                string description = "Description: " + queryObj["Description"].ToString();
                string videoProcessor = "VideoProcessor: " + queryObj["VideoProcessor"].ToString();
                string adc = "Adapter Compatibility: " + queryObj["AdapterCompatibility"].ToString();
                string adt = "Adapter DAC Type: " + queryObj["AdapterDACType"].ToString();
                string id = "DeviceID: " + queryObj["DeviceID"].ToString();
                string bits = "CurrentBitsPerPixel: " + queryObj["CurrentBitsPerPixel"].ToString();
                string dt = "Dither Type: " + queryObj["DitherType"].ToString();
                string idd = "Installed Display Drivers: " + queryObj["InstalledDisplayDrivers"].ToString();

                res += name + "\r\n" + caption + "\r\n" + description + "\r\n" + videoProcessor + "\r\n"
                    + adc + "\r\n" + adt + "\r\n" + bits + "\r\n" + id + "\r\n" + dt + 
                     "\r\n" + idd  + "\r\n" ;
            }
            result += "Video card" + "\r\n" + res + "\r\n";
            using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                writer.WriteLine(result);
            }
            showInfoForm.richTextBox.Text = res;
        }

        private void monitor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowInfoForm showInfoForm = new ShowInfoForm();
            showInfoForm.Show();

            string res = "";

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DesktopMonitor");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                string name = "Name: " + queryObj["SystemName"].ToString();
                string caption = "Caption: " + queryObj["Caption"].ToString();
                string id = "DeviceID: " + queryObj["DeviceID"].ToString();
                string pnp = "PNP DeviceID: " + queryObj["PNPDeviceID"].ToString();
                string pixx = "Pixels PerX Logical Inch: " + queryObj["PixelsPerXLogicalInch"].ToString();
                string pixy = "Pixels PerY Logical Inch: " + queryObj["PixelsPerYLogicalInch"].ToString();
                string sh = "System Creation: " + queryObj["SystemCreationClassName"].ToString();
                string sw = "Config Manager ErrorCode: " + queryObj["ConfigManagerErrorCode"].ToString();

                res += name + "\r\n" + caption + "\r\n" + id + "\r\n" + pnp + "\r\n" + pixx + 
                    "\r\n" + pixy + "\r\n" + sh + "\r\n" + sw + "\r\n";
            }
            result += "monitor" + "\r\n" + res + "\r\n";
            using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                writer.WriteLine(result);
            }
            showInfoForm.richTextBox.Text = res;
        }

        private void keyboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowInfoForm showInfoForm = new ShowInfoForm();
            showInfoForm.Show();

            string res = "";

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Keyboard");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                string caption = "Caption: " + queryObj["Caption"].ToString();
                string id = "DeviceID: " + queryObj["DeviceID"].ToString();
                string descr = "Description: " + queryObj["Description"].ToString();
                string layout = "Layout: " + queryObj["Layout"].ToString();
                string nof = "Number Of FunctionKeys: " + queryObj["NumberOfFunctionKeys"].ToString();
                string sccn = "SystemCreationClassName: " + queryObj["SystemCreationClassName"].ToString();
                string sn = "SystemName: " + queryObj["SystemName"].ToString();

                res += caption + "\r\n" + id + "\r\n" + descr + "\r\n" + layout +
                    "\r\n" + nof + "\r\n"  + sccn + "\r\n"+sn;
            }
            result += "keyboard" + "\r\n" + res + "\r\n";
            using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                writer.WriteLine(result);
            }
            showInfoForm.richTextBox.Text = res;
        }

        private void mouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowInfoForm showInfoForm = new ShowInfoForm();
            showInfoForm.Show();

            string res = "";

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PointingDevice");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                string id = "DeviceID: " + queryObj["DeviceID"].ToString();
                string di = "Device Interface: " + queryObj["DeviceInterface"].ToString();
                string ifn = "Inf FileName: " + queryObj["InfFileName"].ToString();
                string mf = "Manu facturer: " + queryObj["Manufacturer"].ToString();
                string sn = "SystemName: " + queryObj["SystemName"].ToString();
                string n = "Name: " + queryObj["Name"].ToString();
                string nob = "Number Of Buttons: " + queryObj["NumberOfButtons"].ToString();
                string pnp = "PNP DeviceID: " + queryObj["PNPDeviceID"].ToString();
                string pt = "Pointing Type: " + queryObj["PointingType"].ToString();
                string sr = "Status: " + queryObj["Status"].ToString();

                res += n + "\r\n" + id + "\r\n" + di + "\r\n" + ifn + "\r\n" + mf +
                    "\r\n" + sn + "\r\n" + nob + "\r\n" + pnp + "\r\n" + pt + "\r\n" + sr;
            }
            result += "mouse" + "\r\n" + res + "\r\n";
            using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                writer.WriteLine(result);
            }
            showInfoForm.richTextBox.Text = res;

        }

        private void bios_Click(object sender, EventArgs e)//, out string result)
        {
            this.Hide();
            ShowInfoForm showInfoForm = new ShowInfoForm();
            showInfoForm.Show();

            string res = "";

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                string m = "Manufacturer: " + queryObj["Manufacturer"].ToString();
                string cl = "Current Language: " + queryObj["CurrentLanguage"].ToString();
                string name =  queryObj["Name"].ToString();
                string il = "Installable Languages: " + queryObj["InstallableLanguages"].ToString();
                string rd = "Release Date: " + queryObj["ReleaseDate"].ToString();
                string n = "Serial Number: " + queryObj["SerialNumber"].ToString();
                string v = "SMBIOSBIOS Version: " + queryObj["SMBIOSBIOSVersion"].ToString();
                string mv = "SMBIOS Major Version: " + queryObj["SMBIOSMajorVersion"].ToString();
                string smv = "SMBIOS Minor Version: " + queryObj["SMBIOSMinorVersion"].ToString();
                string ei = "Status: " + queryObj["Status"].ToString();
                string ses = "Software Element State: " + queryObj["SoftwareElementState"].ToString();
                string vmj = "Bios Major Version: " + queryObj["SystemBiosMajorVersion"].ToString();
                string vmi = "Bios Minor Version: " + queryObj["SystemBiosMinorVersion"].ToString();
                string tos = "Target Operating System: " + queryObj["TargetOperatingSystem"].ToString();
                string vs = "Version: " + queryObj["Version"].ToString();

                res += name + "\r\n" + cl + "\r\n" + il + "\r\n" + rd +
                    "\r\n" + m + "\r\n" + n + "\r\n" + v + "\r\n" + mv+
                    "\r\n" + smv  + "\r\n" + ses + "\r\n" + ei + "\r\n" + vmj +
                    "\r\n" + vmi + "\r\n" + tos + "\r\n" + vs;
            }
            result = result +"bios" + "\r\n" + res + "\r\n";
            using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                writer.WriteLine(result);
            }
            showInfoForm.richTextBox.Text = res;
            //return result;
        }

        private void network_adapters_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowInfoForm showInfoForm = new ShowInfoForm();
            showInfoForm.Show();

            string res = "";

            
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_NetworkAdapter");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                string caption = "Caption: " + queryObj["Caption"].ToString();
                string desc = "Description: " + queryObj["Description"].ToString();
                string id = "DeviceID: " + queryObj["DeviceID"].ToString();

                res += caption + "\r\n" + desc + "\r\n" + id;
            }
            result += "network adapters" + "\r\n" + res + "\r\n";
            using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                writer.WriteLine(result);
            }
            showInfoForm.richTextBox.Text = res;
        }

        private void sound_card_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowInfoForm showInfoForm = new ShowInfoForm();
            showInfoForm.Show();

            string res = "";

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_SoundDevice");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                string caption = "Caption: " + queryObj["Caption"].ToString();
                string cm = "Config Manager Error Code: " + queryObj["ConfigManagerErrorCode"].ToString();
                string cn = "Creation Class Name: " + queryObj["CreationClassName"].ToString();
                string id = "DeviceID: " + queryObj["DeviceID"].ToString();
                string n = "Product Name: " + queryObj["ProductName"].ToString();
                string m = "Manufacturer: " + queryObj["Manufacturer"].ToString();
                string s = "Status: " + queryObj["Status"].ToString();
                string si = "StatusInfo: " + queryObj["StatusInfo"].ToString();

                res += caption + "\r\n" + cm + "\r\n" + cn + "\r\n" + id +
                    "\r\n" + n + "\r\n" + m + "\r\n" + s + "\r\n" + si;
            }
            result += "sound card" + "\r\n" + res + "\r\n";
            using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                writer.WriteLine(result);
            }
            showInfoForm.richTextBox.Text = res;
        }

        private void active_apps_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowInfoForm showInfoForm = new ShowInfoForm();
            showInfoForm.Show();

            string res = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2",
          "Select Name, CommandLine From Win32_Process");
            foreach (ManagementObject instance in searcher.Get())
            {
                res += instance["Name"] + "\r\n";
            }
            result += "active apps" + "\r\n" + res + "\r\n";
            using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                writer.WriteLine(result);
            }
            showInfoForm.richTextBox.Text = res;
        }

        private void info_Windows_Click(object   sender, EventArgs e)
        {
            this.Hide();
            ShowInfoForm showInfoForm = new ShowInfoForm();
            showInfoForm.Show();

            string res = "";

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                string caption = "Time: " + queryObj["LastBootUpTime"].ToString();

                res += caption + "\r\n";
            }
            result += "info Windows" + "\r\n" + res + "\r\n";
            using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                writer.WriteLine(result);
            }
            showInfoForm.richTextBox.Text = res;
        }

        private void to_file_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowInfoForm showInfoForm = new ShowInfoForm();
            showInfoForm.Show();

            // result += "inf";
            using (StreamReader reader = new StreamReader(path))
            {
                result = reader.ReadToEnd();
                //Console.WriteLine(text);
            }
            showInfoForm.richTextBox.Text = result;
        }
    }
}