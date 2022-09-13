namespace AppSach.NhapKho
{
    partial class frmInPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInPhieuNhap));
            this.repPhieuNhap = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // repPhieuNhap
            // 
            this.repPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repPhieuNhap.LocalReport.ReportEmbeddedResource = "AppSach.NhapKho.ReportPhieuNhap.rdlc";
            this.repPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.repPhieuNhap.Name = "repPhieuNhap";
            this.repPhieuNhap.ServerReport.BearerToken = null;
            this.repPhieuNhap.Size = new System.Drawing.Size(915, 581);
            this.repPhieuNhap.TabIndex = 1;
            // 
            // frmInPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 581);
            this.Controls.Add(this.repPhieuNhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInPhieuNhap";
            this.Text = "IN PHIẾU NHẬP";
            this.Load += new System.EventHandler(this.frmInPhieuNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer repPhieuNhap;
    }
}