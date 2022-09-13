namespace AppSach
{
    partial class frmBaoCaoDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoDoanhThu));
            this.repDSHD = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // repDSHD
            // 
            this.repDSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repDSHD.LocalReport.ReportEmbeddedResource = "AppSach.DSHD.rdlc";
            this.repDSHD.Location = new System.Drawing.Point(0, 0);
            this.repDSHD.Name = "repDSHD";
            this.repDSHD.ServerReport.BearerToken = null;
            this.repDSHD.Size = new System.Drawing.Size(1081, 518);
            this.repDSHD.TabIndex = 0;
            // 
            // frmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 518);
            this.Controls.Add(this.repDSHD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaoCaoDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁO CÁO DOANH THU";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repDSHD;
    }
}