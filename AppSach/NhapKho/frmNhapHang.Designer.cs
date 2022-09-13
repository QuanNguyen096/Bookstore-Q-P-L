namespace AppSach
{
    partial class frmNhapHang
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTaoHDNhap = new Guna.UI2.WinForms.Guna2Button();
            this.txtKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.colDuyet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.guna2Panel1.Controls.Add(this.btnTaoHDNhap);
            this.guna2Panel1.Controls.Add(this.txtKey);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1321, 204);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnTaoHDNhap
            // 
            this.btnTaoHDNhap.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTaoHDNhap.BorderRadius = 18;
            this.btnTaoHDNhap.CheckedState.Parent = this.btnTaoHDNhap;
            this.btnTaoHDNhap.CustomImages.Parent = this.btnTaoHDNhap;
            this.btnTaoHDNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.btnTaoHDNhap.Font = new System.Drawing.Font("UTM Cookies", 9F);
            this.btnTaoHDNhap.ForeColor = System.Drawing.Color.White;
            this.btnTaoHDNhap.HoverState.Parent = this.btnTaoHDNhap;
            this.btnTaoHDNhap.Location = new System.Drawing.Point(1176, 141);
            this.btnTaoHDNhap.Name = "btnTaoHDNhap";
            this.btnTaoHDNhap.ShadowDecoration.Parent = this.btnTaoHDNhap;
            this.btnTaoHDNhap.Size = new System.Drawing.Size(133, 57);
            this.btnTaoHDNhap.TabIndex = 2;
            this.btnTaoHDNhap.Text = "Tạo phiếu nhập";
            this.btnTaoHDNhap.Click += new System.EventHandler(this.btnTaoHDNhap_Click);
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
            this.txtKey.Location = new System.Drawing.Point(461, 65);
            this.txtKey.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '\0';
            this.txtKey.PlaceholderText = "Tìm kiếm";
            this.txtKey.SelectedText = "";
            this.txtKey.ShadowDecoration.Parent = this.txtKey;
            this.txtKey.Size = new System.Drawing.Size(398, 49);
            this.txtKey.TabIndex = 1;
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDuyet,
            this.colMaPhieu,
            this.colTenNV,
            this.colThanhTien,
            this.colThue,
            this.colTienThue,
            this.colTongTien,
            this.colNgayTao,
            this.colTrangThai});
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(0, 204);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.RowHeadersWidth = 51;
            this.dgvPhieuNhap.RowTemplate.Height = 24;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(1321, 282);
            this.dgvPhieuNhap.TabIndex = 1;
            this.dgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellClick);
            this.dgvPhieuNhap.DoubleClick += new System.EventHandler(this.dgvPhieuNhap_DoubleClick);
            // 
            // colDuyet
            // 
            this.colDuyet.HeaderText = "";
            this.colDuyet.MinimumWidth = 6;
            this.colDuyet.Name = "colDuyet";
            this.colDuyet.ReadOnly = true;
            this.colDuyet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDuyet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDuyet.Text = "Duyệt Phiếu";
            this.colDuyet.UseColumnTextForButtonValue = true;
            // 
            // colMaPhieu
            // 
            this.colMaPhieu.DataPropertyName = "MaPhieu";
            this.colMaPhieu.HeaderText = "Mã Phiếu";
            this.colMaPhieu.MinimumWidth = 6;
            this.colMaPhieu.Name = "colMaPhieu";
            this.colMaPhieu.ReadOnly = true;
            // 
            // colTenNV
            // 
            this.colTenNV.DataPropertyName = "TenNV";
            this.colTenNV.HeaderText = "Tên NV";
            this.colTenNV.MinimumWidth = 6;
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // colThue
            // 
            this.colThue.DataPropertyName = "Thue";
            this.colThue.HeaderText = "Thuế";
            this.colThue.MinimumWidth = 6;
            this.colThue.Name = "colThue";
            this.colThue.ReadOnly = true;
            // 
            // colTienThue
            // 
            this.colTienThue.DataPropertyName = "TienThue";
            this.colTienThue.HeaderText = "Tiền Thuế";
            this.colTienThue.MinimumWidth = 6;
            this.colTienThue.Name = "colTienThue";
            this.colTienThue.ReadOnly = true;
            // 
            // colTongTien
            // 
            this.colTongTien.DataPropertyName = "TongTien";
            this.colTongTien.HeaderText = "Tổng Tiền";
            this.colTongTien.MinimumWidth = 6;
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            // 
            // colNgayTao
            // 
            this.colNgayTao.DataPropertyName = "ThoiGianTao";
            this.colNgayTao.HeaderText = "Ngày Tạo";
            this.colNgayTao.MinimumWidth = 6;
            this.colNgayTao.Name = "colNgayTao";
            this.colNgayTao.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai_a";
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // frmNhapHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1321, 486);
            this.Controls.Add(this.dgvPhieuNhap);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmNhapHang";
            this.Text = "NHẬP HÀNG";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtKey;
        private Guna.UI2.WinForms.Guna2Button btnTaoHDNhap;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.DataGridViewButtonColumn colDuyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}