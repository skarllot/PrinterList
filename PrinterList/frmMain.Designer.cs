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
            this.SuspendLayout();
            // 
            // cmbPrinterList
            // 
            this.cmbPrinterList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPrinterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrinterList.FormattingEnabled = true;
            this.cmbPrinterList.Location = new System.Drawing.Point(12, 12);
            this.cmbPrinterList.Name = "cmbPrinterList";
            this.cmbPrinterList.Size = new System.Drawing.Size(355, 21);
            this.cmbPrinterList.TabIndex = 0;
            this.cmbPrinterList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPrinterProperties
            // 
            this.txtPrinterProperties.AcceptsReturn = true;
            this.txtPrinterProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrinterProperties.Location = new System.Drawing.Point(12, 39);
            this.txtPrinterProperties.Multiline = true;
            this.txtPrinterProperties.Name = "txtPrinterProperties";
            this.txtPrinterProperties.ReadOnly = true;
            this.txtPrinterProperties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPrinterProperties.Size = new System.Drawing.Size(355, 190);
            this.txtPrinterProperties.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 241);
            this.Controls.Add(this.txtPrinterProperties);
            this.Controls.Add(this.cmbPrinterList);
            this.Name = "frmMain";
            this.Text = "Lista de Impressoras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPrinterList;
        private System.Windows.Forms.TextBox txtPrinterProperties;
    }
}

