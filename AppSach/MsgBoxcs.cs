using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace AppSach
{
    public partial class MsgBoxcs : Form
    {
        public MsgBoxcs()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            #region Triển khai cunstructor
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = Color.FromArgb(192, 255, 192);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Width = 400;

            // Header
            _lblTitle = new Label();
            _lblTitle.ForeColor = Color.Black;
            _lblTitle.Font = new System.Drawing.Font("Segoe UI", 20, FontStyle.Bold);
            _lblTitle.Dock = DockStyle.Top;
            _lblTitle.Height = 60;

            // Thông điệp
            _lblMessage = new Label();
            _lblMessage.ForeColor = Color.Black;
            _lblMessage.Font = new System.Drawing.Font("Segoe UI", 10);
            _lblMessage.Dock = DockStyle.Fill;

            _flpButtons.FlowDirection = FlowDirection.LeftToRight;
            _flpButtons.Dock = DockStyle.Fill;
            _flpButtons.Padding = new Padding(5);

            _plHeader.Dock = DockStyle.Fill;
            _plHeader.Padding = new Padding(20);
            _plHeader.Controls.Add(_lblMessage);
            _plHeader.Controls.Add(_lblTitle);

            _plFooter.Dock = DockStyle.Bottom;
            _plFooter.Padding = new Padding(20);
            _plFooter.BackColor = Color.FromArgb(70, 77, 70);
            _plFooter.Height = 80;
            _plFooter.Controls.Add(_flpButtons);

            _picIcon.Width = 32;
            _picIcon.Height = 32;
            _picIcon.Location = new Point(30, 50);
            _picIcon.SizeMode = PictureBoxSizeMode.StretchImage;

            _plIcon.Dock = DockStyle.Left;
            _plIcon.Padding = new Padding(20);
            _plIcon.Width = 70;
            _plIcon.Controls.Add(_picIcon);

            // Add controls vào form
            this.Controls.Add(_plHeader);
            this.Controls.Add(_plIcon);
            this.Controls.Add(_plFooter);
            #endregion
        }
        #region Buttons,icon,showMessage
        // Các button sẽ hiển thị lên Msg
        public enum Buttons
        {
            OK = 1,
            OKCancel = 2,
            YesNo = 3,
            YesNoCancel = 4
        }

        // Các icon thể hiện nội dung của Msg
        public enum Icon
        {
            Error = 1,
            Warning = 2,
            Info = 3,
            Question = 4,
        }
        // Hiệu ứng Show Msg
        public enum AnimateStyle
        {
            SlideDown = 1,
            FadeIn = 2,
            ZoomIn = 3
        }
        #endregion

        #region Hiệu ứng và kích thước
        class AnimateMsgBox
        {
            public Size FormSize;
            public MsgBoxcs.AnimateStyle Style;

            public AnimateMsgBox(Size formSize, MsgBoxcs.AnimateStyle style)
            {
                this.FormSize = formSize;
                this.Style = style;
            }
        }
        #endregion

        #region thực thi form
        // Bóng đổ
        private const int CS_DROPSHADOW = 0x00020000;

        private static MsgBoxcs _msgBox;

        // Header, Footer và Icon
        private Panel _plHeader = new Panel();
        private Label _lblTitle = new Label();
        private Panel _plFooter = new Panel();
        private Panel _plIcon = new Panel();
        private PictureBox _picIcon = new PictureBox();

        // THông điệp
        private Label _lblMessage = new Label();

        // Panel
        private FlowLayoutPanel _flpButtons = new FlowLayoutPanel();

        // List các button
        private List<Guna2Button> _buttonCollection = new List<Guna2Button>();

        // Kết quả
        private static DialogResult _buttonResult = new DialogResult();

        //Timer hiệu ứng
        private static Timer _timer;
        #endregion

        # region Triển khai xử lý event và init Button, Icon

        private static void InitButtons(Buttons buttons)
        {
            switch (buttons)
            {

                case MsgBoxcs.Buttons.OK:
                    _msgBox.InitOKButton();
                    break;

                case MsgBoxcs.Buttons.OKCancel:
                    _msgBox.InitOKCancelButtons();
                    break;

                case MsgBoxcs.Buttons.YesNo:
                    _msgBox.InitYesNoButtons();
                    break;

                case MsgBoxcs.Buttons.YesNoCancel:
                    _msgBox.InitYesNoCancelButtons();
                    break;
            }

            foreach (Guna2Button btn in _msgBox._buttonCollection)
            {
                btn.ForeColor = Color.FromArgb(98, 210, 76);
                btn.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
                btn.Width = 100;
                btn.Height = 30;
                btn.BorderRadius = 10;
                btn.BorderColor = Color.FromArgb(0, 0, 0);
                _msgBox._flpButtons.Controls.Add(btn);
            }
        }

        private static void InitIcon(Icon icon)
        {
            switch (icon)
            {
                case MsgBoxcs.Icon.Error:
                    _msgBox._picIcon.Image = Image.FromFile("F:\\_DoAn\\AppSach\\Image\\icons8-error-48.png");

                    break;

                case MsgBoxcs.Icon.Info:
                    _msgBox._picIcon.Image = Image.FromFile("F:\\_DoAn\\AppSach\\Image\\icons8-information-48.png");
                    break;

                case MsgBoxcs.Icon.Question:
                    _msgBox._picIcon.Image = Image.FromFile("F:\\_DoAn\\AppSach\\Image\\icons8-question-mark-64.png");
                    break;

                case MsgBoxcs.Icon.Warning:
                    _msgBox._picIcon.Image = Image.FromFile("F:\\_DoAn\\AppSach\\Image\\icons8-error-48.png");
                    break;
            }
        }

        private void InitOKButton()
        {
            Guna2Button btnOK = new Guna2Button();
            btnOK.Text = "OK";
            btnOK.Click += ButtonClick;

            this._buttonCollection.Add(btnOK);
        }

        private void InitOKCancelButtons()
        {
            Guna2Button btnOK = new Guna2Button();
            btnOK.Text = "OK";
            btnOK.Click += ButtonClick;

            Guna2Button btnCancel = new Guna2Button();
            btnCancel.Text = "Cancel";
            btnCancel.Click += ButtonClick;

            this._buttonCollection.Add(btnOK);
            this._buttonCollection.Add(btnCancel);
        }

        private void InitYesNoButtons()
        {
            Guna2Button btnYes = new Guna2Button();
            btnYes.Text = "Yes";
            btnYes.Click += ButtonClick;

            Guna2Button btnNo = new Guna2Button();
            btnNo.Text = "No";
            btnNo.Click += ButtonClick;

            this._buttonCollection.Add(btnYes);
            this._buttonCollection.Add(btnNo);
        }

        private void InitYesNoCancelButtons()
        {
            Guna2Button btnYes = new Guna2Button();
            btnYes.Text = "Abort";
            btnYes.Click += ButtonClick;

            Guna2Button btnNo = new Guna2Button();
            btnNo.Text = "Retry";
            btnNo.Click += ButtonClick;

            Guna2Button btnCancel = new Guna2Button();
            btnCancel.Text = "Cancel";
            btnCancel.Click += ButtonClick;

            this._buttonCollection.Add(btnYes);
            this._buttonCollection.Add(btnNo);
            this._buttonCollection.Add(btnCancel);
        }

        private static void ButtonClick(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;

            switch (btn.Text)
            {

                case "OK":
                    _buttonResult = DialogResult.OK;
                    break;

                case "Cancel":
                    _buttonResult = DialogResult.Cancel;
                    break;

                case "Yes":
                    _buttonResult = DialogResult.Yes;
                    break;

                case "No":
                    _buttonResult = DialogResult.No;
                    break;
            }

            _msgBox.Dispose();
        }

        private static Size MessageSize(string message)
        {
            Graphics g = _msgBox.CreateGraphics();
            int width = 350;
            int height = 230;

            SizeF size = g.MeasureString(message, new System.Drawing.Font("Segoe UI", 10));

            if (message.Length < 150)
            {
                if ((int)size.Width > 350)
                {
                    width = (int)size.Width;
                }
            }
            else
            {
                string[] groups = (from Match m in Regex.Matches(message, ".{1,180}") select m.Value).ToArray();
                int lines = groups.Length + 1;
                width = 700;
                height += (int)(size.Height + 10) * lines;
            }
            return new Size(width, height);
        }
        #endregion

        #region Override hai hàm tạo form
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
            Pen pen = new Pen(Color.FromArgb(0, 151, 251));

            g.DrawRectangle(pen, rect);
        }
        #endregion

        #region Hiệu ứng của form sẽ được một Timer xử lý
        static void timer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            AnimateMsgBox animate = (AnimateMsgBox)timer.Tag;

            switch (animate.Style)
            {
                case MsgBoxcs.AnimateStyle.SlideDown:
                    if (_msgBox.Height < animate.FormSize.Height)
                    {
                        _msgBox.Height += 17;
                        _msgBox.Invalidate();
                    }
                    else
                    {
                        _timer.Stop();
                        _timer.Dispose();
                    }
                    break;

                case MsgBoxcs.AnimateStyle.FadeIn:
                    if (_msgBox.Opacity < 1)
                    {
                        _msgBox.Opacity += 0.1;
                        _msgBox.Invalidate();
                    }
                    else
                    {
                        _timer.Stop();
                        _timer.Dispose();
                    }
                    break;

                case MsgBoxcs.AnimateStyle.ZoomIn:
                    if (_msgBox.Width > animate.FormSize.Width)
                    {
                        _msgBox.Width -= 17;
                        _msgBox.Invalidate();
                    }
                    if (_msgBox.Height > animate.FormSize.Height)
                    {
                        _msgBox.Height -= 17;
                        _msgBox.Invalidate();
                    }
                    break;
            }
        }
        #endregion

        #region code show form
        public static void Show(string message)
        {
            _msgBox = new MsgBoxcs();
            _msgBox._lblMessage.Text = message;
            _msgBox.ShowDialog();
        }

        public static void Show(string message, string title)
        {
            _msgBox = new MsgBoxcs();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;
            _msgBox.Size = MsgBoxcs.MessageSize(message);
            _msgBox.ShowDialog();
        }

        public static DialogResult Show(string message, string title, Buttons buttons)
        {
            _msgBox = new MsgBoxcs();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;
            _msgBox._plIcon.Hide();

            MsgBoxcs.InitButtons(buttons);

            _msgBox.Size = MsgBoxcs.MessageSize(message);
            _msgBox.ShowDialog();
            return _buttonResult;
        }

        public static DialogResult Show(string message, string title, Buttons buttons, Icon icon)
        {
            _msgBox = new MsgBoxcs();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;

            MsgBoxcs.InitButtons(buttons);
            MsgBoxcs.InitIcon(icon);

            _msgBox.Size = MsgBoxcs.MessageSize(message);
            _msgBox.ShowDialog();
            return _buttonResult;
        }

        public static DialogResult Show(string message, string title, Buttons buttons, Icon icon, AnimateStyle style)
        {
            _msgBox = new MsgBoxcs();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;
            _msgBox.Height = 0;

            MsgBoxcs.InitButtons(buttons);
            MsgBoxcs.InitIcon(icon);

            _timer = new Timer();
            Size formSize = MsgBoxcs.MessageSize(message);

            switch (style)
            {
                case MsgBoxcs.AnimateStyle.SlideDown:
                    _msgBox.Size = new Size(formSize.Width, 0);
                    _timer.Interval = 1;
                    _timer.Tag = new AnimateMsgBox(formSize, style);
                    break;

                case MsgBoxcs.AnimateStyle.FadeIn:
                    _msgBox.Size = formSize;
                    _msgBox.Opacity = 0;
                    _timer.Interval = 20;
                    _timer.Tag = new AnimateMsgBox(formSize, style);
                    break;

                case MsgBoxcs.AnimateStyle.ZoomIn:
                    _msgBox.Size = new Size(formSize.Width + 100, formSize.Height + 100);
                    _timer.Tag = new AnimateMsgBox(formSize, style);
                    _timer.Interval = 1;
                    break;
            }

            _timer.Tick += timer_Tick;
            _timer.Start();
            _msgBox.ShowDialog();
            return _buttonResult;
        }
        #endregion

        private void frmMsg_Load(object sender, EventArgs e)
        {

        }
    }
}
