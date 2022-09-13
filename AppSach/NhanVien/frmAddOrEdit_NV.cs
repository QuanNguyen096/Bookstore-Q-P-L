
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSS;
using DTO;
using Guna.UI2.WinForms;

namespace AppSach
{
    public partial class frmAddOrEdit_NV : Form
    {
        private string id;
        private string linkAnh;
        private string anhlaytudata;
        private bool KTNgay;
        private string temp = string.Empty, tHo, tTenLot, tTen;

        public frmAddOrEdit_NV(string id)
        {
            this.id = id;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            if (string.IsNullOrEmpty(id))
            {
                txtLuong.Text = Constant.LUONG_MD;
            }
            LoadDaTa();

            ToolTip a = new ToolTip();
            a.SetToolTip(btnLuu, Constant.Tooltip_Enter);
            txtCCCD.MaxLength = 12;
            txtSDT.MaxLength = 10;

        }
        private void LoadDaTa()
        {

            cmbCa.DataSource = new CaBUSS().LayCaCMB();
            cmbCa.DisplayMember = Constant.Ca_NAME;
            cmbCa.ValueMember = Constant.Ca_CODE;
            if (string.IsNullOrEmpty(id))
            {
                //Them
                lblTitleAddOrEdit.Text = Constant.Add_NV;
                cmbCV.SelectedIndex = 0;
            }
            else
            {
                txtTK.Enabled = false;
                txtMK.Enabled = false;
                //Cap Nhat
                lblTitleAddOrEdit.Text = Constant.Update_NV;
                var r = NhanVienBUSS.LayNVBUSS(id);
                txtHo.Text = r["Ho"].ToString();
                txtTenLot.Text = r["TenLot"].ToString();
                txtTen.Text = r["Ten"].ToString();
                txtSDT.Text = r["sdt"].ToString();
                txtMail.Text = r["mail"].ToString();
                txtCCCD.Text = r["cccd"].ToString();
                txtDC.Text = r["diachi"].ToString();
                txtLuong.Text = r["luong"].ToString();
                dateNgSinh.Text = r["ngaysinh"].ToString();
                cmbCV.Text = r["chucvu"].ToString();
                cmbCa.Text = r["TenCa"].ToString();
                txtTK.Text = r["taikhoan"].ToString();
                txtMK.Text = r["matkhau"].ToString();
                if (int.Parse(r["GioiTinh"].ToString().Trim()) == 1)
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                picAnhNV.ImageLocation = r["Anh"].ToString().Trim();
                anhlaytudata = r["Anh"].ToString().Trim();
            }
            lblTitleAddOrEdit.Text = (lblTitleAddOrEdit.Text.ToString()).ToUpper();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();

            bool KT;
            string sql;
            string ho = txtHo.Text.Trim();
            string tenlot = txtTenLot.Text.Trim();
            string ten = txtTen.Text.Trim();
            string anh = string.Empty;
            try
            {
                if (string.IsNullOrEmpty(linkAnh))
                {
                    anh = anhlaytudata.Trim();//khong co du lieu ==> them
                }
                else
                {
                    anh = linkAnh.Trim();//co du lieu ==> sua
                }
            }
            catch
            {
                MsgBoxcs.Show(Constant.IMAGE_FAILED, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Error);
                return;
            }
            string gioitinh = radNam.Checked ? "1" : "0";
            string sdt = txtSDT.Text.Trim();
            string mail = txtMail.Text.Trim();
            if (mail.Contains("@"))
            {
                int vtriACong = mail.IndexOf("@");//Tim vi tri @
                mail = mail.Substring(0, vtriACong);//Cat vi tri lay tu vi tri @
            }
            string cccd = txtCCCD.Text.Trim();
            string dc = txtDC.Text.Trim();
            string luong = txtLuong.Text.Trim();
            string cv = cmbCV.Text.Trim();
            string taikhoan = txtTK.Text.Trim();
            string matkhau = txtMK.Text.Trim();
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(dateNgSinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {
                MsgBoxcs.Show(Constant.Error_Time, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Error);
                dateNgSinh.Select();//tro chuot ve ngay sinh
                return;
            }
            List<CustomParameter> parameters = new List<CustomParameter>();
            if (string.IsNullOrEmpty(id))//neu them moi sv
            {
                KT = true;
            }
            else//neu update
            {
                KT = false;
            }
            int kq;

            if (KT)
            {

                if (!KTNgSinh())
                {
                    MsgBoxcs.Show(Constant.NotYearOld, Constant.ADD_FAILED, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Error);
                    kq = 100;
                }
                else if (txtCCCD.Text.Length < 9)
                {
                    kq = 100;
                    errorProvider1.SetError(txtCCCD, Constant.Error_CCCD);

                }
                else if (string.IsNullOrWhiteSpace(ho) || string.IsNullOrWhiteSpace(ten))
                {
                    kq = 100;

                    MsgBoxcs.Show(Constant.Name_Error, Constant.ADD_FAILED, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Error);

                }
                else
                {
                    if (ktchuoi())
                    {
                        MaHoaMatKhau.Encrypt(matkhau);
                        kq = new NhanVienBUSS().ThemBUSS(taikhoan, anh, ho, tenlot, ten, cccd, gioitinh, MaHoaMatKhau.Encrypt(matkhau), sdt, mail + Constant.GmailTXT, ngaysinh, dc, luong, cv, cmbCa.SelectedValue.ToString());
                    }
                    else
                    {
                        kq = 100;
                    }
                }
            }
            else
            {

                if (!KTNgSinh())
                {
                    MsgBoxcs.Show(Constant.NotYearOld, Constant.ADD_FAILED, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Error);
                    kq = 100;
                }
                else if (txtCCCD.Text.Length < 9)
                {
                    kq = 100;
                    errorProvider1.SetError(txtCCCD, Constant.Error_CCCD);

                }
                else if (string.IsNullOrWhiteSpace(ho) || string.IsNullOrWhiteSpace(ten))
                {
                    kq = 100;

                    MsgBoxcs.Show(Constant.Name_Error, Constant.ADD_FAILED, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Error);

                }
                else
                {
                    if (ktchuoi())
                    {
                        kq = new NhanVienBUSS().SuaBUSS(id, anh, ho, tenlot, ten, cccd, gioitinh, MaHoaMatKhau.Encrypt(matkhau), sdt, mail + Constant.GmailTXT, ngaysinh, dc, luong, cv, cmbCa.SelectedValue.ToString());
                    }
                    else
                    {
                        kq = 100;
                    }
                }
            }

            if (kq == 1)//Kq ==1 thi thanh cong
            {
                if (string.IsNullOrEmpty(id))//them moi
                {
                    MsgBoxcs.Show(Constant.ADD_SUCCESSFULLY, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);
                    ResetDataTxt();
                    id = null;

                }
                else//sua
                {
                    MsgBoxcs.Show(Constant.FIX_SUCCESSFULLY, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);
                    this.Close();
                }
            }
            else//that bai
            {

                MsgBoxcs.Show(Constant.FAILURE, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);
            }

        }

        private void ResetDataTxt()
        {
            txtHo.Text = String.Empty;
            txtTenLot.Text = String.Empty;
            txtTen.Text = String.Empty;
            txtDC.Text = String.Empty;
            txtSDT.Text = String.Empty;
            txtCCCD.Text = String.Empty;
            txtMail.Text = String.Empty;
            txtLuong.Text = Constant.LUONG_MD;
            dateNgSinh.Text = DateTime.Now.ToString();
            txtTK.Text = String.Empty;
            txtMK.Text = String.Empty;
            picAnhNV.Image = null;
            cmbCa.SelectedIndex = 0;
            cmbCV.SelectedIndex = 0;

        }
        private void btnMoThuMuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = Constant.PLEASE_CHOOSE_PHOTO;
            ofd.Filter = Constant.TYPE_IMAGE;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picAnhNV.ImageLocation = ofd.FileName;
                linkAnh = ofd.FileName.ToString();
            }
        }



