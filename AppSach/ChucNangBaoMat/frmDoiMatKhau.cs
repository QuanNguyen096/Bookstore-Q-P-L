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
using System.Security.Cryptography;

namespace AppSach
{
    public partial class frmDoiMatKhau : Form
    {
        private string ID;
        public frmDoiMatKhau(string ID)
        {
            this.ID = ID;
            InitializeComponent();
            this.FormBorderStyle= FormBorderStyle.None;
            this.StartPosition= FormStartPosition.CenterScreen;
            txtMk.PasswordChar = Constant.HIDEN_HIDEN_PASSWORD;
            txtXMMk.PasswordChar = Constant.HIDEN_HIDEN_PASSWORD;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int KQ = new BUSS.DoiMatKhau().UpdateNewPassword(ID, MaHoaMatKhau.Encrypt(txtMk.Text.Trim()), MaHoaMatKhau.Encrypt(txtXMMk.Text.Trim()), txtCCCD.Text);
            if (KQ == 1)
            {
                MsgBoxcs.Show(Constant.FIX_SUCCESSFULLY, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Info);
                this.Close();
            }
            else
            {
                MsgBoxcs.Show(Constant.FIX_FAILED, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Info);

            }

        }
        ErrorProvider er = new ErrorProvider();

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            txtCCCD.MaxLength = 12;
        }
    }
}
