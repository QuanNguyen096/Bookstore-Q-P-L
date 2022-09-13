using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSS;
using DTO;
using Guna.UI2.WinForms;

namespace AppSach
{
    public partial class frmThemOrEditSach : Form
    {
        private string MS;
        private string so;

        public frmThemOrEditSach(string MS, string so)
        {
            this.MS = MS;
            this.so = so;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            Constant.CustomElipGuna(txtMoTa);
            Constant.CustomElipGuna(cmbLoai);
            Constant.CustomElipGuna(cmbNXB);
            Load();
        }
        private void Load()
        {

            Constant.CusTomComBoBox(cmbLoai);
            Constant.CusTomComBoBox(cmbNXB);


            cmbLoai.DataSource = new LoaiBUSS().LayLoai();
            cmbLoai.DisplayMember =Constant.TYPE_NAME;
            cmbLoai.ValueMember = Constant.TYPE_CODE;

            cmbNXB.DataSource = new NXBBUSS().ListNXB();
            cmbNXB.DisplayMember = Constant.NXB_NAME;
            cmbNXB.ValueMember = Constant.NXB_CODE;
            if (string.IsNullOrEmpty(MS))
            {
                lblTitle.Text = "THÊM SÁCH";
            }
            else
            {
                lblTitle.Text = "SỬA SÁCH";
                var r = BUSS.SachBUSS.Lay1Sach(MS);
                txtTenSach.Text = r["TenSach"].ToString();
                txtTenTG.Text = r["TenTG"].ToString();
                nuSL.Value = decimal.Parse(r["SoLuong"].ToString());
                string[] DG = r["DonGia"].ToString().Split('.');
                cmbLoai.Text = r["TenLoai"].ToString();
                cmbNXB.Text = r["TenNXB"].ToString();
                txtDonGia.Text = DG[0];
                txtMoTa.Text = r["MoTa"].ToString();
                try
                {
                    picSach.ImageLocation = r["Anh"].ToString().Trim();
                    anhlaytudata = r["Anh"].ToString().Trim();
                }
                catch
                {
                    return;
                }
            }
        }
        string anhlaytudata;
        string MaSach;
        string Anh;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool KT; int i = 0;bool SaveGtri=false;
        private void ClearData()
        {
            txtTenSach.Text = string.Empty;
            txtTenTG.Text = string.Empty;
            txtMoTa.Text= string.Empty;
            txtDonGia.Text= string.Empty;
            nuSL.Value = 1;
            cmbLoai.SelectedIndex= 0;
            cmbNXB.SelectedIndex = 0;
            MS = null;
            picSach.Image = null;
        }
        private void RDMSSach()
        {
            Random rd = new Random();

            MS = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + rd.Next(0, 100).ToString() + so;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(MS))
            {
                KT = true;
                RDMSSach();
                anhlaytudata = Anh;
            }
            else
            {
                KT = false;
            }
            int kq;
            if (KT)
            {   

                kq = new SachBUSS().ThemBUSS(MS, anhlaytudata, cmbLoai.SelectedValue.ToString(), cmbNXB.SelectedValue.ToString(), txtTenSach.Text=CatChuoi(txtTenSach.Text.Trim()), txtTenTG.Text=CatChuoi(txtTenTG.Text.Trim()), nuSL.Value.ToString(), txtDonGia.Text.ToString().Trim(), txtMoTa.Text.ToString().Trim());
                if (kq == 1)
                {               
                    MsgBoxcs.Show(Constant.ADD_SUCCESSFULLY, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);

                    MS = null;
                    ClearData();
                }
                else
                {
                MsgBoxcs.Show(Constant.ADD_FAILED, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);

                    MS = null;
                }
            }
            else
            {
                kq = new SachBUSS().SuaBUSS(MS, anhlaytudata, cmbLoai.SelectedValue.ToString(), cmbNXB.SelectedValue.ToString(), txtTenSach.Text = CatChuoi(txtTenSach.Text.Trim()), txtTenTG.Text = CatChuoi(txtTenTG.Text.Trim()), nuSL.Value.ToString(), txtDonGia.Text.ToString().Trim(), txtMoTa.Text.ToString().Trim());
                if(kq == 1)
                {
                    MsgBoxcs.Show(Constant.FIX_SUCCESSFULLY, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);
                    this.Close();
                }
                else
                {
                    MsgBoxcs.Show(Constant.FIX_FAILED, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);
                    Select();
                    return;

                }
            }
        }

        private void btnMoThuMuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = Constant.PLEASE_CHOOSE_PHOTO;
            ofd.Filter = Constant.TYPE_IMAGE;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picSach.ImageLocation = ofd.FileName;
                Anh = ofd.FileName.ToString();
            }
        }

        private void cmbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string MaLoai=string.Empty, MaNXB = string.Empty;
        int dem = 0;
        private void btnThemLoai_Click(object sender, EventArgs e)
        {
           
            string rd = Constant.LOAI + Constant.CODE + new Random().Next(0, 100).ToString() + DateTime.Now.Millisecond;
            try
            {
                MaLoai = cmbLoai.SelectedValue.ToString();
                MsgBoxcs.Show(Constant.Name_Error, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);


            }
            catch (Exception ex)
            {
                if (string.IsNullOrEmpty(MaLoai))
                {
                    MaLoai = rd;
                }
                else
                {
                    MaLoai = rd + dem; dem++;
                }
                try
                {
                    new LoaiBUSS().ThemLoaiBUSS(MaLoai, cmbLoai.Text);
                    cmbLoai.DataSource = new LoaiBUSS().LayLoai();
                    cmbLoai.SelectedValue = MaLoai;
                    MsgBoxcs.Show(Constant.ADD_SUCCESSFULLY, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);

                }
                catch
                {
                        MsgBoxcs.Show(Constant.ADD_FAILED, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);
                }
            }
            
        }

        private void frmThemOrEditSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu.PerformClick();
            }
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            new frmThemNXB(null).ShowDialog();
            cmbNXB.DataSource = new NXBBUSS().ListNXB();
            cmbNXB.DisplayMember = Constant.NXB_NAME;
        }
        private string CatChuoi(string FullName)
        {
           
           
            string Result = "";


            /* Cắt các khoảng trắng dư ở đầu và cuối chuỗi */
            FullName = FullName.Trim();

            /* 
             * Trong khi còn tìm thấy 2 khoảng trắng
             * thì thực hiện thay thế 2 khoảng trắng bằng 1 khoảng trắng
             */
            while (FullName.IndexOf("  ") != -1)
            {
                FullName = FullName.Replace("  ", " ");
            }
            /*
             * Cắt chuỗi họ tên ra thành mảng các từ.
             * Sau đó duyệt mảng để chuẩn hoá từng từ một.
             * Khi duyệt mỗi từ ta thực hiện cắt ra chữ cái đầu trên và lưu trong biến FirstChar
             * Cắt các chữ cái còn lại và lưu trong biến OtherChar.
             * Thực hiện viết hoa chữ cái đầu và viết thường các chữ cái còn lại.
             * Cuối cùng là lưu chữ vừa chuẩn hoá vào biến Result.
             */
            string[] SubName = FullName.Split(' ');

            for (int i = 0; i < SubName.Length; i++)
            {
                string FirstChar = SubName[i].Substring(0, 1);
                string OtherChar = SubName[i].Substring(1);
                SubName[i] = FirstChar.ToUpper() + OtherChar.ToLower();
                Result += SubName[i] + " ";
            }

            return Result;

        }
        private void KhongChoNhapChu(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
