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
namespace AppSach
{
    public partial class frmThemNXB : Form
    {
        public frmThemNXB(string ID)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ID = ID;
        }
        string ID; public bool kt;
        public void Kiemtradulieu()
        {
            if (string.IsNullOrEmpty(txtTenNXB.Text))
            {
                kt = false;
                txtTenNXB.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtLienhe.Text))
            {
                kt = false;
                txtLienhe.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtDiachi.Text))
            {
                kt = false;
                txtDiachi.Select();
                return;
            }
        }
        private string RandomMa()
        {
            return new Random().Next(10, 99).ToString() + DateTime.Now.Month.ToString() + new Random().Next(10, 99).ToString() + DateTime.Now.Millisecond.ToString();
        }
        private void frmThemNXB_Load(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(ID))
            {
                lblHienthi.Text = "Thêm mới Nhà Xuất Bản";
                txtMaNXB.Text = RandomMa();
                txtMaNXB.Enabled = false;
            }
            else
            {
                lblHienthi.Text = "Cập nhật Nhà Xuất Bản";
                var r = NXBBUSS.LayNXBBUSS(ID);
                txtMaNXB.Text = r["MaNXB"].ToString();
                txtTenNXB.Text = r["TenNXB"].ToString();
                txtLienhe.Text = r["Lienhe"].ToString();
                txtDiachi.Text = r["Diachi"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Kiemtradulieu();
            if (!kt)
            {
                bool KT;
                string sql;

                if (string.IsNullOrEmpty(ID))
                {
                    KT = true;
                }
                else
                {
                    KT = false;
                }

                int kq;



                int KQ;
                if (KT)//Them
                {
                    if (txtLienhe.Text.Length < 10 || string.IsNullOrWhiteSpace(txtTenNXB.Text) || string.IsNullOrWhiteSpace(txtDiachi.Text)) { KQ = 100; }
                    else
                    {
                        KQ = new NXBBUSS().LuuBUSS(txtMaNXB.Text, txtTenNXB.Text = CatChuoi(txtTenNXB.Text.Trim()), txtLienhe.Text = CatChuoi(txtLienhe.Text.Trim()), txtDiachi.Text = CatChuoi(txtDiachi.Text.Trim()));
                    }
                    if (KQ == 1)
                    {
                        ID = null;
                        resetValue();
                        MsgBoxcs.Show(Constant.ADD_SUCCESSFULLY, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);

                        txtMaNXB.Text = RandomMa();
                    }
                    else
                    {
                        MsgBoxcs.Show(Constant.ADD_FAILED, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Error);

                    }
                }
                else
                {
                    if (txtLienhe.Text.Length < 10 || string.IsNullOrWhiteSpace(txtTenNXB.Text) || string.IsNullOrWhiteSpace(txtDiachi.Text)) { KQ = 100; }
                    else
                    {
                        KQ = new NXBBUSS().SuaBUSS(ID, txtTenNXB.Text = CatChuoi(txtTenNXB.Text.Trim()), txtLienhe.Text = CatChuoi(txtLienhe.Text.Trim()), txtDiachi.Text = CatChuoi(txtDiachi.Text.Trim()));

                    }
                    if (KQ == 1)
                    {
                        MsgBoxcs.Show(Constant.FIX_SUCCESSFULLY, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);
                        this.Close();
                    }
                    else
                    {
                        MsgBoxcs.Show(Constant.FIX_FAILED, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Warning);
                    }
                }

            }
        }

        private void txtTenNXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int dem = 0;
        private void resetValue()
        {
            txtTenNXB.Text = string.Empty;
            txtLienhe.Text = string.Empty;
            txtDiachi.Text = string.Empty;
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

        private void txtLienhe_TextChanged(object sender, EventArgs e)
        {
            txtLienhe.MaxLength = 10;

        }
    }
}
