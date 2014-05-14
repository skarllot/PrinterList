// frmMain.cs
//
// Copyright (C) 2014 Fabrício Godoy
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using System.Collections;
using System.Management;
using System.Windows.Forms;

namespace PrinterList
{
    public partial class frmMain : Form
    {
        ManagementObject currentPrinter;
        System.Drawing.Printing.PrinterSettings.StringCollection printerList;
        float CELL_BUTTON_WIDTH = 30f;
        const string WMI_GET_PRINTER_DETAILS = "SELECT * from Win32_Printer WHERE Name = \"{0}\"";
        const string WMI_METHOD_PRINT_TEST_PAGE = "PrintTestPage";

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangePrinterButtonsVisibility(false);
            printerList = System.Drawing.Printing.PrinterSettings.InstalledPrinters;
            LoadList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isSel = cmbPrinterList.SelectedIndex != -1;
            btnDetails.Enabled = btnPrintTest.Enabled = isSel;
            ChangePrinterButtonsVisibility(isSel);

            txtPrinterProperties.Text = string.Empty;

            if (currentPrinter != null)
            {
                currentPrinter.Dispose();
                currentPrinter = null;
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            LazyLoadWmi();
            txtPrinterProperties.Text = string.Empty;

            foreach (PropertyData property in currentPrinter.Properties)
                txtPrinterProperties.Text += string.Format("{0}: {1}\r\n", property.Name, property.Value);
        }

        private void btnPrintTest_Click(object sender, EventArgs e)
        {
            LazyLoadWmi();

            uint ret = Convert.ToUInt32(currentPrinter.InvokeMethod(WMI_METHOD_PRINT_TEST_PAGE, null));
            if (ret != 0)
                MessageBox.Show(this, resMessages.PrintTest_Fail, resMessages.PrintTest_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(this, resMessages.PrintTest_Success, resMessages.PrintTest_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LazyLoadWmi()
        {
            if (currentPrinter != null)
                return;

            txtPrinterProperties.Text = resMessages.WmiGetPrinter_Loading;

            string printerName = ((string)cmbPrinterList.SelectedItem).Replace(@"\", @"\\");
            string query = string.Format(WMI_GET_PRINTER_DETAILS, printerName);
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection coll = searcher.Get();
            if (coll.Count != 1)
            {
                txtPrinterProperties.Text = resMessages.WmiGetPrinter_Error;
                return;
            }

            IEnumerator prnenum = coll.GetEnumerator();
            prnenum.MoveNext();
            currentPrinter = (ManagementObject)prnenum.Current;
            searcher.Dispose();

            txtPrinterProperties.Text = string.Empty;
        }

        private void LoadList()
        {
            cmbPrinterList.SelectedIndex = -1;
            cmbPrinterList.Items.Clear();

            if (currentPrinter != null)
            {
                currentPrinter.Dispose();
                currentPrinter = null;
            }

            foreach (string item in printerList)
                cmbPrinterList.Items.Add(item);

            btnReload.Enabled = false;
            ChangeReloadButtonVisibility(false);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            printerList = System.Drawing.Printing.PrinterSettings.InstalledPrinters;

            if (printerList.Count != cmbPrinterList.Items.Count)
            {
                btnReload.Enabled = true;
                ChangeReloadButtonVisibility(true);
                timer1.Enabled = false;
            }
        }

        private void ChangeReloadButtonVisibility(bool visible)
        {
            if (visible)
                tableLayoutPanel1.ColumnStyles[1].Width = CELL_BUTTON_WIDTH;
            else
                tableLayoutPanel1.ColumnStyles[1].Width = 0f;
        }

        private void ChangePrinterButtonsVisibility(bool visible)
        {
            if (visible)
                tableLayoutPanel1.ColumnStyles[2].Width =
                    tableLayoutPanel1.ColumnStyles[3].Width =
                    CELL_BUTTON_WIDTH;
            else
                tableLayoutPanel1.ColumnStyles[2].Width =
                    tableLayoutPanel1.ColumnStyles[3].Width = 0f;
        }
    }
}
