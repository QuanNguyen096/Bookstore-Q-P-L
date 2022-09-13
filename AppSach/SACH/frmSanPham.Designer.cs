namespace AppSach
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemSP = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnInDSSach = new Guna.UI2.WinForms.Guna2ImageButton();
            this.barcode = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnGift = new Guna.UI2.WinForms.Guna2ImageButton();
            this.picSach = new FontAwesome.Sharp.IconPictureBox();
            this.txtKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSach)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemSP);
            this.panel1.Controls.Add(this.btnInDSSach);
            this.panel1.Controls.Add(this.barcode);
            this.panel1.Controls.Add(this.btnGift);
            this.panel1.Controls.Add(this.picSach);
            this.panel1.Controls.Add(this.txtKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 250);
            this.panel1.TabIndex = 0;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThemSP.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThemSP.CheckedState.Parent = this.btnThemSP;
            this.btnThemSP.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThemSP.HoverState.Parent = this.btnThemSP;
            this.btnThemSP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSP.Image")));
            this.btnThemSP.ImageRotate = 0F;
            this.btnThemSP.Location = new System.Drawing.Point(1187, 193);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.PressedState.ImageSize = new System.Drawing.Size(70, 70);
            this.btnThemSP.PressedState.Parent = this.btnThemSP;
            this.btnThemSP.Size = new System.Drawing.Size(64, 54);
            this.btnThemSP.TabIndex = 13;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnInDSSach
            // 
            this.btnInDSSach.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInDSSach.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnInDSSach.CheckedState.Parent = this.btnInDSSach;
            this.btnInDSSach.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnInDSSach.HoverState.Parent = this.btnInDSSach;
            this.btnInDSSach.Image = ((System.Drawing.Image)(resources.GetObject("btnInDSSach.Image")));
            this.btnInDSSach.ImageRotate = 0F;
            this.btnInDSSach.Location = new System.Drawing.Point(1178, 12);
            this.btnInDSSach.Name = "btnInDSSach";
            this.btnInDSSach.PressedState.ImageSize = new System.Drawing.Size(70, 70);
            this.btnInDSSach.PressedState.Parent = this.btnInDSSach;
            this.btnInDSSach.Size = new System.Drawing.Size(64, 54);
            this.btnInDSSach.TabIndex = 12;
            this.btnInDSSach.Click += new System.EventHandler(this.btnInDSSach_Click);
            // 
            // barcode
            // 
            this.barcode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.barcode.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.barcode.CheckedState.Parent = this.barcode;
            this.barcode.HoverState.ImageSize = new System.Drawing.Size(54, 54);
            this.barcode.HoverState.Parent = this.barcode;
            this.barcode.Image = ((System.Drawing.Image)(resources.GetObject("barcode.Image")));
            this.barcode.ImageRotate = 0F;
            this.barcode.ImageSize = new System.Drawing.Size(54, 54);
            this.barcode.Location = new System.Drawing.Point(994, 74);
            this.barcode.Name = "barcode";
            this.barcode.PressedState.ImageSize = new System.Drawing.Size(60, 60);
            this.barcode.PressedState.Parent = this.barcode;
            this.barcode.Size = new System.Drawing.Size(54, 54);
            this.barcode.TabIndex = 11;
            this.barcode.Visible = false;
            this.barcode.Click += new System.EventHandler(this.barcode_Click);
            // 
            // btnGift
            // 
            this.btnGift.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGift.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnGift.CheckedState.Parent = this.btnGift;
            this.btnGift.HoverState.ImageSize = new System.Drawing.Size(54, 54);
            this.btnGift.HoverState.Parent = this.btnGift;
            this.btnGift.Image = ((System.Drawing.Image)(resources.GetObject("btnGift.Image")));
            this.btnGift.ImageRotate = 0F;
            this.btnGift.ImageSize = new System.Drawing.Size(54, 54);
            this.btnGift.Location = new System.Drawing.Point(1057, 74);
            this.btnGift.Name = "btnGift";
            this.btnGift.PressedState.ImageSize = new System.Drawing.Size(60, 60);
            this.btnGift.PressedState.Parent = this.btnGift;
            this.btnGift.Size = new System.Drawing.Size(54, 54);
            this.btnGift.TabIndex = 10;
            this.btnGift.Visible = false;
            this.btnGift.Click += new System.EventHandler(this.btnGift_Click);
            // 
            // picSach
            // 
            this.picSach.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picSach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.picSach.IconChar = FontAwesome.Sharp.IconChar.None;
            this.picSach.IconColor = System.Drawing.SystemColors.ControlText;
            this.picSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picSach.IconSize = 190;
            this.picSach.Location = new System.Drawing.Point(15, 5);
            this.picSach.Name = "picSach";
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
            this.txtKey.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey.HoverState.Parent = this.txtKey;
            this.txtKey.Location = new System.Drawing.Point(408, 103);
            this.txtKey.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '\0';
            this.txtKey.PlaceholderText = "Từ khóa";
            this.txtKey.SelectedText = "";
            this.txtKey.ShadowDecoration.Parent = this.txtKey;
            this.txtKey.Size = new System.Drawing.Size(464, 49);
            this.txtKey.TabIndex = 0;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 236);
            this.panel2.TabIndex = 1;
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AllowUserToResizeColumns = false;
            this.dgvSach.AllowUserToResizeRows = false;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDel,
            this.MaSach,
            this.TenSach,
            this.TenTG,
            this.TenLoai,
            this.SoLuong,
            this.DonGia,
            this.MoTa,
            this.NgayNhap});
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(0, 0);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(1254, 236);
            this.dgvSach.TabIndex = 0;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            this.dgvSach.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellDoubleClick);
            // 
            // btnDel
            // 
            this.btnDel.HeaderText = "Xóa";
            this.btnDel.MinimumWidth = 6;
            this.btnDel.Name = "btnDel";
            this.btnDel.ReadOnly = true;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseColumnTextForButtonValue = true;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // TenTG
            // 
            this.TenTG.DataPropertyName = "TenTG";
            this.TenTG.HeaderText = "Tên TG";
            this.TenTG.MinimumWidth = 6;
            this.TenTG.Name = "TenTG";
            this.TenTG.ReadOnly = true;
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TenLoai";
            this.TenLoai.HeaderText = "Tên loại";
            this.TenLoai.MinimumWidth = 6;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.picSach;
            // 
            // frmSanPham
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSanPham";
            this.Text = "SẢN PHẨM";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSach)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtKey;
        private FontAwesome.Sharp.IconPictureBox picSach;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ImageButton btnGift;
        private Guna.UI2.WinForms.Guna2ImageButton barcode;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridViewButtonColumn btnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private Guna.UI2.WinForms.Guna2ImageButton btnInDSSach;
        private Guna.UI2.WinForms.Guna2ImageButton btnThemSP;
    }
}