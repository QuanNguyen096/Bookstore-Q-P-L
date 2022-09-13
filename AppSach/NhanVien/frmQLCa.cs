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
namespace AppSach.NhanVien
{
    public partial class frmQLCa : Form
    {
        private string ID, Name;
        public int SoCa;


        private float CoDiLam;
        private float TreGio = 0.1f;
        private float ViPhamNhe = 0.2f;
        private float ViPhamNang = 0.5f;

        private float KhongDiLam = 0;

        public frmQLCa(string nameNV)
        {
            InitializeComponent();
        }
        public frmQLCa(string ID, string Name, int SoCa)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ID = ID;
            this.Name = Name;
            this.SoCa = SoCa;
            grp2_1.Enabled = false;
            grp2_2.Enabled = false;
            CoDiLam = SoCa;
            if (SoCa == 2)
            {
                grp2_1.Enabled = true;
                grp2_2.Enabled = true;
            }
            txtNameNV.Text = Name;

        }
        private void rdCoLam_CheckedChanged(object sender, EventArgs e)
        {
            txtNameNV.Text = Name;
            if (rdCoLam.Checked == true)
            {
                CoDiLam = SoCa;
                grp1_1.Visible = true;
                grp1_2.Visible = true;
                grp2_1.Visible = true;
                grp2_2.Visible = true;
            }
            else
            {
                CoDiLam = 0;

                grp1_1.Visible = false;
                grp1_2.Visible = false;
                grp2_1.Visible = false;
                grp2_2.Visible = false;
            }
        }

        private void radTreGioLam_CheckedChanged(object sender, EventArgs e)
        {
            if (radTreGioLam.Checked) { CoDiLam -= TreGio; } else { CoDiLam += TreGio; }

        }

        private void radSom_CheckedChanged(object sender, EventArgs e)
        {
            if (radSom.Checked) { CoDiLam -= TreGio; } else { CoDiLam += TreGio; }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var a = new DiemDanhBUS().DiemDanhNhanVien_TinhLuongNGay(ID, CoDiLam.ToString(), txtMoTa.Text);
            MsgBoxcs.Show(Constant.DD_S, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);
            this.Close();
        }

        private void radTreGioLam2_CheckedChanged(object sender, EventArgs e)
        {
            if (radTreGioLam2.Checked) CoDiLam -= TreGio; else CoDiLam += TreGio;
        }

        private void chkViPhamNhe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViPhamNhe.Checked) CoDiLam -= ViPhamNhe; else CoDiLam += ViPhamNhe;
        }

        private void chkVPNang_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVPNang.Checked) CoDiLam -= ViPhamNang; else CoDiLam += ViPhamNang;
        }

        private void radSom2_CheckedChanged(object sender, EventArgs e)
        {
            if (radSom2.Checked) CoDiLam -= TreGio; else CoDiLam += TreGio;
        }


    }
}
