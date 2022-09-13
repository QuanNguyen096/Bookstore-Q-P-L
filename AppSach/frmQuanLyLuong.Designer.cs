namespace AppSach
{
    partial class frmQuanLyLuong
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
            this._TabControl = new System.Windows.Forms.TabControl();
            this.tabNgay = new System.Windows.Forms.TabPage();
            this.tabTuan = new System.Windows.Forms.TabPage();
            this.tabThang = new System.Windows.Forms.TabPage();
            this.tabNam = new System.Windows.Forms.TabPage();
            this.dgvLuongNgay = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.txtKeyNgay = new Guna.UI2.WinForms.Guna2TextBox();
            this._TabControl.SuspendLayout();
            this.tabNgay.SuspendLayout();
            this.tabTuan.SuspendLayout();
            this.tabThang.SuspendLayout();
            this.tabNam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // _TabControl
            // 
            this._TabControl.Controls.Add(this.tabNgay);
            this._TabControl.Controls.Add(this.tabTuan);
            this._TabControl.Controls.Add(this.tabThang);
            this._TabControl.Controls.Add(this.tabNam);
            this._TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TabControl.Location = new System.Drawing.Point(12, 30);
            this._TabControl.Name = "_TabControl";
            this._TabControl.SelectedIndex = 0;
            this._TabControl.Size = new System.Drawing.Size(1371, 408);
            this._TabControl.TabIndex = 0;
            // 
            // tabNgay
            // 
            this.tabNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.tabNgay.Controls.Add(this.txtKeyNgay);
            this.tabNgay.Controls.Add(this.dgvLuongNgay);
            this.tabNgay.Location = new System.Drawing.Point(4, 34);
            this.tabNgay.Name = "tabNgay";
            this.tabNgay.Padding = new System.Windows.Forms.Padding(3);
            this.tabNgay.Size = new System.Drawing.Size(1363, 370);
            this.tabNgay.TabIndex = 0;
            this.tabNgay.Text = "Ngày";
            // 
            // tabTuan
            // 
            this.tabTuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.tabTuan.Controls.Add(this.dataGridView2);
            this.tabTuan.Location = new System.Drawing.Point(4, 34);
            this.tabTuan.Name = "tabTuan";
            this.tabTuan.Padding = new System.Windows.Forms.Padding(3);
            this.tabTuan.Size = new System.Drawing.Size(1387, 412);
            this.tabTuan.TabIndex = 1;
            this.tabTuan.Text = "Tuần";
            // 
            // tabThang
            // 
            this.tabThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.tabThang.Controls.Add(this.dataGridView3);
            this.tabThang.Location = new System.Drawing.Point(4, 34);
            this.tabThang.Name = "tabThang";
            this.tabThang.Size = new System.Drawing.Size(1387, 412);
            this.tabThang.TabIndex = 2;
            this.tabThang.Text = "Tháng";
            // 
            // tabNam
            // 
            this.tabNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.tabNam.Controls.Add(this.dataGridView4);
            this.tabNam.Location = new System.Drawing.Point(4, 34);
            this.tabNam.Name = "tabNam";
            this.tabNam.Size = new System.Drawing.Size(1387, 412);
            this.tabNam.TabIndex = 3;
            this.tabNam.Text = "Năm";
            // 
            // dgvLuongNgay
            // 
            this.dgvLuongNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuongNgay.Location = new System.Drawing.Point(6, 77);
            this.dgvLuongNgay.Name = "dgvLuongNgay";
            this.dgvLuongNgay.RowHeadersWidth = 51;
            this.dgvLuongNgay.RowTemplate.Height = 24;
            this.dgvLuongNgay.Size = new System.Drawing.Size(1351, 287);
            this.dgvLuongNgay.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 87);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1373, 317);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 87);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1373, 317);
            this.dataGridView3.TabIndex = 1;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 87);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(1373, 317);
            this.dataGridView4.TabIndex = 1;
            // 
            // txtKeyNgay
            // 
            this.txtKeyNgay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKeyNgay.DefaultText = "";
            this.txtKeyNgay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKeyNgay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKeyNgay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKeyNgay.DisabledState.Parent = this.txtKeyNgay;
            this.txtKeyNgay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKeyNgay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKeyNgay.FocusedState.Parent = this.txtKeyNgay;
            this.txtKeyNgay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKeyNgay.HoverState.Parent = this.txtKeyNgay;
            this.txtKeyNgay.Location = new System.Drawing.Point(363, 24);
            this.txtKeyNgay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtKeyNgay.Name = "txtKeyNgay";
            this.txtKeyNgay.PasswordChar = '\0';
            this.txtKeyNgay.PlaceholderText = "";
            this.txtKeyNgay.SelectedText = "";
            this.txtKeyNgay.ShadowDecoration.Parent = this.txtKeyNgay;
            this.txtKeyNgay.Size = new System.Drawing.Size(648, 44);
            this.txtKeyNgay.TabIndex = 1;
            // 
            // frmQuanLyLuong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1395, 450);
            this.Controls.Add(this._TabControl);
            this.Name = "frmQuanLyLuong";
            this.Text = "frmQuanLyLuong";
            this.Load += new System.EventHandler(this.frmQuanLyLuong_Load);
            this._TabControl.ResumeLayout(false);
            this.tabNgay.ResumeLayout(false);
            this.tabTuan.ResumeLayout(false);
            this.tabThang.ResumeLayout(false);
            this.tabNam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _TabControl;
        private System.Windows.Forms.TabPage tabNgay;
        private System.Windows.Forms.TabPage tabTuan;
        private System.Windows.Forms.TabPage tabThang;
        private System.Windows.Forms.TabPage tabNam;
        private System.Windows.Forms.DataGridView dgvLuongNgay;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private Guna.UI2.WinForms.Guna2TextBox txtKeyNgay;
    }
}