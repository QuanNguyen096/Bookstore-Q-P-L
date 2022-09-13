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
    public partial class frmCa : Form
    {
        public frmCa()
        {
            InitializeComponent();
            Constant.CustomDataGridView(dgvCa);
            Constant.CustomElipGuna(dgvCa);
            StartPosition = FormStartPosition.CenterScreen;
            Constant.CustomDrag(label8);
            LoadDATA();
        }

        private void LoadDATA()
        {
            new CaBUSS().LayDSCA(dgvCa, "");
        }
        string Ca1 = string.Empty, Ca2 = string.Empty;//hh:pp / hh:pp
        string TGCa1 = string.Empty, TGCa2 = string.Empty;//HH / PP
        string Gio = string.Empty;
        string Phut = string.Empty;


        private void TachKiTuTheoDau_Gach(string txt)
        {
            string[] tam = txt.Split('-');
            TGCa1 = tam[0];
            TGCa2 = tam[1];
        }
        private void TachKiTuTheoDau_Xuyet(string txt)
        {
            string[] tam = txt.Split('/');
            Ca1 = tam[0];
            Ca2 = tam[1];
        }
        private void KTGioTtc_GioSau()
        {

        }
        private void TxtBox24H(Guna2TextBox txt)
        {
            try
            {
                if (int.Parse(txt.Text) > 23)
                {
                    txt.Text = "00";
                }
            }
            catch
            {
                return;
            }
        }
        private void TextBoxDK(Guna2TextBox txt)
        {
            txt.MaxLength = 2;
            try
            {
                if (int.Parse(txt.Text) < 0)
                {
                    txt.Text = "00";
                }
                if (int.Parse(txt.Text) > 60)
                {
                    txt.Text = "00";
                }
            }
            catch
            {
                return;
            }
        }
        private void txtHP2KT_TextChanged(object sender, EventArgs e)
        {
            TextBoxDK(txtHP2KT);
        }

        private void txtHH2KT_TextChanged(object sender, EventArgs e)
        {
            TextBoxDK(txtHH2KT);
            TxtBox24H(txtHH2KT);

        }

        private void txtHP2BD_TextChanged(object sender, EventArgs e)
        {
            TextBoxDK(txtHP2BD);
        }

        private void txtHH2BD_TextChanged(object sender, EventArgs e)
        {
            TextBoxDK(txtHH2BD);
            TxtBox24H(txtHH2BD);

        }

        private void txtHP1KT_TextChanged(object sender, EventArgs e)
        {
            TextBoxDK(txtHP1KT);
        }

        private void txtHH1KT_TextChanged(object sender, EventArgs e)
        {
            TextBoxDK(txtHH1KT);
            TxtBox24H(txtHH1KT);
        }

        private void txtHP1BD_TextChanged(object sender, EventArgs e)
        {
            TextBoxDK(txtHP1BD);
        }

        private void txtHH1BD_TextChanged(object sender, EventArgs e)
        {
            TextBoxDK(txtHH1BD);
            TxtBox24H(txtHH1BD);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHH1BD.Text))
            {
                txtHH1BD.Text = "00";
            }
            else if(txtHH1BD.Text.Length < 2)
            {
                txtHH1BD.Text = "0" + txtHH1BD.Text;
            }
            if (string.IsNullOrEmpty(txtHP1BD.Text))
            {
                txtHP1BD.Text = "00";
            }
            else if (txtHP1BD.Text.Length < 2)
            {
                txtHP1BD.Text = "0" + txtHP1BD.Text;
            }
            if (string.IsNullOrEmpty(txtHH1KT.Text))
            {
                txtHH1KT.Text = "00";
            }
            else if (txtHH1KT.Text.Length < 2)
            {
                txtHH1KT.Text = "0" + txtHH1KT.Text;
            }
            else
            {
                if (int.Parse(txtHH1KT.Text) < int.Parse(txtHH1BD.Text))
                {
                    MessageBox.Show("Loi");
                }
                else if (int.Parse(txtHH1KT.Text) == int.Parse(txtHH1BD.Text) && int.Parse(txtHP1BD.Text) > int.Parse(txtHP1KT.Text))
                {
                    MessageBox.Show("Loi");

                }
            }
            if (string.IsNullOrEmpty(txtHP1KT.Text))
            {
                txtHP1KT.Text = "00";
            }
            else if (txtHP1KT.Text.Length < 2)
            {
                txtHP1KT.Text = "0" + txtHP1KT.Text;
            }

            if (string.IsNullOrEmpty(txtHH2BD.Text))
            {
                txtHH2BD.Text = "00";
            }
            else if (txtHH2BD.Text.Length < 2)
            {
                txtHH2BD.Text = "0" + txtHH2BD.Text;
            }
            else
            {
                if (int.Parse(txtHH2KT.Text) < int.Parse(txtHH2BD.Text))
                {
                    MessageBox.Show("Loi");
                }
                else if (int.Parse(txtHH2KT.Text) == int.Parse(txtHH2BD.Text) && int.Parse(txtHP2BD.Text) > int.Parse(txtHP2KT.Text))
                {
                    MessageBox.Show("Loi");

                }
            }
            if (string.IsNullOrEmpty(txtHP2BD.Text))
            {
                txtHP2BD.Text = "00";
            }
            else if (txtHP2BD.Text.Length < 2)
            {
                txtHP2BD.Text = "0" + txtHP2BD.Text;
            }
            if (string.IsNullOrEmpty(txtHH2KT.Text))
            {
                txtHH2KT.Text = "00";
            }
            else if (txtHH2KT.Text.Length < 2)
            {
                txtHH2KT.Text = "0" + txtHH2KT.Text;
            }
            if (string.IsNullOrEmpty(txtHP2KT.Text))
            {
                txtHP2KT.Text = "00";
            }
            else if (txtHP2KT.Text.Length < 2)
            {
                txtHP2KT.Text = "0" + txtHP2KT.Text;
            }

            string CaThu1 = txtHH1BD.Text + ":" + txtHP1BD.Text + "-" + txtHH1KT.Text + ":" + txtHP1KT.Text;
            string CaThu2 = txtHH2BD.Text + ":" + txtHP2BD.Text + "-" + txtHH2KT.Text + ":" + txtHP2KT.Text;
            string GiaTriLuu = txtHH1BD.Text + ":" + txtHP1BD.Text + "-" + txtHH1KT.Text + ":" + txtHP1KT.Text + "/"
                + txtHH2BD.Text + ":" + txtHP2BD.Text + "-" + txtHH2KT.Text + ":" + txtHP2KT.Text;
            if (CaThu2 == Constant.GTRI_RONG)
            {
                CaThu2 = Constant.CA_TRONG;
            }
            if(CaThu1 == Constant.CA_TRONG)
            {
                CaThu1=Constant.CA_TRONG;
            }
            MessageBox.Show(Constant.CA_1+ CaThu1);
            MessageBox.Show(Constant.CA_2 + CaThu2);
            MessageBox.Show(GiaTriLuu);

            MsgBoxcs.Show(Constant.CA_1 + CaThu1, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK);
            MsgBoxcs.Show(Constant.CA_2 + CaThu2, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK);
            MsgBoxcs.Show(GiaTriLuu, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TachKiTuTheoDau_HaiCham(string txt)
        {
            string[] tam = txt.Split(':');
            Gio = tam[0];
            Phut = tam[1];
        }
        private void dgvCa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var gtri = dgvCa.Rows[e.RowIndex];
                var ID = gtri.Cells["MaCa"].Value.ToString();
                var r = new CaBUSS().Lay1Ca(ID);
                string ThoiGian = r["ThoiGian"].ToString();
                txtTenCa.Text = gtri.Cells["TenCa"].Value.ToString();
                txtMoTa.Text = gtri.Cells["MoTa"].Value.ToString();
                txtSoCa.Text = gtri.Cells["SoCa"].Value.ToString();
                if (ThoiGian.Contains("/"))//Neu ki ti / ton tai  7:30-11:30/15:30-19:30
                {
                    TachKiTuTheoDau_Xuyet(ThoiGian);
                    TachKiTuTheoDau_Gach(Ca1);//Ca1 7:30-11:30
                    TachKiTuTheoDau_HaiCham(TGCa1);
                    txtHH1BD.Text = Gio;
                    txtHP1BD.Text = Phut;
                    TachKiTuTheoDau_HaiCham(TGCa2);
                    txtHH1KT.Text = Gio;
                    txtHP1KT.Text = Phut;

                    TachKiTuTheoDau_Gach(Ca2);

                    TachKiTuTheoDau_HaiCham(TGCa1);
                    txtHH2BD.Text = Gio;
                    txtHP2BD.Text = Phut;
                    TachKiTuTheoDau_HaiCham(TGCa2);
                    txtHH2KT.Text = Gio;
                    txtHP2KT.Text = Phut;
                }
                else // neu ki tu / khong ton tai 7:30 -11:30
                {
                    TachKiTuTheoDau_Gach(ThoiGian);//Ca1 7:30-11:30
                    //txtHH1BD.Text = GioBDCa1;
                    //txtHH1KT.Text = GioBDCa2;
                    TachKiTuTheoDau_HaiCham(TGCa1);
                    txtHH1BD.Text = Gio;
                    txtHP1BD.Text = Phut;
                    TachKiTuTheoDau_HaiCham(TGCa2);
                    txtHH1KT.Text = Gio;
                    txtHP1KT.Text = Phut;

                    txtHH2BD.Text = string.Empty;
                    txtHP2BD.Text = string.Empty;
                    txtHH2KT.Text = string.Empty;
                    txtHP2KT.Text = string.Empty;

                }
            }
        }
    }
}
