namespace AppSach
{
    partial class frmThemNXB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNXB));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHienthi = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtMaNXB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNXB = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLienhe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHienthi);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 90);
            this.panel1.TabIndex = 0;
            // 
            // lblHienthi
            // 
            this.lblHienthi.Font = new System.Drawing.Font("UTM Cookies", 16F);
            this.lblHienthi.Location = new System.Drawing.Point(165, 4);
            this.lblHienthi.Name = "lblHienthi";
            this.lblHienthi.Size = new System.Drawing.Size(230, 80);
            this.lblHienthi.TabIndex = 21;
            this.lblHienthi.Text = "THÊM NXB";
            this.lblHienthi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnClose.Location = new System.Drawing.Point(509, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.BorderRadius = 16;
            this.txtMaNXB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNXB.DefaultText = "";
            this.txtMaNXB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNXB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNXB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNXB.DisabledState.Parent = this.txtMaNXB;
            this.txtMaNXB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNXB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNXB.FocusedState.Parent = this.txtMaNXB;
            this.txtMaNXB.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.txtMaNXB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNXB.HoverState.Parent = this.txtMaNXB;
            this.txtMaNXB.Location = new System.Drawing.Point(188, 113);
            this.txtMaNXB.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.PasswordChar = '\0';
            this.txtMaNXB.PlaceholderText = "";
            this.txtMaNXB.SelectedText = "";
            this.txtMaNXB.ShadowDecoration.Parent = this.txtMaNXB;
            this.txtMaNXB.Size = new System.Drawing.Size(247, 40);
            this.txtMaNXB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Cookies", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã NXB";
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
            this.btnLuu.Location = new System.Drawing.Point(454, 355);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(86, 77);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Cookies", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên NXB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Cookies", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liên hệ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Cookies", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ";
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.BorderRadius = 16;
            this.txtTenNXB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNXB.DefaultText = "";
            this.txtTenNXB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNXB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNXB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNXB.DisabledState.Parent = this.txtTenNXB;
            this.txtTenNXB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNXB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNXB.FocusedState.Parent = this.txtTenNXB;
            this.txtTenNXB.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.txtTenNXB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNXB.HoverState.Parent = this.txtTenNXB;
            this.txtTenNXB.Location = new System.Drawing.Point(188, 173);
            this.txtTenNXB.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.PasswordChar = '\0';
            this.txtTenNXB.PlaceholderText = "";
            this.txtTenNXB.SelectedText = "";
            this.txtTenNXB.ShadowDecoration.Parent = this.txtTenNXB;
            this.txtTenNXB.Size = new System.Drawing.Size(247, 40);
            this.txtTenNXB.TabIndex = 7;
            this.txtTenNXB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNXB_KeyPress);
            // 
            // txtLienhe
            // 
            this.txtLienhe.BorderRadius = 16;
            this.txtLienhe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLienhe.DefaultText = "";
            this.txtLienhe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLienhe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLienhe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLienhe.DisabledState.Parent = this.txtLienhe;
            this.txtLienhe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLienhe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLienhe.FocusedState.Parent = this.txtLienhe;
            this.txtLienhe.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.txtLienhe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLienhe.HoverState.Parent = this.txtLienhe;
            this.txtLienhe.Location = new System.Drawing.Point(188, 227);
            this.txtLienhe.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtLienhe.Name = "txtLienhe";
            this.txtLienhe.PasswordChar = '\0';
            this.txtLienhe.PlaceholderText = "";
            this.txtLienhe.SelectedText = "";
            this.txtLienhe.ShadowDecoration.Parent = this.txtLienhe;
            this.txtLienhe.Size = new System.Drawing.Size(247, 40);
            this.txtLienhe.TabIndex = 8;
            this.txtLienhe.TextChanged += new System.EventHandler(this.txtLienhe_TextChanged);
            this.txtLienhe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KhongChoNhapChu);
            // 
            // txtDiachi
            // 
            this.txtDiachi.BorderRadius = 16;
            this.txtDiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiachi.DefaultText = "";
            this.txtDiachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachi.DisabledState.Parent = this.txtDiachi;
            this.txtDiachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachi.FocusedState.Parent = this.txtDiachi;
            this.txtDiachi.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.txtDiachi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachi.HoverState.Parent = this.txtDiachi;
            this.txtDiachi.Location = new System.Drawing.Point(187, 282);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.PasswordChar = '\0';
            this.txtDiachi.PlaceholderText = "";
            this.txtDiachi.SelectedText = "";
            this.txtDiachi.ShadowDecoration.Parent = this.txtDiachi;
            this.txtDiachi.Size = new System.Drawing.Size(247, 40);
            this.txtDiachi.TabIndex = 9;
            // 
            // frmThemNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 444);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtLienhe);
            this.Controls.Add(this.txtTenNXB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtMaNXB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("UTM Cookies", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmThemNXB";
            this.Text = "frmThemNXB";
            this.Load += new System.EventHandler(this.frmThemNXB_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNXB;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2CircleButton btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNXB;
        private Guna.UI2.WinForms.Guna2TextBox txtLienhe;
        private Guna.UI2.WinForms.Guna2TextBox txtDiachi;
        private System.Windows.Forms.Label lblHienthi;
    }
}