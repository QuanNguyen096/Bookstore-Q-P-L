namespace AppSach
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoad = new Guna.UI2.WinForms.Guna2Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBaoCaoDT = new System.Windows.Forms.DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnXuatBaoCao = new Guna.UI2.WinForms.Guna2Button();
            this.tabBaoCao = new System.Windows.Forms.TabControl();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvBaoCaoSP = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnXuatBaoCaoSP = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThucHien = new Guna.UI2.WinForms.Guna2Button();
            this.radBanChay = new System.Windows.Forms.RadioButton();
            this.radGanHet = new System.Windows.Forms.RadioButton();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoDT)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.tabBaoCao.SuspendLayout();
            this.tabDoanhThu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoSP)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.dtpDenNgay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpTuNgay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.BorderRadius = 18;
            this.btnLoad.CheckedState.Parent = this.btnLoad;
            this.btnLoad.CustomImages.Parent = this.btnLoad;
            this.btnLoad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.btnLoad.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.HoverState.Parent = this.btnLoad;
            this.btnLoad.Location = new System.Drawing.Point(699, 23);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ShadowDecoration.Parent = this.btnLoad;
            this.btnLoad.Size = new System.Drawing.Size(180, 45);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Thực hiện";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(452, 31);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 30);
            this.dtpDenNgay.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(356, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(124, 31);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 30);
            this.dtpTuNgay.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.panel2);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1240, 444);
            this.guna2Panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBaoCaoDT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1240, 358);
            this.panel2.TabIndex = 6;
            // 
            // dgvBaoCaoDT
            // 
            this.dgvBaoCaoDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCaoDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colTenNV,
            this.colSoLuong,
            this.colTongTien,
            this.colNgayLapHD});
            this.dgvBaoCaoDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCaoDT.Location = new System.Drawing.Point(0, 0);
            this.dgvBaoCaoDT.Name = "dgvBaoCaoDT";
            this.dgvBaoCaoDT.RowHeadersWidth = 51;
            this.dgvBaoCaoDT.RowTemplate.Height = 24;
            this.dgvBaoCaoDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCaoDT.Size = new System.Drawing.Size(1240, 358);
            this.dgvBaoCaoDT.TabIndex = 5;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.guna2Panel2.Controls.Add(this.btnXuatBaoCao);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(3, 363);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1240, 84);
            this.guna2Panel2.TabIndex = 7;
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.BorderRadius = 20;
            this.btnXuatBaoCao.CheckedState.Parent = this.btnXuatBaoCao;
            this.btnXuatBaoCao.CustomImages.Parent = this.btnXuatBaoCao;
            this.btnXuatBaoCao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.btnXuatBaoCao.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.btnXuatBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXuatBaoCao.HoverState.Parent = this.btnXuatBaoCao;
            this.btnXuatBaoCao.Location = new System.Drawing.Point(45, 20);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.ShadowDecoration.Parent = this.btnXuatBaoCao;
            this.btnXuatBaoCao.Size = new System.Drawing.Size(180, 45);
            this.btnXuatBaoCao.TabIndex = 0;
            this.btnXuatBaoCao.Text = "Xuất báo cáo";
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.Controls.Add(this.tabDoanhThu);
            this.tabBaoCao.Controls.Add(this.tabPage2);
            this.tabBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBaoCao.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.tabBaoCao.Location = new System.Drawing.Point(0, 0);
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.SelectedIndex = 0;
            this.tabBaoCao.Size = new System.Drawing.Size(1254, 486);
            this.tabBaoCao.TabIndex = 8;
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.Controls.Add(this.guna2Panel2);
            this.tabDoanhThu.Controls.Add(this.guna2Panel1);
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 32);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoanhThu.Size = new System.Drawing.Size(1246, 450);
            this.tabDoanhThu.TabIndex = 0;
            this.tabDoanhThu.Text = "Doanh Thu";
            this.tabDoanhThu.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1246, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sản phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvBaoCaoSP);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1240, 244);
            this.panel5.TabIndex = 2;
            // 
            // dgvBaoCaoSP
            // 
            this.dgvBaoCaoSP.AllowUserToAddRows = false;
            this.dgvBaoCaoSP.AllowUserToDeleteRows = false;
            this.dgvBaoCaoSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCaoSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCaoSP.Location = new System.Drawing.Point(0, 0);
            this.dgvBaoCaoSP.Name = "dgvBaoCaoSP";
            this.dgvBaoCaoSP.ReadOnly = true;
            this.dgvBaoCaoSP.RowHeadersWidth = 51;
            this.dgvBaoCaoSP.RowTemplate.Height = 24;
            this.dgvBaoCaoSP.Size = new System.Drawing.Size(1240, 244);
            this.dgvBaoCaoSP.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.panel4.Controls.Add(this.btnXuatBaoCaoSP);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 347);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1240, 100);
            this.panel4.TabIndex = 1;
            // 
            // btnXuatBaoCaoSP
            // 
            this.btnXuatBaoCaoSP.BorderRadius = 20;
            this.btnXuatBaoCaoSP.CheckedState.Parent = this.btnXuatBaoCaoSP;
            this.btnXuatBaoCaoSP.CustomImages.Parent = this.btnXuatBaoCaoSP;
            this.btnXuatBaoCaoSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.btnXuatBaoCaoSP.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.btnXuatBaoCaoSP.ForeColor = System.Drawing.Color.White;
            this.btnXuatBaoCaoSP.HoverState.Parent = this.btnXuatBaoCaoSP;
            this.btnXuatBaoCaoSP.Location = new System.Drawing.Point(25, 27);
            this.btnXuatBaoCaoSP.Name = "btnXuatBaoCaoSP";
            this.btnXuatBaoCaoSP.ShadowDecoration.Parent = this.btnXuatBaoCaoSP;
            this.btnXuatBaoCaoSP.Size = new System.Drawing.Size(180, 45);
            this.btnXuatBaoCaoSP.TabIndex = 1;
            this.btnXuatBaoCaoSP.Text = "Xuất báo cáo";
            this.btnXuatBaoCaoSP.Click += new System.EventHandler(this.btnXuatBaoCaoSP_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.panel3.Controls.Add(this.btnThucHien);
            this.panel3.Controls.Add(this.radBanChay);
            this.panel3.Controls.Add(this.radGanHet);
            this.panel3.Controls.Add(this.radTatCa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1240, 100);
            this.panel3.TabIndex = 0;
            // 
            // btnThucHien
            // 
            this.btnThucHien.BorderRadius = 20;
            this.btnThucHien.CheckedState.Parent = this.btnThucHien;
            this.btnThucHien.CustomImages.Parent = this.btnThucHien;
            this.btnThucHien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.btnThucHien.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.btnThucHien.ForeColor = System.Drawing.Color.White;
            this.btnThucHien.HoverState.Parent = this.btnThucHien;
            this.btnThucHien.Location = new System.Drawing.Point(662, 30);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.ShadowDecoration.Parent = this.btnThucHien;
            this.btnThucHien.Size = new System.Drawing.Size(180, 45);
            this.btnThucHien.TabIndex = 3;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // radBanChay
            // 
            this.radBanChay.AutoSize = true;
            this.radBanChay.Font = new System.Drawing.Font("UTM Cookies", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBanChay.ForeColor = System.Drawing.Color.White;
            this.radBanChay.Location = new System.Drawing.Point(197, 37);
            this.radBanChay.Name = "radBanChay";
            this.radBanChay.Size = new System.Drawing.Size(196, 27);
            this.radBanChay.TabIndex = 2;
            this.radBanChay.Text = "Sách bán chạy nhất";
            this.radBanChay.UseVisualStyleBackColor = true;
            // 
            // radGanHet
            // 
            this.radGanHet.AutoSize = true;
            this.radGanHet.Font = new System.Drawing.Font("UTM Cookies", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGanHet.ForeColor = System.Drawing.Color.White;
            this.radGanHet.Location = new System.Drawing.Point(438, 37);
            this.radGanHet.Name = "radGanHet";
            this.radGanHet.Size = new System.Drawing.Size(186, 27);
            this.radGanHet.TabIndex = 1;
            this.radGanHet.Text = "Sách gần hết hàng";
            this.radGanHet.UseVisualStyleBackColor = true;
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Checked = true;
            this.radTatCa.Font = new System.Drawing.Font("UTM Cookies", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTatCa.ForeColor = System.Drawing.Color.White;
            this.radTatCa.Location = new System.Drawing.Point(25, 37);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(131, 27);
            this.radTatCa.TabIndex = 0;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả Sách";
            this.radTatCa.UseVisualStyleBackColor = true;
            // 
            // colMaHD
            // 
            this.colMaHD.DataPropertyName = "MaHD";
            this.colMaHD.HeaderText = "Mã HD";
            this.colMaHD.MinimumWidth = 6;
            this.colMaHD.Name = "colMaHD";
            // 
            // colTenNV
            // 
            this.colTenNV.DataPropertyName = "HoTen";
            this.colTenNV.HeaderText = "Tên Nhân Viên";
            this.colTenNV.MinimumWidth = 6;
            this.colTenNV.Name = "colTenNV";
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colTongTien
            // 
            this.colTongTien.DataPropertyName = "TongTien";
            this.colTongTien.HeaderText = "Tổng Tiền";
            this.colTongTien.MinimumWidth = 6;
            this.colTongTien.Name = "colTongTien";
            // 
            // colNgayLapHD
            // 
            this.colNgayLapHD.DataPropertyName = "NgayLapHD";
            this.colNgayLapHD.HeaderText = "Ngày Lập HD";
            this.colNgayLapHD.MinimumWidth = 6;
            this.colNgayLapHD.Name = "colNgayLapHD";
            // 
            // frmThongKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(1254, 486);
            this.Controls.Add(this.tabBaoCao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongKe";
            this.Text = "BÁO CÁO THỐNG KÊ";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoDT)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.tabBaoCao.ResumeLayout(false);
            this.tabDoanhThu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoSP)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnXuatBaoCao;
        private Guna.UI2.WinForms.Guna2Button btnLoad;
        private System.Windows.Forms.DataGridView dgvBaoCaoDT;
        private System.Windows.Forms.TabControl tabBaoCao;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvBaoCaoSP;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnXuatBaoCaoSP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radBanChay;
        private System.Windows.Forms.RadioButton radGanHet;
        private System.Windows.Forms.RadioButton radTatCa;
        private Guna.UI2.WinForms.Guna2Button btnThucHien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLapHD;
    }
}