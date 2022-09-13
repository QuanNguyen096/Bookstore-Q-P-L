namespace AppSach
{
    partial class frmThemOrEditSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemOrEditSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.picSach = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnMoThuMuc = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMoTa = new System.Windows.Forms.RichTextBox();
            this.btnThemNXB = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnThemLoai = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cmbNXB = new System.Windows.Forms.ComboBox();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.nuSL = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenTG = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuSL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 85);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(436, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 85);
            this.panel2.TabIndex = 20;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("UTM Cookies", 16F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(453, 85);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "THÊM SÁCH";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClose.Location = new System.Drawing.Point(1239, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 18;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picSach
            // 
            this.picSach.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picSach.Image = ((System.Drawing.Image)(resources.GetObject("picSach.Image")));
            this.picSach.Location = new System.Drawing.Point(29, 110);
            this.picSach.Name = "picSach";
            this.picSach.ShadowDecoration.Parent = this.picSach;
            this.picSach.Size = new System.Drawing.Size(190, 240);
            this.picSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSach.TabIndex = 1;
            this.picSach.TabStop = false;
            // 
            // btnMoThuMuc
            // 
            this.btnMoThuMuc.BorderRadius = 16;
            this.btnMoThuMuc.BorderThickness = 2;
            this.btnMoThuMuc.CheckedState.Parent = this.btnMoThuMuc;
            this.btnMoThuMuc.CustomImages.Parent = this.btnMoThuMuc;
            this.btnMoThuMuc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMoThuMuc.Font = new System.Drawing.Font("UTM Cookies", 14F);
            this.btnMoThuMuc.ForeColor = System.Drawing.Color.White;
            this.btnMoThuMuc.HoverState.Parent = this.btnMoThuMuc;
            this.btnMoThuMuc.Location = new System.Drawing.Point(31, 360);
            this.btnMoThuMuc.Name = "btnMoThuMuc";
            this.btnMoThuMuc.ShadowDecoration.Parent = this.btnMoThuMuc;
            this.btnMoThuMuc.Size = new System.Drawing.Size(180, 45);
            this.btnMoThuMuc.TabIndex = 0;
            this.btnMoThuMuc.Text = "Chọn ảnh";
            this.btnMoThuMuc.Click += new System.EventHandler(this.btnMoThuMuc_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.picSach;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.btnThemNXB);
            this.groupBox1.Controls.Add(this.btnThemLoai);
            this.groupBox1.Controls.Add(this.cmbNXB);
            this.groupBox1.Controls.Add(this.cmbLoai);
            this.groupBox1.Controls.Add(this.nuSL);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenTG);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Font = new System.Drawing.Font("UTM Cookies", 16F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(239, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 461);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN SÁCH";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(611, 60);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(389, 297);
            this.txtMoTa.TabIndex = 6;
            this.txtMoTa.Text = "";
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThemNXB.CheckedState.Parent = this.btnThemNXB;
            this.btnThemNXB.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnThemNXB.HoverState.Parent = this.btnThemNXB;
            this.btnThemNXB.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNXB.Image")));
            this.btnThemNXB.ImageRotate = 0F;
            this.btnThemNXB.ImageSize = new System.Drawing.Size(32, 32);
            this.btnThemNXB.Location = new System.Drawing.Point(526, 217);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnThemNXB.PressedState.Parent = this.btnThemNXB;
            this.btnThemNXB.Size = new System.Drawing.Size(32, 32);
            this.btnThemNXB.TabIndex = 22;
            this.btnThemNXB.Click += new System.EventHandler(this.btnThemNXB_Click);
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThemLoai.CheckedState.Parent = this.btnThemLoai;
            this.btnThemLoai.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnThemLoai.HoverState.Parent = this.btnThemLoai;
            this.btnThemLoai.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLoai.Image")));
            this.btnThemLoai.ImageRotate = 0F;
            this.btnThemLoai.ImageSize = new System.Drawing.Size(32, 32);
            this.btnThemLoai.Location = new System.Drawing.Point(526, 166);
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnThemLoai.PressedState.Parent = this.btnThemLoai;
            this.btnThemLoai.Size = new System.Drawing.Size(32, 32);
            this.btnThemLoai.TabIndex = 17;
            this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click);
            // 
            // cmbNXB
            // 
            this.cmbNXB.FormattingEnabled = true;
            this.cmbNXB.Location = new System.Drawing.Point(181, 210);
            this.cmbNXB.Name = "cmbNXB";
            this.cmbNXB.Size = new System.Drawing.Size(337, 44);
            this.cmbNXB.TabIndex = 3;
            // 
            // cmbLoai
            // 
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Location = new System.Drawing.Point(181, 160);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(337, 44);
            this.cmbLoai.TabIndex = 2;
            this.cmbLoai.SelectedIndexChanged += new System.EventHandler(this.cmbLoai_SelectedIndexChanged);
            // 
            // nuSL
            // 
            this.nuSL.Location = new System.Drawing.Point(181, 262);
            this.nuSL.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nuSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuSL.Name = "nuSL";
            this.nuSL.Size = new System.Drawing.Size(120, 43);
            this.nuSL.TabIndex = 4;
            this.nuSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UTM Cookies", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(363, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "VNĐ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderRadius = 16;
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.DefaultText = "";
            this.txtDonGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.DisabledState.Parent = this.txtDonGia;
            this.txtDonGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.FocusedState.Parent = this.txtDonGia;
            this.txtDonGia.Font = new System.Drawing.Font("UTM Cookies", 16F);
            this.txtDonGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.HoverState.Parent = this.txtDonGia;
            this.txtDonGia.Location = new System.Drawing.Point(181, 317);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PasswordChar = '\0';
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.ShadowDecoration.Parent = this.txtDonGia;
            this.txtDonGia.Size = new System.Drawing.Size(174, 40);
            this.txtDonGia.TabIndex = 5;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KhongChoNhapChu);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UTM Cookies", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(528, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mô tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UTM Cookies", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UTM Cookies", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Cookies", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "NXB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Cookies", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Cookies", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tác giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Cookies", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên sách";
            // 
            // txtTenTG
            // 
            this.txtTenTG.BorderRadius = 16;
            this.txtTenTG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTG.DefaultText = "";
            this.txtTenTG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTG.DisabledState.Parent = this.txtTenTG;
            this.txtTenTG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTG.FocusedState.Parent = this.txtTenTG;
            this.txtTenTG.Font = new System.Drawing.Font("UTM Cookies", 16F);
            this.txtTenTG.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTG.HoverState.Parent = this.txtTenTG;
            this.txtTenTG.Location = new System.Drawing.Point(181, 115);
            this.txtTenTG.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.PasswordChar = '\0';
            this.txtTenTG.PlaceholderText = "";
            this.txtTenTG.SelectedText = "";
            this.txtTenTG.ShadowDecoration.Parent = this.txtTenTG;
            this.txtTenTG.Size = new System.Drawing.Size(174, 40);
            this.txtTenTG.TabIndex = 1;
            // 
            // txtTenSach
            // 
            this.txtTenSach.BorderRadius = 16;
            this.txtTenSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSach.DefaultText = "";
            this.txtTenSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSach.DisabledState.Parent = this.txtTenSach;
            this.txtTenSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSach.FocusedState.Parent = this.txtTenSach;
            this.txtTenSach.Font = new System.Drawing.Font("UTM Cookies", 16F);
            this.txtTenSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSach.HoverState.Parent = this.txtTenSach;
            this.txtTenSach.Location = new System.Drawing.Point(181, 57);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.PasswordChar = '\0';
            this.txtTenSach.PlaceholderText = "";
            this.txtTenSach.SelectedText = "";
            this.txtTenSach.ShadowDecoration.Parent = this.txtTenSach;
            this.txtTenSach.Size = new System.Drawing.Size(324, 40);
            this.txtTenSach.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.BorderThickness = 2;
            this.btnLuu.CheckedState.Parent = this.btnLuu;
            this.btnLuu.CustomImages.Parent = this.btnLuu;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLuu.Font = new System.Drawing.Font("UTM Cookies", 14F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.Parent = this.btnLuu;
            this.btnLuu.Location = new System.Drawing.Point(1153, 582);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(86, 77);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 16;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.lblTitle;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 16;
            this.guna2Elipse4.TargetControl = this.nuSL;
            // 
            // frmThemOrEditSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(1282, 671);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMoThuMuc);
            this.Controls.Add(this.picSach);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmThemOrEditSach";
            this.Text = "frmThemOrEditSach";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmThemOrEditSach_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuSL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox picSach;
        private Guna.UI2.WinForms.Guna2Button btnMoThuMuc;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSach;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtDonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2CircleButton btnLuu;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nuSL;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.ComboBox cmbNXB;
        private Guna.UI2.WinForms.Guna2ImageButton btnThemNXB;
        private Guna.UI2.WinForms.Guna2ImageButton btnThemLoai;
        private System.Windows.Forms.RichTextBox txtMoTa;
    }
}