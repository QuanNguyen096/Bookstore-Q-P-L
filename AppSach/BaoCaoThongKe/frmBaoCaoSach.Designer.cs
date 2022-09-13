namespace AppSach.BaoCaoThongKe
{
    partial class frmBaoCaoSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoSach));
            this.repSachBanChay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // repSachBanChay
            // 
            this.repSachBanChay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repSachBanChay.LocalReport.ReportEmbeddedResource = "AppSach.BaoCaoThongKe.ReportSachBanChay.rdlc";
            this.repSachBanChay.Location = new System.Drawing.Point(0, 0);
            this.repSachBanChay.Name = "repSachBanChay";
            this.repSachBanChay.ServerReport.BearerToken = null;
            this.repSachBanChay.Size = new System.Drawing.Size(1087, 581);
            this.repSachBanChay.TabIndex = 0;
            // 
            // frmBaoCaoSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 581);
            this.Controls.Add(this.repSachBanChay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaoCaoSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SÁCH BÁN CHẠY NHẤT";
            this.Load += new System.EventHandler(this.frmBaoCaoSach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repSachBanChay;
    }
}