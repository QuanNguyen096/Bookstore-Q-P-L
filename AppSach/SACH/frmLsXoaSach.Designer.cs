namespace AppSach
{
    partial class frmLsXoaSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLsXoaSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSach = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvLsXoaSach = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoiPhuc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSach)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLsXoaSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picSach);
            this.panel1.Controls.Add(this.txtKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 250);
            this.panel1.TabIndex = 0;
            // 
            // picSach
            // 
            this.picSach.Image = ((System.Drawing.Image)(resources.GetObject("picSach.Image")));
            this.picSach.Location = new System.Drawing.Point(12, 5);
            this.picSach.Name = "picSach";
            this.picSach.ShadowDecoration.Parent = this.picSach;
            this.picSach.Size = new System.Drawing.Size(190, 240);
            this.picSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSach.TabIndex = 2;
            this.picSach.TabStop = false;
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey.AutoRoundedCorners = true;
            this.txtKey.BorderRadius = 23;
            this.txtKey.BorderThickness = 2;
            this.txtKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKey.DefaultText = "";
            this.txtKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKey.DisabledState.Parent = this.txtKey;
            this.txtKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey.FocusedState.Parent = this.txtKey;
            this.txtKey.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey.HoverState.Parent = this.txtKey;
            this.txtKey.Location = new System.Drawing.Point(467, 104);
            this.txtKey.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '\0';
            this.txtKey.PlaceholderText = "Tìm kiếm";
            this.txtKey.SelectedText = "";
            this.txtKey.ShadowDecoration.Parent = this.txtKey;
            this.txtKey.Size = new System.Drawing.Size(325, 49);
            this.txtKey.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvLsXoaSach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 236);
            this.panel2.TabIndex = 1;
            // 
            // dgvLsXoaSach
            // 
            this.dgvLsXoaSach.AllowUserToAddRows = false;
            this.dgvLsXoaSach.AllowUserToDeleteRows = false;
            this.dgvLsXoaSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLsXoaSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLsXoaSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTenSach,
            this.Column5,
            this.Column4,
            this.Column3,
            this.Column2,
            this.Column1,
            this.NgayNhap,
            this.colHoiPhuc});
            this.dgvLsXoaSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLsXoaSach.Location = new System.Drawing.Point(0, 0);
            this.dgvLsXoaSach.Name = "dgvLsXoaSach";
            this.dgvLsXoaSach.ReadOnly = true;
            this.dgvLsXoaSach.RowHeadersWidth = 51;
            this.dgvLsXoaSach.RowTemplate.Height = 24;
            this.dgvLsXoaSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLsXoaSach.Size = new System.Drawing.Size(1254, 236);
            this.dgvLsXoaSach.TabIndex = 0;
            this.dgvLsXoaSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLsXoaSach_CellClick);
            // 
            // colMaSach
            // 
            this.colMaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.HeaderText = "ID";
            this.colMaSach.MinimumWidth = 6;
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.ReadOnly = true;
            this.colMaSach.Width = 49;
            // 
            // colTenSach
            // 
            this.colTenSach.DataPropertyName = "TenSach";
            this.colTenSach.HeaderText = "Tên sách";
            this.colTenSach.MinimumWidth = 6;
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenTG";
            this.Column5.HeaderText = "Tên tác giả";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenLoai";
            this.Column4.HeaderText = "Tên loại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuong";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DonGia";
            this.Column2.HeaderText = "Đơn giá";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MoTa";
            this.Column1.HeaderText = "Mô tả";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // colHoiPhuc
            // 
            this.colHoiPhuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colHoiPhuc.HeaderText = "";
            this.colHoiPhuc.MinimumWidth = 6;
            this.colHoiPhuc.Name = "colHoiPhuc";
            this.colHoiPhuc.ReadOnly = true;
            this.colHoiPhuc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colHoiPhuc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colHoiPhuc.Text = "Lấy lại";
            this.colHoiPhuc.UseColumnTextForButtonValue = true;
            this.colHoiPhuc.Width = 23;
            // 
            // frmLsXoaSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLsXoaSach";
            this.Text = "LỊCH SỬ XÓA SP";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSach)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLsXoaSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtKey;
        private Guna.UI2.WinForms.Guna2PictureBox picSach;
        private System.Windows.Forms.DataGridView dgvLsXoaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewButtonColumn colHoiPhuc;
    }
}