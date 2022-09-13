namespace AppSach
{
    partial class frmDocBarCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocBarCode));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCamera = new Guna.UI2.WinForms.Guna2ComboBox();
            this.picCamera = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtBarCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnStart = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("UTM Cookies", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAMERA :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCamera
            // 
            this.cmbCamera.BackColor = System.Drawing.Color.Transparent;
            this.cmbCamera.BorderRadius = 16;
            this.cmbCamera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamera.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCamera.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCamera.FocusedState.Parent = this.cmbCamera;
            this.cmbCamera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCamera.HoverState.Parent = this.cmbCamera;
            this.cmbCamera.ItemHeight = 30;
            this.cmbCamera.ItemsAppearance.Parent = this.cmbCamera;
            this.cmbCamera.Location = new System.Drawing.Point(164, 42);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.ShadowDecoration.Parent = this.cmbCamera;
            this.cmbCamera.Size = new System.Drawing.Size(408, 36);
            this.cmbCamera.TabIndex = 1;
            // 
            // picCamera
            // 
            this.picCamera.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picCamera.Location = new System.Drawing.Point(49, 100);
            this.picCamera.Name = "picCamera";
            this.picCamera.ShadowDecoration.Parent = this.picCamera;
            this.picCamera.Size = new System.Drawing.Size(553, 501);
            this.picCamera.TabIndex = 2;
            this.picCamera.TabStop = false;
            // 
            // txtBarCode
            // 
            this.txtBarCode.BorderRadius = 16;
            this.txtBarCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarCode.DefaultText = "";
            this.txtBarCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBarCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBarCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarCode.DisabledState.Parent = this.txtBarCode;
            this.txtBarCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarCode.FocusedState.Parent = this.txtBarCode;
            this.txtBarCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarCode.HoverState.Parent = this.txtBarCode;
            this.txtBarCode.Location = new System.Drawing.Point(130, 637);
            this.txtBarCode.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.PasswordChar = '\0';
            this.txtBarCode.PlaceholderText = "";
            this.txtBarCode.SelectedText = "";
            this.txtBarCode.ShadowDecoration.Parent = this.txtBarCode;
            this.txtBarCode.Size = new System.Drawing.Size(353, 44);
            this.txtBarCode.TabIndex = 3;
            this.txtBarCode.TextChanged += new System.EventHandler(this.txtBarCode_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageRotate = 0F;
            this.btnStart.Location = new System.Drawing.Point(508, 630);
            this.btnStart.Name = "btnStart";
            this.btnStart.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStart.PressedState.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(64, 54);
            this.btnStart.TabIndex = 4;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("UTM Cookies", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 637);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "Barcode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnClose.Location = new System.Drawing.Point(623, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // frmDocBarCode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(667, 722);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.picCamera);
            this.Controls.Add(this.cmbCamera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDocBarCode";
            this.Text = "frmDocBarCode";
            this.Load += new System.EventHandler(this.frmDocBarCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCamera;
        private Guna.UI2.WinForms.Guna2PictureBox picCamera;
        private Guna.UI2.WinForms.Guna2TextBox txtBarCode;
        private Guna.UI2.WinForms.Guna2ImageButton btnStart;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}