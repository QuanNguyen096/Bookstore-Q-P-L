namespace AppSach.NhanVien
{
    partial class frmChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamCong));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvLsDangNhap = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDiLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDay = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbCa = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvDSNVDD = new System.Windows.Forms.DataGridView();
            this.IDNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaiDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtKeyDD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLsDangNhap)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNVDD)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(1625, 671);
            this.splitContainer1.SplitterDistance = 949;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvLsDangNhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 471);
            this.panel2.TabIndex = 20;
            // 
            // dgvLsDangNhap
            // 
            this.dgvLsDangNhap.AllowUserToAddRows = false;
            this.dgvLsDangNhap.AllowUserToDeleteRows = false;
            this.dgvLsDangNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLsDangNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLsDangNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.HoVaTen,
            this.GioiTinh,
            this.TenCa,
            this.MoTa,
            this.ThoiGian,
            this.NgayDiLam,
            this.trangthai});
            this.dgvLsDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLsDangNhap.Location = new System.Drawing.Point(0, 0);
            this.dgvLsDangNhap.Name = "dgvLsDangNhap";
            this.dgvLsDangNhap.ReadOnly = true;
            this.dgvLsDangNhap.RowHeadersWidth = 51;
            this.dgvLsDangNhap.RowTemplate.Height = 24;
            this.dgvLsDangNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLsDangNhap.Size = new System.Drawing.Size(949, 471);
            this.dgvLsDangNhap.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 49;
            // 
            // HoVaTen
            // 
            this.HoVaTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HoVaTen.DataPropertyName = "HoVaTen";
            this.HoVaTen.HeaderText = "Họ và tên";
            this.HoVaTen.MinimumWidth = 6;
            this.HoVaTen.Name = "HoVaTen";
            this.HoVaTen.ReadOnly = true;
            this.HoVaTen.Width = 93;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 83;
            // 
            // TenCa
            // 
            this.TenCa.DataPropertyName = "TenCa";
            this.TenCa.HeaderText = "Tên ca";
            this.TenCa.MinimumWidth = 6;
            this.TenCa.Name = "TenCa";
            this.TenCa.ReadOnly = true;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Thời gian";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
            // 
            // NgayDiLam
            // 
            this.NgayDiLam.DataPropertyName = "NgayDiLam";
            this.NgayDiLam.HeaderText = "Ngày đi làm";
            this.NgayDiLam.MinimumWidth = 6;
            this.NgayDiLam.Name = "NgayDiLam";
            this.NgayDiLam.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtKey);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDay);
            this.panel1.Controls.Add(this.cmbCa);
            this.panel1.Controls.Add(this.cmbMonth);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 200);
            this.panel1.TabIndex = 19;
            // 
            // txtKey
            // 
            this.txtKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKey.DefaultText = "";
            this.txtKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKey.DisabledState.Parent = this.txtKey;
            this.txtKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey.FocusedState.Parent = this.txtKey;
            this.txtKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey.HoverState.Parent = this.txtKey;
            this.txtKey.Location = new System.Drawing.Point(214, 31);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '\0';
            this.txtKey.PlaceholderText = "";
            this.txtKey.SelectedText = "";
            this.txtKey.ShadowDecoration.Parent = this.txtKey;
            this.txtKey.Size = new System.Drawing.Size(304, 35);
            this.txtKey.TabIndex = 14;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 33);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngày/Tháng/Năm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên nhân viên :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtYear
            // 
            this.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYear.DefaultText = "";
            this.txtYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear.DisabledState.Parent = this.txtYear;
            this.txtYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear.FocusedState.Parent = this.txtYear;
            this.txtYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear.HoverState.Parent = this.txtYear;
            this.txtYear.Location = new System.Drawing.Point(419, 128);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYear.Name = "txtYear";
            this.txtYear.PasswordChar = '\0';
            this.txtYear.PlaceholderText = "";
            this.txtYear.SelectedText = "";
            this.txtYear.ShadowDecoration.Parent = this.txtYear;
            this.txtYear.Size = new System.Drawing.Size(90, 35);
            this.txtYear.TabIndex = 13;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDay_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 33);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ca";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDay
            // 
            this.txtDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDay.DefaultText = "";
            this.txtDay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDay.DisabledState.Parent = this.txtDay;
            this.txtDay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDay.FocusedState.Parent = this.txtDay;
            this.txtDay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDay.HoverState.Parent = this.txtDay;
            this.txtDay.Location = new System.Drawing.Point(211, 127);
            this.txtDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDay.Name = "txtDay";
            this.txtDay.PasswordChar = '\0';
            this.txtDay.PlaceholderText = "";
            this.txtDay.SelectedText = "";
            this.txtDay.ShadowDecoration.Parent = this.txtDay;
            this.txtDay.Size = new System.Drawing.Size(90, 36);
            this.txtDay.TabIndex = 12;
            this.txtDay.TextChanged += new System.EventHandler(this.txtDay_TextChanged);
            this.txtDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDay_KeyPress);
            // 
            // cmbCa
            // 
            this.cmbCa.FormattingEnabled = true;
            this.cmbCa.Location = new System.Drawing.Point(214, 86);
            this.cmbCa.Name = "cmbCa";
            this.cmbCa.Size = new System.Drawing.Size(121, 24);
            this.cmbCa.TabIndex = 15;
            this.cmbCa.SelectedIndexChanged += new System.EventHandler(this.cmbCa_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.BackColor = System.Drawing.Color.Transparent;
            this.cmbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMonth.FocusedState.Parent = this.cmbMonth;
            this.cmbMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMonth.HoverState.Parent = this.cmbMonth;
            this.cmbMonth.ItemHeight = 30;
            this.cmbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12"});
            this.cmbMonth.ItemsAppearance.Parent = this.cmbMonth;
            this.cmbMonth.Location = new System.Drawing.Point(308, 127);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.ShadowDecoration.Parent = this.cmbMonth;
            this.cmbMonth.Size = new System.Drawing.Size(104, 36);
            this.cmbMonth.TabIndex = 11;
            this.cmbMonth.TextChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            this.cmbMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDay_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvDSNVDD);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(672, 471);
            this.panel4.TabIndex = 1;
            // 
            // dgvDSNVDD
            // 
            this.dgvDSNVDD.AllowUserToAddRows = false;
            this.dgvDSNVDD.AllowUserToDeleteRows = false;
            this.dgvDSNVDD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNVDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNVDD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDNV,
            this.HoVaTenNV,
            this.Calam,
            this.SoCa,
            this.trangthaiDD});
            this.dgvDSNVDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNVDD.Location = new System.Drawing.Point(0, 0);
            this.dgvDSNVDD.Name = "dgvDSNVDD";
            this.dgvDSNVDD.ReadOnly = true;
            this.dgvDSNVDD.RowHeadersWidth = 51;
            this.dgvDSNVDD.RowTemplate.Height = 24;
            this.dgvDSNVDD.Size = new System.Drawing.Size(672, 471);
            this.dgvDSNVDD.TabIndex = 0;
            this.dgvDSNVDD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNVDD_CellDoubleClick);
            // 
            // IDNV
            // 
            this.IDNV.DataPropertyName = "ID";
            this.IDNV.HeaderText = "ID";
            this.IDNV.MinimumWidth = 6;
            this.IDNV.Name = "IDNV";
            this.IDNV.ReadOnly = true;
            // 
            // HoVaTenNV
            // 
            this.HoVaTenNV.DataPropertyName = "HoVaTen";
            this.HoVaTenNV.HeaderText = "Họ và tên";
            this.HoVaTenNV.MinimumWidth = 6;
            this.HoVaTenNV.Name = "HoVaTenNV";
            this.HoVaTenNV.ReadOnly = true;
            // 
            // Calam
            // 
            this.Calam.DataPropertyName = "tenca";
            this.Calam.HeaderText = "Ca làm việc";
            this.Calam.MinimumWidth = 6;
            this.Calam.Name = "Calam";
            this.Calam.ReadOnly = true;
            // 
            // SoCa
            // 
            this.SoCa.DataPropertyName = "soca";
            this.SoCa.HeaderText = "Số ca";
            this.SoCa.MinimumWidth = 6;
            this.SoCa.Name = "SoCa";
            this.SoCa.ReadOnly = true;
            // 
            // trangthaiDD
            // 
            this.trangthaiDD.DataPropertyName = "DiemDanh";
            this.trangthaiDD.HeaderText = "Trạng thái";
            this.trangthaiDD.MinimumWidth = 6;
            this.trangthaiDD.Name = "trangthaiDD";
            this.trangthaiDD.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtKeyDD);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 200);
            this.panel3.TabIndex = 0;
            // 
            // txtKeyDD
            // 
            this.txtKeyDD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKeyDD.DefaultText = "";
            this.txtKeyDD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKeyDD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKeyDD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKeyDD.DisabledState.Parent = this.txtKeyDD;
            this.txtKeyDD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKeyDD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKeyDD.FocusedState.Parent = this.txtKeyDD;
            this.txtKeyDD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKeyDD.HoverState.Parent = this.txtKeyDD;
            this.txtKeyDD.Location = new System.Drawing.Point(273, 80);
            this.txtKeyDD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKeyDD.Name = "txtKeyDD";
            this.txtKeyDD.PasswordChar = '\0';
            this.txtKeyDD.PlaceholderText = "";
            this.txtKeyDD.SelectedText = "";
            this.txtKeyDD.ShadowDecoration.Parent = this.txtKeyDD;
            this.txtKeyDD.Size = new System.Drawing.Size(304, 35);
            this.txtKeyDD.TabIndex = 19;
            this.txtKeyDD.TextChanged += new System.EventHandler(this.txtKeyDD_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 33);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tên nhân viên :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmChamCong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(1625, 671);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChamCong";
            this.Text = "BẢNG CHẤM CÔNG NHÂN VIÊN";
            this.Load += new System.EventHandler(this.frmChamCong_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLsDangNhap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNVDD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCa;
        private Guna.UI2.WinForms.Guna2TextBox txtYear;
        private Guna.UI2.WinForms.Guna2TextBox txtDay;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMonth;
        private System.Windows.Forms.DataGridView dgvLsDangNhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDiLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvDSNVDD;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtKeyDD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calam;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaiDD;
    }
}