        #region Kiểm tra nhập
        private void txtHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTenLot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private bool ktchuoi()
        {
            if (txtSDT.Text.Length < 10) { return false; }
            else if (string.IsNullOrEmpty(txtHo.Text)) { return false; }
            else if (string.IsNullOrEmpty(txtTen.Text)) { return false; }
            else if (string.IsNullOrEmpty(txtTenLot.Text)) { return false; }
            else if (string.IsNullOrEmpty(txtMail.Text)) { return false; }
            else if (string.IsNullOrEmpty(txtDC.Text)) { return false; }
            else if (string.IsNullOrEmpty(txtLuong.Text)) { return false; }
            else if (string.IsNullOrEmpty(txtMK.Text)) { return false; }
            else if (txtCCCD.Text.Length < 9 || txtCCCD.Text.Length == 11 || txtCCCD.Text.Length == 10) { return false; }
            else
                return true;
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            txtSDT.MaxLength = 10;
        }
        private bool KTNgSinh()
        {
            if (DateTime.Now.Year - dateNgSinh.Value.Year < 18)
            {
                return false;
            }
            else if (DateTime.Now.Year - dateNgSinh.Value.Year == 18 && dateNgSinh.Value.Month > DateTime.Now.Month)
            {
                return false;
            }
            else if (DateTime.Now.Year - dateNgSinh.Value.Year == 18 && dateNgSinh.Value.Month == DateTime.Now.Month && dateNgSinh.Value.Day > DateTime.Now.Day)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #region
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
        #endregion
        // Sử dụng Regex để xóa dấu tiếng việt
        public static string RemoveVietnameseTone(string text)
        {
            string result = text.ToLower();
            result = Regex.Replace(result, "à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ|/g", "a");
            result = Regex.Replace(result, "è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ|/g", "e");
            result = Regex.Replace(result, "ì|í|ị|ỉ|ĩ|/g", "i");
            result = Regex.Replace(result, "ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ|/g", "o");
            result = Regex.Replace(result, "ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ|/g", "u");
            result = Regex.Replace(result, "ỳ|ý|ỵ|ỷ|ỹ|/g", "y");
            result = Regex.Replace(result, "đ", "d");
            return result;
        }


        private void frmAddOrEdit_NV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu.PerformClick();
            }
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            txtCCCD.MaxLength = 12;
        }


        private void txtHo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                tHo = RemoveVietnameseTone(txtHo.Text.Trim());
            }
        }

        private void txtTenLot_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                tTenLot = RemoveVietnameseTone(txtTenLot.Text.Trim());
            }
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                tTen = RemoveVietnameseTone(txtTen.Text.Trim());
                string txt = tHo + tTenLot + tTen;
                string kQ = txt.Replace(' ', '\0');
                txtTK.Text = kQ + new Random().Next(0, 100);
            }
        }
    }
}
