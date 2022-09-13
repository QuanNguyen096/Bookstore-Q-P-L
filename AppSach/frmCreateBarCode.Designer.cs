namespace AppSach
{
    partial class frmCreateBarCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateBarCode));
            this.picQR = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnQR = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnBarCode = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBar)).BeginInit();
            this.SuspendLayout();
            // 
            // picQR
            // 
            this.picQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picQR.Location = new System.Drawing.Point(36, 46);
            this.picQR.Name = "picQR";
            this.picQR.ShadowDecoration.Parent = this.picQR;
            this.picQR.Size = new System.Drawing.Size(400, 400);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQR.TabIndex = 0;
            this.picQR.TabStop = false;
            // 
            // picBar
            // 
            this.picBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picBar.Location = new System.Drawing.Point(510, 46);
            this.picBar.Name = "picBar";
            this.picBar.ShadowDecoration.Parent = this.picBar;
            this.picBar.Size = new System.Drawing.Size(400, 200);
            this.picBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBar.TabIndex = 1;
            this.picBar.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.BorderRadius = 20;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.Parent = this.txtID;
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.FocusedState.Parent = this.txtID;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.HoverState.Parent = this.txtID;
            this.txtID.Location = new System.Drawing.Point(510, 305);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.ShadowDecoration.Parent = this.txtID;
            this.txtID.Size = new System.Drawing.Size(400, 44);
            this.txtID.TabIndex = 2;
            // 
            // btnQR
            // 
            this.btnQR.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnQR.CheckedState.Parent = this.btnQR;
            this.btnQR.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnQR.HoverState.Parent = this.btnQR;
            this.btnQR.Image = ((System.Drawing.Image)(resources.GetObject("btnQR.Image")));
            this.btnQR.ImageRotate = 0F;
            this.btnQR.Location = new System.Drawing.Point(510, 392);
            this.btnQR.Name = "btnQR";
            this.btnQR.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnQR.PressedState.Parent = this.btnQR;
            this.btnQR.Size = new System.Drawing.Size(64, 54);
            this.btnQR.TabIndex = 3;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // btnBarCode
            // 
            this.btnBarCode.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBarCode.CheckedState.Parent = this.btnBarCode;
            this.btnBarCode.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBarCode.HoverState.Parent = this.btnBarCode;
            this.btnBarCode.Image = ((System.Drawing.Image)(resources.GetObject("btnBarCode.Image")));
            this.btnBarCode.ImageRotate = 0F;
            this.btnBarCode.Location = new System.Drawing.Point(601, 392);
            this.btnBarCode.Name = "btnBarCode";
            this.btnBarCode.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBarCode.PressedState.Parent = this.btnBarCode;
            this.btnBarCode.Size = new System.Drawing.Size(64, 54);
            this.btnBarCode.TabIndex = 4;
            this.btnBarCode.Click += new System.EventHandler(this.btnBarCode_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.picQR;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            this.guna2Elipse3.TargetControl = this.picBar;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageRotate = 0F;
            this.btnClose.Location = new System.Drawing.Point(846, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(64, 54);
            this.btnClose.TabIndex = 5;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // frmCreateBarCode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(954, 502);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBarCode);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.picBar);
            this.Controls.Add(this.picQR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateBarCode";
            this.Text = "frmCreateBarCode";
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picQR;
        private Guna.UI2.WinForms.Guna2PictureBox picBar;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2ImageButton btnQR;
        private Guna.UI2.WinForms.Guna2ImageButton btnBarCode;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}