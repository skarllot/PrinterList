﻿using System;
using System.Collections;
using System.Management;
using System.Windows.Forms;

namespace PrintingTest
{
    public partial class frmMain : Form
    {
        ManagementObject currentPrinter;

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
            btnDetails.Enabled = btnPrintTest.Enabled = cmbPrinterList.SelectedIndex != -1;
            txtPrinterProperties.Text = string.Empty;

            if (currentPrinter != null)
                currentPrinter.Dispose();

            string printerName = ((string)cmbPrinterList.SelectedItem).Replace(@"\", @"\\");
            string query = string.Format("SELECT * from Win32_Printer WHERE Name = \"{0}\"", printerName);
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection coll = searcher.Get();
            if (coll.Count != 1)
            {
                txtPrinterProperties.Text = "Erro ao obter objeto WMI";
                return;
            }

            IEnumerator prnenum = coll.GetEnumerator();
            prnenum.MoveNext();
            currentPrinter = (ManagementObject)prnenum.Current;
            searcher.Dispose();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            txtPrinterProperties.Text = string.Empty;

            foreach (PropertyData property in currentPrinter.Properties)
                txtPrinterProperties.Text += string.Format("{0}: {1}\r\n", property.Name, property.Value);
        }

        private void btnPrintTest_Click(object sender, EventArgs e)
        {
            uint ret = Convert.ToUInt32(currentPrinter.InvokeMethod("PrintTestPage", null));
            if (ret != 0)
                MessageBox.Show(this, "Erro ao imprimir página de teste.", "Impressão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(this, "Impressão enviada a impressora com sucesso.", "Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}