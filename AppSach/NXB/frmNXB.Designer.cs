namespace AppSach
{
    partial class frmNXB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNXB));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvThongtinNXB = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colMaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lienhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvLSNXB = new System.Windows.Forms.DataGridView();
            this.btnRestore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colLSMaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLSTenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyXoa = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinNXB)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSNXB)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
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
            this.splitContainer1.Size = new System.Drawing.Size(1254, 486);
            this.splitContainer1.SplitterDistance = 855;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvThongtinNXB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 336);
            this.panel2.TabIndex = 1;
            // 
            // dgvThongtinNXB
            // 
            this.dgvThongtinNXB.AllowUserToAddRows = false;
            this.dgvThongtinNXB.AllowUserToDeleteRows = false;
            this.dgvThongtinNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongtinNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtinNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnXoa,
            this.colMaNXB,
            this.TenNXB,
            this.lienhe,
            this.diachi});
            this.dgvThongtinNXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongtinNXB.Location = new System.Drawing.Point(0, 0);
            this.dgvThongtinNXB.Name = "dgvThongtinNXB";
            this.dgvThongtinNXB.ReadOnly = true;
            this.dgvThongtinNXB.RowHeadersWidth = 51;
            this.dgvThongtinNXB.RowTemplate.Height = 24;
            this.dgvThongtinNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongtinNXB.Size = new System.Drawing.Size(855, 336);
            this.dgvThongtinNXB.TabIndex = 0;
            this.dgvThongtinNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongtinNXB_CellClick);
            this.dgvThongtinNXB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongtinNXB_CellDoubleClick);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnXoa.HeaderText = "";
            this.btnXoa.MinimumWidth = 6;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ReadOnly = true;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseColumnTextForButtonValue = true;
            this.btnXoa.Width = 6;
            // 
            // colMaNXB
            // 
            this.colMaNXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMaNXB.DataPropertyName = "MAnxb";
            this.colMaNXB.HeaderText = "Mã nhà xuất bản";
            this.colMaNXB.MinimumWidth = 6;
            this.colMaNXB.Name = "colMaNXB";
            this.colMaNXB.ReadOnly = true;
            this.colMaNXB.Width = 101;
            // 
            // TenNXB
            // 
            this.TenNXB.DataPropertyName = "TenNXB";
            this.TenNXB.HeaderText = "Tên nhà xuất bản";
            this.TenNXB.MinimumWidth = 6;
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.ReadOnly = true;
            // 
            // lienhe
            // 
            this.lienhe.DataPropertyName = "lienhe";
            this.lienhe.HeaderText = "Liên hệ";
            this.lienhe.MinimumWidth = 6;
            this.lienhe.Name = "lienhe";
            this.lienhe.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 150);
            this.panel1.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThem.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageRotate = 0F;
            this.btnThem.Location = new System.Drawing.Point(778, 74);
            this.btnThem.Name = "btnThem";
            this.btnThem.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThem.PressedState.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(70, 70);
            this.btnThem.TabIndex = 15;
            this.btnThem.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey.AutoRoundedCorners = true;
            this.txtKey.BorderRadius = 23;
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
            this.txtKey.Location = new System.Drawing.Point(208, 64);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '\0';
            this.txtKey.PlaceholderText = "";
            this.txtKey.SelectedText = "";
            this.txtKey.ShadowDecoration.Parent = this.txtKey;
            this.txtKey.Size = new System.Drawing.Size(387, 49);
            this.txtKey.TabIndex = 0;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvLSNXB);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 336);
            this.panel4.TabIndex = 1;
            // 
            // dgvLSNXB
            // 
            this.dgvLSNXB.AllowUserToAddRows = false;
            this.dgvLSNXB.AllowUserToDeleteRows = false;
            this.dgvLSNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLSNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLSNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnRestore,
            this.colLSMaNXB,
            this.colLSTenNXB});
            this.dgvLSNXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLSNXB.Location = new System.Drawing.Point(0, 0);
            this.dgvLSNXB.Name = "dgvLSNXB";
            this.dgvLSNXB.ReadOnly = true;
            this.dgvLSNXB.RowHeadersWidth = 51;
            this.dgvLSNXB.RowTemplate.Height = 24;
            this.dgvLSNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLSNXB.Size = new System.Drawing.Size(395, 336);
            this.dgvLSNXB.TabIndex = 0;
            this.dgvLSNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLSNXB_CellClick);
            // 
            // btnRestore
            // 
            this.btnRestore.HeaderText = "";
            this.btnRestore.MinimumWidth = 6;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ReadOnly = true;
            this.btnRestore.Text = "Lấy lại";
            this.btnRestore.UseColumnTextForButtonValue = true;
            // 
            // colLSMaNXB
            // 
            this.colLSMaNXB.DataPropertyName = "MaNXB";
            this.colLSMaNXB.HeaderText = "Mã NXB";
            this.colLSMaNXB.MinimumWidth = 6;
            this.colLSMaNXB.Name = "colLSMaNXB";
            this.colLSMaNXB.ReadOnly = true;
            // 
            // colLSTenNXB
            // 
            this.colLSTenNXB.DataPropertyName = "TenNXB";
            this.colLSTenNXB.HeaderText = "Tên NXB";
            this.colLSTenNXB.MinimumWidth = 6;
            this.colLSTenNXB.Name = "colLSTenNXB";
            this.colLSTenNXB.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtKeyXoa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 150);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "LỊCH SỬ XÓA NXB";
            // 
            // txtKeyXoa
            // 
            this.txtKeyXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyXoa.AutoRoundedCorners = true;
            this.txtKeyXoa.BorderRadius = 23;
            this.txtKeyXoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKeyXoa.DefaultText = "";
            this.txtKeyXoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKeyXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKeyXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKeyXoa.DisabledState.Parent = this.txtKeyXoa;
            this.txtKeyXoa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKeyXoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKeyXoa.FocusedState.Parent = this.txtKeyXoa;
            this.txtKeyXoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyXoa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKeyXoa.HoverState.Parent = this.txtKeyXoa;
            this.txtKeyXoa.Location = new System.Drawing.Point(111, 70);
            this.txtKeyXoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyXoa.Name = "txtKeyXoa";
            this.txtKeyXoa.PasswordChar = '\0';
            this.txtKeyXoa.PlaceholderText = "";
            this.txtKeyXoa.SelectedText = "";
            this.txtKeyXoa.ShadowDecoration.Parent = this.txtKeyXoa;
            this.txtKeyXoa.Size = new System.Drawing.Size(176, 49);
            this.txtKeyXoa.TabIndex = 1;
            this.txtKeyXoa.TextChanged += new System.EventHandler(this.txtKeyXoa_TextChanged);
            // 
            // frmNXB
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 486);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmNXB";
            this.Text = "NXB";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinNXB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSNXB)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtKey;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtKeyXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThongtinNXB;
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn lienhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridView dgvLSNXB;
        private System.Windows.Forms.DataGridViewButtonColumn btnRestore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLSMaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLSTenNXB;
        private Guna.UI2.WinForms.Guna2ImageButton btnThem;
    }
}