namespace AppSach.NhanVien
{
    partial class frmDSDD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSDD));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDay = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbCa = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvDSDD = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lienhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vipham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luongngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNam = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMM = new System.Windows.Forms.ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvLuongThang = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchNamNam = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSearchNam = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvLuongNam = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClsThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDD)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongThang)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongNam)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1369, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            this.tabPage1.Controls.Add(this.txtKey);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtYear);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtDay);
            this.tabPage1.Controls.Add(this.cmbCa);
            this.tabPage1.Controls.Add(this.cmbMonth);
            this.tabPage1.Controls.Add(this.dgvDSDD);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1361, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LƯƠNG NGÀY";
            // 
            // txtKey
            // 
            this.txtKey.BorderRadius = 20;
            this.txtKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKey.DefaultText = "";
            this.txtKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKey.DisabledState.Parent = this.txtKey;
            this.txtKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey.FocusedState.Parent = this.txtKey;
            this.txtKey.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.txtKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey.HoverState.Parent = this.txtKey;
            this.txtKey.Location = new System.Drawing.Point(219, 12);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '\0';
            this.txtKey.PlaceholderText = "";
            this.txtKey.SelectedText = "";
            this.txtKey.ShadowDecoration.Parent = this.txtKey;
            this.txtKey.Size = new System.Drawing.Size(288, 35);
            this.txtKey.TabIndex = 31;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("UTM Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 33);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ngày/Tháng/Năm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("UTM Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tên nhân viên :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtYear
            // 
            this.txtYear.BorderRadius = 20;
            this.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYear.DefaultText = "";
            this.txtYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear.DisabledState.Parent = this.txtYear;
            this.txtYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear.FocusedState.Parent = this.txtYear;
            this.txtYear.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.txtYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear.HoverState.Parent = this.txtYear;
            this.txtYear.Location = new System.Drawing.Point(424, 120);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.PasswordChar = '\0';
            this.txtYear.PlaceholderText = "";
            this.txtYear.SelectedText = "";
            this.txtYear.ShadowDecoration.Parent = this.txtYear;
            this.txtYear.Size = new System.Drawing.Size(83, 35);
            this.txtYear.TabIndex = 30;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("UTM Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 33);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ca";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDay
            // 
            this.txtDay.BorderRadius = 20;
            this.txtDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDay.DefaultText = "";
            this.txtDay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDay.DisabledState.Parent = this.txtDay;
            this.txtDay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDay.FocusedState.Parent = this.txtDay;
            this.txtDay.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.txtDay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDay.HoverState.Parent = this.txtDay;
            this.txtDay.Location = new System.Drawing.Point(216, 119);
            this.txtDay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDay.Name = "txtDay";
            this.txtDay.PasswordChar = '\0';
            this.txtDay.PlaceholderText = "";
            this.txtDay.SelectedText = "";
            this.txtDay.ShadowDecoration.Parent = this.txtDay;
            this.txtDay.Size = new System.Drawing.Size(83, 35);
            this.txtDay.TabIndex = 29;
            this.txtDay.TextChanged += new System.EventHandler(this.txtDay_TextChanged);
            this.txtDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDay_KeyPress);
            // 
            // cmbCa
            // 
            this.cmbCa.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.cmbCa.FormattingEnabled = true;
            this.cmbCa.Location = new System.Drawing.Point(219, 69);
            this.cmbCa.Name = "cmbCa";
            this.cmbCa.Size = new System.Drawing.Size(121, 31);
            this.cmbCa.TabIndex = 32;
            this.cmbCa.SelectedIndexChanged += new System.EventHandler(this.cmbCa_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.BackColor = System.Drawing.Color.Transparent;
            this.cmbMonth.BorderRadius = 20;
            this.cmbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMonth.FocusedState.Parent = this.cmbMonth;
            this.cmbMonth.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
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
            this.cmbMonth.Location = new System.Drawing.Point(313, 119);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.ShadowDecoration.Parent = this.cmbMonth;
            this.cmbMonth.Size = new System.Drawing.Size(97, 36);
            this.cmbMonth.TabIndex = 28;
            this.cmbMonth.TextChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            this.cmbMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // dgvDSDD
            // 
            this.dgvDSDD.AllowUserToAddRows = false;
            this.dgvDSDD.AllowUserToDeleteRows = false;
            this.dgvDSDD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.HoVaTen,
            this.GioiTinh,
            this.lienhe,
            this.Luong,
            this.Vipham,
            this.Luongngay,
            this.Ngay});
            this.dgvDSDD.Location = new System.Drawing.Point(8, 176);
            this.dgvDSDD.Name = "dgvDSDD";
            this.dgvDSDD.ReadOnly = true;
            this.dgvDSDD.RowHeadersWidth = 51;
            this.dgvDSDD.RowTemplate.Height = 24;
            this.dgvDSDD.Size = new System.Drawing.Size(1345, 306);
            this.dgvDSDD.TabIndex = 27;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // HoVaTen
            // 
            this.HoVaTen.DataPropertyName = "HoVaTen";
            this.HoVaTen.HeaderText = "Họ và tên";
            this.HoVaTen.MinimumWidth = 6;
            this.HoVaTen.Name = "HoVaTen";
            this.HoVaTen.ReadOnly = true;
            this.HoVaTen.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 125;
            // 
            // lienhe
            // 
            this.lienhe.DataPropertyName = "lienhe";
            this.lienhe.HeaderText = "Liên hệ";
            this.lienhe.MinimumWidth = 6;
            this.lienhe.Name = "lienhe";
            this.lienhe.ReadOnly = true;
            this.lienhe.Width = 125;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương cơ bản";
            this.Luong.MinimumWidth = 6;
            this.Luong.Name = "Luong";
            this.Luong.ReadOnly = true;
            this.Luong.Width = 125;
            // 
            // Vipham
            // 
            this.Vipham.DataPropertyName = "Vipham";
            this.Vipham.HeaderText = "Vi phạm";
            this.Vipham.MinimumWidth = 6;
            this.Vipham.Name = "Vipham";
            this.Vipham.ReadOnly = true;
            this.Vipham.Width = 125;
            // 
            // Luongngay
            // 
            this.Luongngay.DataPropertyName = "Luongngay";
            this.Luongngay.HeaderText = "Lương ngày";
            this.Luongngay.MinimumWidth = 6;
            this.Luongngay.Name = "Luongngay";
            this.Luongngay.ReadOnly = true;
            this.Luongngay.Width = 125;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            this.Ngay.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtNam);
            this.tabPage2.Controls.Add(this.txtMM);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.dgvLuongThang);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1361, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LƯƠNG THÁNG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tháng/Năm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên NV/ID";
            // 
            // txtNam
            // 
            this.txtNam.BorderRadius = 20;
            this.txtNam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNam.DefaultText = "";
            this.txtNam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNam.DisabledState.Parent = this.txtNam;
            this.txtNam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNam.FocusedState.Parent = this.txtNam;
            this.txtNam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNam.HoverState.Parent = this.txtNam;
            this.txtNam.Location = new System.Drawing.Point(345, 90);
            this.txtNam.Margin = new System.Windows.Forms.Padding(6);
            this.txtNam.Name = "txtNam";
            this.txtNam.PasswordChar = '\0';
            this.txtNam.PlaceholderText = "";
            this.txtNam.SelectedText = "";
            this.txtNam.ShadowDecoration.Parent = this.txtNam;
            this.txtNam.Size = new System.Drawing.Size(119, 33);
            this.txtNam.TabIndex = 3;
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMM_KeyPress);
            // 
            // txtMM
            // 
            this.txtMM.FormattingEnabled = true;
            this.txtMM.Items.AddRange(new object[] {
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
            "11",
            "12"});
            this.txtMM.Location = new System.Drawing.Point(195, 90);
            this.txtMM.Name = "txtMM";
            this.txtMM.Size = new System.Drawing.Size(121, 33);
            this.txtMM.TabIndex = 2;
            this.txtMM.SelectedIndexChanged += new System.EventHandler(this.txtMM_SelectedIndexChanged);
            this.txtMM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMM_KeyPress);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(195, 26);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(269, 44);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvLuongThang
            // 
            this.dgvLuongThang.AllowUserToAddRows = false;
            this.dgvLuongThang.AllowUserToDeleteRows = false;
            this.dgvLuongThang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLuongThang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuongThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuongThang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.HoTen,
            this.LuongThang,
            this.thoigian});
            this.dgvLuongThang.Location = new System.Drawing.Point(8, 149);
            this.dgvLuongThang.Name = "dgvLuongThang";
            this.dgvLuongThang.ReadOnly = true;
            this.dgvLuongThang.RowHeadersWidth = 51;
            this.dgvLuongThang.RowTemplate.Height = 24;
            this.dgvLuongThang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuongThang.Size = new System.Drawing.Size(1347, 338);
            this.dgvLuongThang.TabIndex = 0;
            // 
            // cID
            // 
            this.cID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cID.DataPropertyName = "ID";
            this.cID.HeaderText = "ID";
            this.cID.MinimumWidth = 6;
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Width = 60;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoVaTen";
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // LuongThang
            // 
            this.LuongThang.DataPropertyName = "LuongThang";
            this.LuongThang.HeaderText = "Lương tháng";
            this.LuongThang.MinimumWidth = 6;
            this.LuongThang.Name = "LuongThang";
            this.LuongThang.ReadOnly = true;
            // 
            // thoigian
            // 
            this.thoigian.DataPropertyName = "ThoiGian";
            this.thoigian.HeaderText = "Thời gian";
            this.thoigian.MinimumWidth = 6;
            this.thoigian.Name = "thoigian";
            this.thoigian.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtSearchNamNam);
            this.tabPage3.Controls.Add(this.txtSearchNam);
            this.tabPage3.Controls.Add(this.dgvLuongNam);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1361, 490);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "LƯƠNG NĂM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(123, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Năm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(65, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên NV/ID";
            // 
            // txtSearchNamNam
            // 
            this.txtSearchNamNam.BorderRadius = 20;
            this.txtSearchNamNam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchNamNam.DefaultText = "";
            this.txtSearchNamNam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchNamNam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchNamNam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchNamNam.DisabledState.Parent = this.txtSearchNamNam;
            this.txtSearchNamNam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchNamNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchNamNam.FocusedState.Parent = this.txtSearchNamNam;
            this.txtSearchNamNam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchNamNam.HoverState.Parent = this.txtSearchNamNam;
            this.txtSearchNamNam.Location = new System.Drawing.Point(193, 109);
            this.txtSearchNamNam.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearchNamNam.Name = "txtSearchNamNam";
            this.txtSearchNamNam.PasswordChar = '\0';
            this.txtSearchNamNam.PlaceholderText = "";
            this.txtSearchNamNam.SelectedText = "";
            this.txtSearchNamNam.ShadowDecoration.Parent = this.txtSearchNamNam;
            this.txtSearchNamNam.Size = new System.Drawing.Size(113, 44);
            this.txtSearchNamNam.TabIndex = 2;
            this.txtSearchNamNam.TextChanged += new System.EventHandler(this.txtSearchNamNam_TextChanged);
            this.txtSearchNamNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchNamNam_KeyPress);
            // 
            // txtSearchNam
            // 
            this.txtSearchNam.BorderRadius = 20;
            this.txtSearchNam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchNam.DefaultText = "";
            this.txtSearchNam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchNam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchNam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchNam.DisabledState.Parent = this.txtSearchNam;
            this.txtSearchNam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchNam.FocusedState.Parent = this.txtSearchNam;
            this.txtSearchNam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchNam.HoverState.Parent = this.txtSearchNam;
            this.txtSearchNam.Location = new System.Drawing.Point(193, 28);
            this.txtSearchNam.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearchNam.Name = "txtSearchNam";
            this.txtSearchNam.PasswordChar = '\0';
            this.txtSearchNam.PlaceholderText = "";
            this.txtSearchNam.SelectedText = "";
            this.txtSearchNam.ShadowDecoration.Parent = this.txtSearchNam;
            this.txtSearchNam.Size = new System.Drawing.Size(244, 44);
            this.txtSearchNam.TabIndex = 1;
            this.txtSearchNam.TextChanged += new System.EventHandler(this.txtSearchNam_TextChanged);
            // 
            // dgvLuongNam
            // 
            this.dgvLuongNam.AllowUserToAddRows = false;
            this.dgvLuongNam.AllowUserToDeleteRows = false;
            this.dgvLuongNam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLuongNam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuongNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuongNam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clHoTen,
            this.clLuong,
            this.ClsThoiGian});
            this.dgvLuongNam.Location = new System.Drawing.Point(8, 178);
            this.dgvLuongNam.Name = "dgvLuongNam";
            this.dgvLuongNam.ReadOnly = true;
            this.dgvLuongNam.RowHeadersWidth = 51;
            this.dgvLuongNam.RowTemplate.Height = 24;
            this.dgvLuongNam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuongNam.Size = new System.Drawing.Size(1345, 304);
            this.dgvLuongNam.TabIndex = 0;
            // 
            // clId
            // 
            this.clId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clId.DataPropertyName = "id";
            this.clId.HeaderText = "ID";
            this.clId.MinimumWidth = 6;
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Width = 60;
            // 
            // clHoTen
            // 
            this.clHoTen.DataPropertyName = "HoVaTen";
            this.clHoTen.HeaderText = "Họ và tên";
            this.clHoTen.MinimumWidth = 6;
            this.clHoTen.Name = "clHoTen";
            this.clHoTen.ReadOnly = true;
            // 
            // clLuong
            // 
            this.clLuong.DataPropertyName = "LuongNam";
            this.clLuong.HeaderText = "Lương";
            this.clLuong.MinimumWidth = 6;
            this.clLuong.Name = "clLuong";
            this.clLuong.ReadOnly = true;
            // 
            // ClsThoiGian
            // 
            this.ClsThoiGian.DataPropertyName = "ThoiGian";
            this.ClsThoiGian.HeaderText = "Thời gian";
            this.ClsThoiGian.MinimumWidth = 6;
            this.ClsThoiGian.Name = "ClsThoiGian";
            this.ClsThoiGian.ReadOnly = true;
            // 
            // frmDSDD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1369, 528);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDSDD";
            this.Text = "DANH SÁCH DIỂM DANH";
            this.Load += new System.EventHandler(this.frmDSDD_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDD)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongThang)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongNam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2TextBox txtKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtDay;
        private System.Windows.Forms.ComboBox cmbCa;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMonth;
        private System.Windows.Forms.DataGridView dgvDSDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn lienhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vipham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luongngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvLuongThang;
        private System.Windows.Forms.ComboBox txtMM;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtNam;
        private System.Windows.Forms.DataGridView dgvLuongNam;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchNamNam;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClsThoiGian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}