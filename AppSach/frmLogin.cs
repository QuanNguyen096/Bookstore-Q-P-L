using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUSS;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;

namespace AppSach
{
    public partial class frmLogin : Form
    {
        public string HoVaTen, ChucVu = string.Empty, Anh;
        public string TK;
        public string MK;
        public int VnEn = 0;
        public string ID;
        public frmLogin(string STATUS)
        {

            InitializeComponent();
            btnChecked.Visible = false;
            VnEn = int.Parse(STATUS);
            this.FormBorderStyle = FormBorderStyle.None;
            txtUser.Text = "tranthoilong";
            txtPass.Text = "123Long";
            txtPass.PasswordChar = Constant.HIDEN_HIDEN_PASSWORD;
            VietNam_Anh();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Constant.LinkFB);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            linkLabel1_LinkClicked(sender, null);
        }
        bool isHD;



        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KTNhap()
        {
            err.Clear();
            if (string.IsNullOrEmpty(txtUser.Text) && string.IsNullOrEmpty(txtPass.Text))
            {
                MsgBoxcs.Show(Constant.PleaseFillInInfor, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                txtUser.Select();
                err.SetError(txtUser, Constant.ErrorTK);
                isHD = false;
                return;

            }
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                Select();
                err.SetError(txtUser, Constant.ErrorMk);
                isHD = false;
                return;
            }
            isHD = true;
        }
        /**/
        string VN_EN = "";
        ResourceManager rm;

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
            //lblChuyendoi.Text = rm.GetString("chuyentaikhoan").ToUpper();
            btnDangNhap.Text = rm.GetString("btnDangNhap").ToUpper();
            btnThoat.Text = rm.GetString("btnThoat").ToUpper();
            linkLabel1.Text = rm.GetString("btnHoTro").ToUpper();
            titleLogin.Text = rm.GetString("btnDangNhap").ToUpper();
            txtPass.PlaceholderText = rm.GetString("matkhau");
            txtUser.PlaceholderText = rm.GetString("tentaikhoan");
        }
        bool a;
        private void btnChecked_Click(object sender, EventArgs e)
        {
            if (a)
            {
                btnChecked.Checked = false;
                a = false;
            }
            else
            {
                btnChecked.Checked = true;
                a = true;
            }
            VietNam_Anh();

        }
        /**/
        private void guna2ImageButton2_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.PasswordChar = Constant.HIDEN_HIDENT_PASSWORD;
        }

        private void guna2ImageButton2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.PasswordChar = Constant.HIDEN_HIDEN_PASSWORD;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }
        public class MaHoaMatKhau
        {
            private static string key = "MAHOAMATKHAU";
            //Mã hóa chuỗi
            public static string Encrypt(string toEncrypt)
            {
                using (var md5 = new MD5CryptoServiceProvider())
                {
                    using (var tdes = new TripleDESCryptoServiceProvider())
                    {
                        tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                        tdes.Mode = CipherMode.ECB;
                        tdes.Padding = PaddingMode.PKCS7;

                        using (var transform = tdes.CreateEncryptor())
                        {
                            byte[] textBytes = UTF8Encoding.UTF8.GetBytes(toEncrypt);
                            byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                            return Convert.ToBase64String(bytes, 0, bytes.Length);
                        }
                    }
                }
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            KTNhap();
            TK = txtUser.Text.Trim();
            MK = txtPass.Text.Trim();

            if (isHD)
            {
                int KT = new Login().KTLogin(TK, MaHoaMatKhau.Encrypt(MK));
                if (KT == 0)
                {
                    MsgBoxcs.Show(Constant.Error_Login, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Error);
                }
                else
                {
                    var r = new Login().LayNV(TK);
                    ID = r["ID"].ToString();
                    HoVaTen = r["HoVaTen"].ToString();
                    ChucVu = r["ChucVu"].ToString();
                    Anh = r["Anh"].ToString();
                    new Login().UpdateLoginTemp(ID, txtUser.Text, txtPass.Text, Anh, ChucVu);
                    var gtri = new Login().InsertLoginData(ID, Constant.STATUS_LOGIN);
                    this.Close();
                }
            }
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isHD)
            {
                Application.Exit();
            }
        }
    }
}
