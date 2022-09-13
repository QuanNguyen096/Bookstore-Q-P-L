namespace AppSach
{
    partial class frmCa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCa));
            this.dgvCa = new System.Windows.Forms.DataGridView();
            this.MaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenCa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHH1BD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHP1BD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHP1KT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHH1KT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHP2KT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHH2KT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHP2BD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHH2BD = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoCa = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCa
            // 
            this.dgvCa.AllowUserToAddRows = false;
            this.dgvCa.AllowUserToDeleteRows = false;
            this.dgvCa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCa,
            this.TenCa,
            this.SoCa,
            this.Mota});
            this.dgvCa.Location = new System.Drawing.Point(12, 117);
            this.dgvCa.Name = "dgvCa";
            this.dgvCa.ReadOnly = true;
            this.dgvCa.RowHeadersWidth = 51;
            this.dgvCa.RowTemplate.Height = 24;
            this.dgvCa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCa.Size = new System.Drawing.Size(578, 170);
            this.dgvCa.TabIndex = 1;
            this.dgvCa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCa_CellClick);
            // 
            // MaCa
            // 
            this.MaCa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaCa.DataPropertyName = "MaCa";
            this.MaCa.HeaderText = "Mã ca";
            this.MaCa.MinimumWidth = 6;
            this.MaCa.Name = "MaCa";
            this.MaCa.ReadOnly = true;
            this.MaCa.Width = 73;
            // 
            // TenCa
            // 
            this.TenCa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenCa.DataPropertyName = "TenCa";
            this.TenCa.HeaderText = "Tên ca";
            this.TenCa.MinimumWidth = 6;
            this.TenCa.Name = "TenCa";
            this.TenCa.ReadOnly = true;
            this.TenCa.Width = 78;
            // 
            // SoCa
            // 
            this.SoCa.DataPropertyName = "SoCa";
            this.SoCa.HeaderText = "Số ca";
            this.SoCa.MinimumWidth = 6;
            this.SoCa.Name = "SoCa";
            this.SoCa.ReadOnly = true;
            // 
            // Mota
            // 
            this.Mota.DataPropertyName = "Mota";
            this.Mota.HeaderText = "Mô tả";
            this.Mota.MinimumWidth = 6;
            this.Mota.Name = "Mota";
            this.Mota.ReadOnly = true;
            // 
            // txtTenCa
            // 
            this.txtTenCa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenCa.DefaultText = "";
            this.txtTenCa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenCa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenCa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenCa.DisabledState.Parent = this.txtTenCa;
            this.txtTenCa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenCa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenCa.FocusedState.Parent = this.txtTenCa;
            this.txtTenCa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenCa.HoverState.Parent = this.txtTenCa;
            this.txtTenCa.Location = new System.Drawing.Point(715, 117);
            this.txtTenCa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenCa.Name = "txtTenCa";
            this.txtTenCa.PasswordChar = '\0';
            this.txtTenCa.PlaceholderText = "";
            this.txtTenCa.SelectedText = "";
            this.txtTenCa.ShadowDecoration.Parent = this.txtTenCa;
            this.txtTenCa.Size = new System.Drawing.Size(170, 44);
            this.txtTenCa.TabIndex = 2;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.DisabledState.Parent = this.txtMoTa;
            this.txtMoTa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.FocusedState.Parent = this.txtMoTa;
            this.txtMoTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.HoverState.Parent = this.txtMoTa;
            this.txtMoTa.Location = new System.Drawing.Point(715, 169);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PasswordChar = '\0';
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.ShadowDecoration.Parent = this.txtMoTa;
            this.txtMoTa.Size = new System.Drawing.Size(170, 44);
            this.txtMoTa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(613, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên ca";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(613, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mô tả";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(131, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Từ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHH1BD
            // 
            this.txtHH1BD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHH1BD.DefaultText = "";
            this.txtHH1BD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHH1BD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHH1BD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHH1BD.DisabledState.Parent = this.txtHH1BD;
            this.txtHH1BD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHH1BD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHH1BD.FocusedState.Parent = this.txtHH1BD;
            this.txtHH1BD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHH1BD.HoverState.Parent = this.txtHH1BD;
            this.txtHH1BD.Location = new System.Drawing.Point(233, 331);
            this.txtHH1BD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHH1BD.Name = "txtHH1BD";
            this.txtHH1BD.PasswordChar = '\0';
            this.txtHH1BD.PlaceholderText = "";
            this.txtHH1BD.SelectedText = "";
            this.txtHH1BD.ShadowDecoration.Parent = this.txtHH1BD;
            this.txtHH1BD.Size = new System.Drawing.Size(52, 44);
            this.txtHH1BD.TabIndex = 6;
            this.txtHH1BD.TextChanged += new System.EventHandler(this.txtHH1BD_TextChanged);
            // 
            // txtHP1BD
            // 
            this.txtHP1BD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHP1BD.DefaultText = "";
            this.txtHP1BD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHP1BD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHP1BD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHP1BD.DisabledState.Parent = this.txtHP1BD;
            this.txtHP1BD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHP1BD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHP1BD.FocusedState.Parent = this.txtHP1BD;
            this.txtHP1BD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHP1BD.HoverState.Parent = this.txtHP1BD;
            this.txtHP1BD.Location = new System.Drawing.Point(305, 331);
            this.txtHP1BD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHP1BD.Name = "txtHP1BD";
            this.txtHP1BD.PasswordChar = '\0';
            this.txtHP1BD.PlaceholderText = "";
            this.txtHP1BD.SelectedText = "";
            this.txtHP1BD.ShadowDecoration.Parent = this.txtHP1BD;
            this.txtHP1BD.Size = new System.Drawing.Size(52, 44);
            this.txtHP1BD.TabIndex = 8;
            this.txtHP1BD.TextChanged += new System.EventHandler(this.txtHP1BD_TextChanged);
            // 
            // txtHP1KT
            // 
            this.txtHP1KT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHP1KT.DefaultText = "";
            this.txtHP1KT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHP1KT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHP1KT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHP1KT.DisabledState.Parent = this.txtHP1KT;
            this.txtHP1KT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHP1KT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHP1KT.FocusedState.Parent = this.txtHP1KT;
            this.txtHP1KT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHP1KT.HoverState.Parent = this.txtHP1KT;
            this.txtHP1KT.Location = new System.Drawing.Point(305, 383);
            this.txtHP1KT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHP1KT.Name = "txtHP1KT";
            this.txtHP1KT.PasswordChar = '\0';
            this.txtHP1KT.PlaceholderText = "";
            this.txtHP1KT.SelectedText = "";
            this.txtHP1KT.ShadowDecoration.Parent = this.txtHP1KT;
            this.txtHP1KT.Size = new System.Drawing.Size(52, 44);
            this.txtHP1KT.TabIndex = 11;
            this.txtHP1KT.TextChanged += new System.EventHandler(this.txtHP1KT_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(131, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đến";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHH1KT
            // 
            this.txtHH1KT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHH1KT.DefaultText = "";
            this.txtHH1KT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHH1KT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHH1KT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHH1KT.DisabledState.Parent = this.txtHH1KT;
            this.txtHH1KT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHH1KT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHH1KT.FocusedState.Parent = this.txtHH1KT;
            this.txtHH1KT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHH1KT.HoverState.Parent = this.txtHH1KT;
            this.txtHH1KT.Location = new System.Drawing.Point(233, 383);
            this.txtHH1KT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHH1KT.Name = "txtHH1KT";
            this.txtHH1KT.PasswordChar = '\0';
            this.txtHH1KT.PlaceholderText = "";
            this.txtHH1KT.SelectedText = "";
            this.txtHH1KT.ShadowDecoration.Parent = this.txtHH1KT;
            this.txtHH1KT.Size = new System.Drawing.Size(52, 44);
            this.txtHH1KT.TabIndex = 9;
            this.txtHH1KT.TextChanged += new System.EventHandler(this.txtHH1KT_TextChanged);
            // 
            // txtHP2KT
            // 
            this.txtHP2KT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHP2KT.DefaultText = "";
            this.txtHP2KT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHP2KT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHP2KT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHP2KT.DisabledState.Parent = this.txtHP2KT;
            this.txtHP2KT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHP2KT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHP2KT.FocusedState.Parent = this.txtHP2KT;
            this.txtHP2KT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHP2KT.HoverState.Parent = this.txtHP2KT;
            this.txtHP2KT.Location = new System.Drawing.Point(538, 383);
            this.txtHP2KT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHP2KT.Name = "txtHP2KT";
            this.txtHP2KT.PasswordChar = '\0';
            this.txtHP2KT.PlaceholderText = "";
            this.txtHP2KT.SelectedText = "";
            this.txtHP2KT.ShadowDecoration.Parent = this.txtHP2KT;
            this.txtHP2KT.Size = new System.Drawing.Size(52, 44);
            this.txtHP2KT.TabIndex = 17;
            this.txtHP2KT.TextChanged += new System.EventHandler(this.txtHP2KT_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(364, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Đến";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHH2KT
            // 
            this.txtHH2KT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHH2KT.DefaultText = "";
            this.txtHH2KT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHH2KT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHH2KT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHH2KT.DisabledState.Parent = this.txtHH2KT;
            this.txtHH2KT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHH2KT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHH2KT.FocusedState.Parent = this.txtHH2KT;
            this.txtHH2KT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHH2KT.HoverState.Parent = this.txtHH2KT;
            this.txtHH2KT.Location = new System.Drawing.Point(466, 383);
            this.txtHH2KT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHH2KT.Name = "txtHH2KT";
            this.txtHH2KT.PasswordChar = '\0';
            this.txtHH2KT.PlaceholderText = "";
            this.txtHH2KT.SelectedText = "";
            this.txtHH2KT.ShadowDecoration.Parent = this.txtHH2KT;
            this.txtHH2KT.Size = new System.Drawing.Size(52, 44);
            this.txtHH2KT.TabIndex = 15;
            this.txtHH2KT.TextChanged += new System.EventHandler(this.txtHH2KT_TextChanged);
            // 
            // txtHP2BD
            // 
            this.txtHP2BD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHP2BD.DefaultText = "";
            this.txtHP2BD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHP2BD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHP2BD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHP2BD.DisabledState.Parent = this.txtHP2BD;
            this.txtHP2BD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHP2BD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHP2BD.FocusedState.Parent = this.txtHP2BD;
            this.txtHP2BD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHP2BD.HoverState.Parent = this.txtHP2BD;
            this.txtHP2BD.Location = new System.Drawing.Point(538, 331);
            this.txtHP2BD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHP2BD.Name = "txtHP2BD";
            this.txtHP2BD.PasswordChar = '\0';
            this.txtHP2BD.PlaceholderText = "";
            this.txtHP2BD.SelectedText = "";
            this.txtHP2BD.ShadowDecoration.Parent = this.txtHP2BD;
            this.txtHP2BD.Size = new System.Drawing.Size(52, 44);
            this.txtHP2BD.TabIndex = 14;
            this.txtHP2BD.TextChanged += new System.EventHandler(this.txtHP2BD_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(364, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Từ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHH2BD
            // 
            this.txtHH2BD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHH2BD.DefaultText = "";
            this.txtHH2BD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHH2BD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHH2BD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHH2BD.DisabledState.Parent = this.txtHH2BD;
            this.txtHH2BD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHH2BD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHH2BD.FocusedState.Parent = this.txtHH2BD;
            this.txtHH2BD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHH2BD.HoverState.Parent = this.txtHH2BD;
            this.txtHH2BD.Location = new System.Drawing.Point(466, 331);
            this.txtHH2BD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHH2BD.Name = "txtHH2BD";
            this.txtHH2BD.PasswordChar = '\0';
            this.txtHH2BD.PlaceholderText = "";
            this.txtHH2BD.SelectedText = "";
            this.txtHH2BD.ShadowDecoration.Parent = this.txtHH2BD;
            this.txtHH2BD.Size = new System.Drawing.Size(52, 44);
            this.txtHH2BD.TabIndex = 12;
            this.txtHH2BD.TextChanged += new System.EventHandler(this.txtHH2BD_TextChanged);
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
            this.btnLuu.Location = new System.Drawing.Point(798, 362);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(86, 77);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(613, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ca";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSoCa
            // 
            this.txtSoCa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoCa.DefaultText = "";
            this.txtSoCa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoCa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoCa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoCa.DisabledState.Parent = this.txtSoCa;
            this.txtSoCa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoCa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoCa.FocusedState.Parent = this.txtSoCa;
            this.txtSoCa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoCa.HoverState.Parent = this.txtSoCa;
            this.txtSoCa.Location = new System.Drawing.Point(715, 221);
            this.txtSoCa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoCa.Name = "txtSoCa";
            this.txtSoCa.PasswordChar = '\0';
            this.txtSoCa.PlaceholderText = "";
            this.txtSoCa.SelectedText = "";
            this.txtSoCa.ShadowDecoration.Parent = this.txtSoCa;
            this.txtSoCa.Size = new System.Drawing.Size(52, 44);
            this.txtSoCa.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(902, 102);
            this.label8.TabIndex = 21;
            this.label8.Text = "BẢNG CA";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClose.Location = new System.Drawing.Point(862, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 22;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(902, 457);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSoCa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtHP2KT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHH2KT);
            this.Controls.Add(this.txtHP2BD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHH2BD);
            this.Controls.Add(this.txtHP1KT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHH1KT);
            this.Controls.Add(this.txtHP1BD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHH1BD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTenCa);
            this.Controls.Add(this.dgvCa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCa";
            this.Text = "frmCa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCa;
        private Guna.UI2.WinForms.Guna2TextBox txtTenCa;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtHH1BD;
        private Guna.UI2.WinForms.Guna2TextBox txtHP1BD;
        private Guna.UI2.WinForms.Guna2TextBox txtHP1KT;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtHH1KT;
        private Guna.UI2.WinForms.Guna2TextBox txtHP2KT;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtHH2KT;
        private Guna.UI2.WinForms.Guna2TextBox txtHP2BD;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtHH2BD;
        private Guna.UI2.WinForms.Guna2CircleButton btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mota;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtSoCa;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
    }
}