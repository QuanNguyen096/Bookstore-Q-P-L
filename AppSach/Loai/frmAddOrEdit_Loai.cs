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
    public partial class frmAddOrEdit_Loai : Form
    {
        private string maloai;
        private string SL;
        public frmAddOrEdit_Loai(string maloai, string SL)
        {
            InitializeComponent();
            this.maloai = maloai;


            this.StartPosition = FormStartPosition.CenterParent;
            this.SL = SL;
            txtMaLoai.Enabled = false;
            LoadDaTa();
        }
        private string RandomMa()
        {
            return "L"+new Random().Next(10, 99).ToString() + DateTime.Now.Month.ToString() + new Random().Next(10, 99).ToString() + DateTime.Now.Millisecond.ToString();
        }
        private void LoadDaTa()
        {
            if (string.IsNullOrEmpty(maloai))
            {
                //Them
                txtTenLoai.Text = string.Empty;
                txtMaLoai.Text = RandomMa();
            }
            else
            {
                if (!string.IsNullOrEmpty(maloai)) { label3.Text = "SỬA LOẠI"; }

                //Cap Nhat
                //lblTitleAddOrEdit.Text = "Cập nhật nhân viên";
                var r = LoaiBUSS.LayLoaiBUSS(maloai);
                txtMaLoai.Text = r["MaLoai"].ToString();
                txtTenLoai.Text = r["TenLoai"].ToString();

            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maloai))
            {

                if (!string.IsNullOrWhiteSpace(txtTenLoai.Text))
                {
                    new LoaiBUSS().ThemLoaiBUSS(txtMaLoai.Text, txtTenLoai.Text);
                    MsgBoxcs.Show(Constant.ADD_SUCCESSFULLY, Constant.THONGBAO, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);
                    txtTenLoai.Text = string.Empty;
                    txtMaLoai.Text = RandomMa();
                }

                else
                {
                    MsgBoxcs.Show(Constant.ADD_FAILED, Constant.THONGBAO, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Error);
                }

            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txtTenLoai.Text))
                {
                    new LoaiBUSS().SuaLoaiBUSS(txtMaLoai.Text, txtTenLoai.Text);
                    MsgBoxcs.Show(Constant.FIX_SUCCESSFULLY, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Info);
                    this.Close();
                }
                else
                {
                    MsgBoxcs.Show(Constant.FIX_FAILED, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Error);
                }
            }
        }
    }
}
