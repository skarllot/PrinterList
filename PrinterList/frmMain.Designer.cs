namespace PrintingTest
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
            this.cmbPrinterList = new System.Windows.Forms.ComboBox();
            this.txtPrinterProperties = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnPrintTest = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPrinterList
            // 
            this.cmbPrinterList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPrinterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrinterList.FormattingEnabled = true;
            this.cmbPrinterList.Location = new System.Drawing.Point(3, 3);
            this.cmbPrinterList.Name = "cmbPrinterList";
            this.cmbPrinterList.Size = new System.Drawing.Size(189, 21);
            this.cmbPrinterList.TabIndex = 0;
            this.cmbPrinterList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPrinterProperties
            // 
            this.txtPrinterProperties.AcceptsReturn = true;
            this.txtPrinterProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrinterProperties.Location = new System.Drawing.Point(12, 46);
            this.txtPrinterProperties.Multiline = true;
            this.txtPrinterProperties.Name = "txtPrinterProperties";
            this.txtPrinterProperties.ReadOnly = true;
            this.txtPrinterProperties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPrinterProperties.Size = new System.Drawing.Size(355, 183);
            this.txtPrinterProperties.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.cmbPrinterList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDetails, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrintTest, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(355, 28);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnDetails
            // 
            this.btnDetails.Enabled = false;
            this.btnDetails.Location = new System.Drawing.Point(198, 3);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(74, 22);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "Detalhes";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnPrintTest
            // 
            this.btnPrintTest.Enabled = false;
            this.btnPrintTest.Location = new System.Drawing.Point(278, 3);
            this.btnPrintTest.Name = "btnPrintTest";
            this.btnPrintTest.Size = new System.Drawing.Size(74, 22);
            this.btnPrintTest.TabIndex = 2;
            this.btnPrintTest.Text = "Imprimir";
            this.btnPrintTest.UseVisualStyleBackColor = true;
            this.btnPrintTest.Click += new System.EventHandler(this.btnPrintTest_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 241);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtPrinterProperties);
            this.Name = "frmMain";
            this.Text = "Lista de Impressoras";
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
    }
}

