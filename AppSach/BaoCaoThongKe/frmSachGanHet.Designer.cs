namespace AppSach.BaoCaoThongKe
{
    partial class frmSachGanHet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSachGanHet));
            this.repSachGanHet = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // repSachGanHet
            // 
            this.repSachGanHet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repSachGanHet.LocalReport.ReportEmbeddedResource = "AppSach.BaoCaoThongKe.ReportSachGanHet.rdlc";
            this.repSachGanHet.Location = new System.Drawing.Point(0, 0);
            this.repSachGanHet.Name = "repSachGanHet";
            this.repSachGanHet.ServerReport.BearerToken = null;
            this.repSachGanHet.Size = new System.Drawing.Size(1093, 564);
            this.repSachGanHet.TabIndex = 0;
            // 
            // frmSachGanHet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 564);
            this.Controls.Add(this.repSachGanHet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSachGanHet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SÁCH GẦN HẾT";
            this.Load += new System.EventHandler(this.frmSachGanHet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repSachGanHet;
    }
}