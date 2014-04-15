using System;
using System.Management;
using System.Windows.Forms;

namespace PrintingTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string item in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cmbPrinterList.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPrinterList.SelectedIndex != -1)
            {
                string query = string.Format("SELECT * from Win32_Printer WHERE Name = \"{0}\"",
                    ((string)cmbPrinterList.SelectedItem).Replace(@"\", @"\\"));
                //query = "SELECT * from Win32_Printer";
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
                ManagementObjectCollection coll = searcher.Get();

                txtPrinterProperties.Text = string.Empty;
                foreach (ManagementObject printer in coll)
                {
                    foreach (PropertyData property in printer.Properties)
                        txtPrinterProperties.Text += string.Format("{0}: {1}\r\n", property.Name, property.Value);
                }
            }
        }
    }
}
