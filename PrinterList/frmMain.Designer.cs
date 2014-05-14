namespace PrinterList
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmbPrinterList = new System.Windows.Forms.ComboBox();
            this.txtPrinterProperties = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrintTest = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPrinterList
            // 
            resources.ApplyResources(this.cmbPrinterList, "cmbPrinterList");
            this.cmbPrinterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrinterList.FormattingEnabled = true;
            this.cmbPrinterList.Name = "cmbPrinterList";
            this.cmbPrinterList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPrinterProperties
            // 
            this.txtPrinterProperties.AcceptsReturn = true;
            resources.ApplyResources(this.txtPrinterProperties, "txtPrinterProperties");
            this.txtPrinterProperties.Name = "txtPrinterProperties";
            this.txtPrinterProperties.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.cmbPrinterList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrintTest, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDetails, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReload, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // btnPrintTest
            // 
            resources.ApplyResources(this.btnPrintTest, "btnPrintTest");
            this.btnPrintTest.Image = global::PrinterList.Properties.Resources.printer_run_16;
            this.btnPrintTest.Name = "btnPrintTest";
            this.toolTip1.SetToolTip(this.btnPrintTest, resources.GetString("btnPrintTest.ToolTip"));
            this.btnPrintTest.UseVisualStyleBackColor = true;
            this.btnPrintTest.Click += new System.EventHandler(this.btnPrintTest_Click);
            // 
            // btnDetails
            // 
            resources.ApplyResources(this.btnDetails, "btnDetails");
            this.btnDetails.Image = global::PrinterList.Properties.Resources.information_16;
            this.btnDetails.Name = "btnDetails";
            this.toolTip1.SetToolTip(this.btnDetails, resources.GetString("btnDetails.ToolTip"));
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnReload
            // 
            this.btnReload.Image = global::PrinterList.Properties.Resources.printer_add_16;
            resources.ApplyResources(this.btnReload, "btnReload");
            this.btnReload.Name = "btnReload";
            this.toolTip1.SetToolTip(this.btnReload, resources.GetString("btnReload.ToolTip"));
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtPrinterProperties);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPrinterList;
        private System.Windows.Forms.TextBox txtPrinterProperties;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnPrintTest;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

