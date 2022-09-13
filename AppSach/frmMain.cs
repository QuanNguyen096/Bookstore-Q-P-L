using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUSS;
namespace AppSach
{
    public partial class frmMain : Form
    {
        
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private bool isKT = true;
        private Color GreenColor = Color.FromArgb(33, 115, 70);
        private Color ColorOrgane = Color.FromArgb(20, 178, 102);
        private Color ColorGreenNhac = Color.FromArgb(0, 252, 208);
        private int isclick = 0;
        private int VNorEN =0;
        private int VnEn;
        private string TK;
        private string ChucVu;
        private string ID;
        private string Ten;

       // string TK,int VnEn,string ChucVu
        public frmMain()
        {
            WindowState = FormWindowState.Maximized;
            NgonNgu();
            var KT_NN = new NgonNguBUSS().KTNN("1");
            STATUS = KT_NN["TrangThai"].ToString();
            if (int.Parse(STATUS) == 1)
            {
                VnEn = 1;
            }
            else
            {
                VnEn = 2;
            }

            InitializeComponent();
            XL_Login();////////////////////////////---------------------
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.StartPosition = FormStartPosition.CenterScreen;
            timerDH.Start();
            XoaHTHAN();
            VietNam_Anh();
        }

        private void XoaHTHAN()
        {
            int dd = DateTime.Now.Day;
            int MM = DateTime.Now.Month;
            int yyyy = DateTime.Now.Year;
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter()
            {
                Key = "@Key",
                Value = yyyy + "-" + MM + "-" + dd
            });
            //  MessageBox.Show(yyyy + "-" + MM + "-" + dd);
            new ChucNangXoa().XoaKMBUSS(pr);
            new ChucNangXoa().XoaNVBuss(pr);
            new ChucNangXoa().XoaSachBuss();
            new DiemDanhBUS().ReseetDDD("");
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color, int i)
        {

            isclick = 1;
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconCurrentChildForm.BackgroundImage = imageList2.Images[i];

                //iconCurrentChildForm.IconColor = color;

                this.btnNhanVien.ImageIndex = 0;
                this.btnNhanVien.ImageList = this.imageList2;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = GreenColor;//---------------------------------------- ==>> Màu button của menu
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Reset()
        {
            isclick = 0;
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.BackgroundImage = imageList2.Images[6];
            iconCurrentChildForm.IconColor = ColorGreenNhac;//---------------------------------------------==> Color Icon Click
            OpenChildForm(new frmThongKe());
        }

        //Events
        //Reset
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe());
        }


        #region Button Down
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColorGreenNhac, btnNhanVien.ImageIndex);
            OpenChildForm(new frmNhanVien(int.Parse(STATUS), ID));
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColorGreenNhac, btnSanPham.ImageIndex);
            mnuSP.Show(btnSanPham, btnSanPham.Width, 0);
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColorGreenNhac, btnThongTin.ImageIndex);
            mnuThongTin.Show(btnThongTin, btnThongTin.Width, 0);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColorGreenNhac, btnKhachHang.ImageIndex);
            OpenChildForm(new frmKhachHang());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColorGreenNhac, btnHoaDon.ImageIndex);
            OpenChildForm(new frmHoaDon(ID));

        }


        #endregion

        #region nut close
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dialogResult = MsgBoxcs.Show("Bạn chắc chắn muốn thoát chương trình không", Constant.THONGBAO, MsgBoxcs.Buttons.YesNo, MsgBoxcs.Icon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
                //Application.Exit();

            //}

            //else
            //{
            //}
        }
        #endregion nut close

        #region nut facebook
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com/tranthoilong");
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            linkLabel1_LinkClicked(sender, null);
        }
        #endregion nut facebook

        #region Login
        string STATUS;
        private void NgonNgu()
        {
            var KT_NN = new NgonNguBUSS().KTNN("1");
            if (KT_NN == null)
            {
                new frmNgonNgu().ShowDialog();
            }
            return;
        }
        private void ChuaCoTaiKhoanNaoDuocLuu()
        {
            frmLogin frm = new frmLogin(STATUS);
            frm.ShowDialog();
            ID = frm.ID;
            if (frm.ChucVu.ToUpper() != Constant.ADMIN.ToUpper())
            {
                btnNhanVien.Visible = false;
            }
            else
            {
                btnNhanVien.Visible = true;

            }
            lblCV.Text = frm.ChucVu;
            lblNameNV.Text = frm.HoVaTen;
            try
            {
                picAvatar.Image = Image.FromFile(frm.Anh);

            }
            catch (Exception ex)
            {
                picAvatar.Image = null;
            }
        }
        private void CoTaiKhoanDuocLuu()
        {
            var r = new Login().TimNVLogin_2();
             ID=r["ID"].ToString();
            if (r["ChucVu"].ToString().ToUpper() != Constant.ADMIN.ToUpper())
            {
                btnNhanVien.Visible = false;
            }
            else
            {
                btnNhanVien.Visible = true;

            }
            lblCV.Text = r["ChucVu"].ToString();
            
            lblNameNV.Text = r["HoVaTen"].ToString();
            Ten = r["HoVaTen"].ToString();

            try
            {
                picAvatar.Image = Image.FromFile(r["Anh"].ToString());

            }
            catch (Exception ex)
            {
                picAvatar.Image = null;
            }
        }
        private void XL_Login()
        {
            //var KT_NN = new NgonNguBUSS().KTNN("1");
            //STATUS = KT_NN["TrangThai"].ToString();
            //Sau khi thuc hien truy van ngon ngu lay ra gia tri 1 vn 2 la english

            // neu chua dang xuat thi lay du lieu tu database thay the
            // con da dang xuat thi xuat hien form login

            var saveLogin = new Login().TimNVLogin();
            if(saveLogin != null)
            {
                //MessageBox.Show("Da dang xuat");
                ChuaCoTaiKhoanNaoDuocLuu();//Data => id =0
            }
            else
            {
                //MessageBox.Show("Chua Dang xuat");
                CoTaiKhoanDuocLuu();//truy xuat theo IDKey
            }
        }
        #endregion Login
        #region Chuyen doi ngon ngu
        public ResourceManager rm;
        string VN_EN = string.Empty;
        private void VietNam_Anh()
        {
            if (VnEn == 1)
            {
                VN_EN = "AppSach.Resource.VN";
            }
            else
            {
                VN_EN = "AppSach.Resource.EN";

            }
            rm = new ResourceManager(VN_EN, Assembly.GetExecutingAssembly());
            btnNhanVien.Text = rm.GetString("nhanvien").ToUpper();
            btnHoaDon.Text = rm.GetString("hoadon").ToUpper();
            btnKhachHang.Text = rm.GetString("khachhang").ToUpper();
            btnSanPham.Text = rm.GetString("sanpham").ToUpper();
            btnThongTin.Text = rm.GetString("more").ToUpper();
            lblChuyendoi.Text = rm.GetString("chuyendoitaikhoan").ToUpper();
            guna2HtmlToolTip1.SetToolTip(linkLabel1, rm.GetString("linkfb")); 
            guna2HtmlToolTip1.SetToolTip(guna2ImageButton1, rm.GetString("linkfb")); 
            guna2HtmlToolTip1.SetToolTip(btnLogout, rm.GetString("chuyendoitaikhoan").ToUpper());
            guna2HtmlToolTip1.SetToolTip(picAvatar, rm.GetString("trangcanhan").ToUpper());
            guna2HtmlToolTip1.SetToolTip(btnHome, rm.GetString("trangchu").ToUpper());
            mnuThongTin.Items[0].Text = rm.GetString("btnLoai").ToUpper();
            mnuThongTin.Items[1].Text = rm.GetString("btnNXB").ToUpper();
            mnuThongTin.Items[2].Text = rm.GetString("receipt").ToUpper();
            mnuSP.Items[0].Text = rm.GetString("btnSach").ToUpper();
            mnuSP.Items[1].Text = rm.GetString("btnLSSach").ToUpper();
        }
        #endregion Chuyen doi ngon ngu
        private void mnuSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanPham());
        }
        private void mnuLSXoaSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLsXoaSach());

        }
        private void mnuNCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNXB());
        }
        private void mnLoai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Loai.Loai());
        }

        private void mnuTaoHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon(ID));
        }

        private void mnuNhapHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhapHang(ID, Ten,lblCV.Text));

        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            new frmDoiMatKhau(ID).ShowDialog();
        }
        private void timerDH_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString(); 
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DateTime H = DateTime.Parse(lblTime.Text);
            var gtri = new Login().InsertLoginData(ID, "Đăng xuất");
            new Login().UpdateLoginTemp("","","","","");
            //MsgBoxcs.Show("Đăng xuất lúc : " + H.Hour + ":" + H.Minute,Constant.THONGBAO,MsgBoxcs.Buttons.OKCancel,MsgBoxcs.Icon.Info);
            XL_Login();
            Reset();
        }
    }
}
