namespace AppSach
{
    partial class frmNgonNgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNgonNgu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnEN = new FontAwesome.Sharp.IconButton();
            this.btnVN = new FontAwesome.Sharp.IconButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnEN);
            this.panel1.Controls.Add(this.btnVN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 227);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(83, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(261, 41);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Vui lòng chọn ngôn ngữ:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
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
            this.btnClose.Location = new System.Drawing.Point(347, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnEN
            // 
            this.btnEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnEN.FlatAppearance.BorderSize = 0;
            this.btnEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEN.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.btnEN.ForeColor = System.Drawing.Color.White;
            this.btnEN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEN.IconColor = System.Drawing.Color.Black;
            this.btnEN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEN.Location = new System.Drawing.Point(77, 152);
            this.btnEN.Name = "btnEN";
            this.btnEN.Size = new System.Drawing.Size(211, 37);
            this.btnEN.TabIndex = 4;
            this.btnEN.Text = "English";
            this.btnEN.UseVisualStyleBackColor = false;
            this.btnEN.Click += new System.EventHandler(this.btnEN_Click_1);
            // 
            // btnVN
            // 
            this.btnVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.btnVN.FlatAppearance.BorderSize = 0;
            this.btnVN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVN.Font = new System.Drawing.Font("UTM Cookies", 10.2F);
            this.btnVN.ForeColor = System.Drawing.Color.White;
            this.btnVN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVN.IconColor = System.Drawing.Color.Black;
            this.btnVN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVN.Location = new System.Drawing.Point(77, 109);
            this.btnVN.Name = "btnVN";
            this.btnVN.Size = new System.Drawing.Size(211, 37);
            this.btnVN.TabIndex = 3;
            this.btnVN.Text = "Vietnamese";
            this.btnVN.UseVisualStyleBackColor = false;
            this.btnVN.Click += new System.EventHandler(this.btnVN_Click_1);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // frmNgonNgu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(382, 227);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNgonNgu";
            this.Text = "NGÔN NGỮ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNgonNgu_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private FontAwesome.Sharp.IconButton btnEN;
        private FontAwesome.Sharp.IconButton btnVN;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}