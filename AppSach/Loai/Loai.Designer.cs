namespace AppSach.Loai
{
    partial class Loai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loai));
            this.txtKeyXoa = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.colLayLai = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colLsTenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLsMaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLsLoai = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvLoai = new System.Windows.Forms.DataGridView();
            this.colMaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemSP = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLsLoai)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.txtKeyXoa.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtKeyXoa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKeyXoa.HoverState.Parent = this.txtKeyXoa;
            this.txtKeyXoa.Location = new System.Drawing.Point(126, 73);
            this.txtKeyXoa.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtKeyXoa.Name = "txtKeyXoa";
            this.txtKeyXoa.PasswordChar = '\0';
            this.txtKeyXoa.PlaceholderText = "";
            this.txtKeyXoa.SelectedText = "";
            this.txtKeyXoa.ShadowDecoration.Parent = this.txtKeyXoa;
            this.txtKeyXoa.Size = new System.Drawing.Size(130, 49);
            this.txtKeyXoa.TabIndex = 2;
            this.txtKeyXoa.TextChanged += new System.EventHandler(this.txtKeyXoa_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtKeyXoa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 150);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "LỊCH SỬ XÓA LOẠI";
            // 
            // colLayLai
            // 
            this.colLayLai.HeaderText = "Lấy lại";
            this.colLayLai.MinimumWidth = 6;
            this.colLayLai.Name = "colLayLai";
            this.colLayLai.ReadOnly = true;
            this.colLayLai.Text = "Lấy lại";
            this.colLayLai.UseColumnTextForButtonValue = true;
            // 
            // colLsTenLoai
            // 
            this.colLsTenLoai.DataPropertyName = "TenLoai";
            this.colLsTenLoai.HeaderText = "Tên loại";
            this.colLsTenLoai.MinimumWidth = 6;
            this.colLsTenLoai.Name = "colLsTenLoai";
            this.colLsTenLoai.ReadOnly = true;
            // 
            // colLsMaLoai
            // 
            this.colLsMaLoai.DataPropertyName = "MaLoai";
            this.colLsMaLoai.HeaderText = "Mã loại";
            this.colLsMaLoai.MinimumWidth = 6;
            this.colLsMaLoai.Name = "colLsMaLoai";
            this.colLsMaLoai.ReadOnly = true;
            // 
            // dgvLsLoai
            // 
            this.dgvLsLoai.AllowUserToAddRows = false;
            this.dgvLsLoai.AllowUserToDeleteRows = false;
            this.dgvLsLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLsLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLsLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLsMaLoai,
            this.colLsTenLoai,
            this.colLayLai});
            this.dgvLsLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLsLoai.Location = new System.Drawing.Point(0, 0);
            this.dgvLsLoai.Name = "dgvLsLoai";
            this.dgvLsLoai.ReadOnly = true;
            this.dgvLsLoai.RowHeadersWidth = 51;
            this.dgvLsLoai.RowTemplate.Height = 24;
            this.dgvLsLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLsLoai.Size = new System.Drawing.Size(379, 336);
            this.dgvLsLoai.TabIndex = 0;
            this.dgvLsLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLsLoai_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvLsLoai);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(379, 336);
            this.panel4.TabIndex = 1;
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
            this.txtKey.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey.HoverState.Parent = this.txtKey;
            this.txtKey.Location = new System.Drawing.Point(242, 49);
            this.txtKey.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '\0';
            this.txtKey.PlaceholderText = "";
            this.txtKey.SelectedText = "";
            this.txtKey.ShadowDecoration.Parent = this.txtKey;
            this.txtKey.Size = new System.Drawing.Size(380, 49);
            this.txtKey.TabIndex = 0;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // dgvLoai
            // 
            this.dgvLoai.AllowUserToAddRows = false;
            this.dgvLoai.AllowUserToDeleteRows = false;
            this.dgvLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLoai,
            this.tenloai,
            this.colXoa});
            this.dgvLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoai.Location = new System.Drawing.Point(0, 0);
            this.dgvLoai.Name = "dgvLoai";
            this.dgvLoai.ReadOnly = true;
            this.dgvLoai.RowHeadersWidth = 51;
            this.dgvLoai.RowTemplate.Height = 24;
            this.dgvLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoai.Size = new System.Drawing.Size(871, 336);
            this.dgvLoai.TabIndex = 0;
            this.dgvLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoai_CellClick);
            this.dgvLoai.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoai_CellDoubleClick);
            // 
            // colMaLoai
            // 
            this.colMaLoai.DataPropertyName = "MaLoai";
            this.colMaLoai.HeaderText = "Mã loại";
            this.colMaLoai.MinimumWidth = 6;
            this.colMaLoai.Name = "colMaLoai";
            this.colMaLoai.ReadOnly = true;
            this.colMaLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tenloai
            // 
            this.tenloai.DataPropertyName = "tenloai";
            this.tenloai.HeaderText = "Tên loại";
            this.tenloai.MinimumWidth = 6;
            this.tenloai.Name = "tenloai";
            this.tenloai.ReadOnly = true;
            this.tenloai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tenloai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colXoa
            // 
            this.colXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colXoa.HeaderText = "";
            this.colXoa.MinimumWidth = 6;
            this.colXoa.Name = "colXoa";
            this.colXoa.ReadOnly = true;
            this.colXoa.Text = "Xóa";
            this.colXoa.UseColumnTextForButtonValue = true;
            this.colXoa.Width = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvLoai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 336);
            this.panel2.TabIndex = 1;
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
            this.splitContainer1.SplitterDistance = 871;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnThemSP);
            this.panel1.Controls.Add(this.txtKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 150);
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
            this.btnThemSP.Location = new System.Drawing.Point(792, 72);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThemSP.PressedState.Parent = this.btnThemSP;
            this.btnThemSP.Size = new System.Drawing.Size(70, 70);
            this.btnThemSP.TabIndex = 14;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // Loai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 486);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Loai";
            this.Text = "Loai";
            this.Load += new System.EventHandler(this.Loai_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLsLoai)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).EndInit();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtKeyXoa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn colLayLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLsTenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLsMaLoai;
        private System.Windows.Forms.DataGridView dgvLsLoai;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox txtKey;
        private System.Windows.Forms.DataGridView dgvLoai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloai;
        private System.Windows.Forms.DataGridViewButtonColumn colXoa;
        private Guna.UI2.WinForms.Guna2ImageButton btnThemSP;
    }
}