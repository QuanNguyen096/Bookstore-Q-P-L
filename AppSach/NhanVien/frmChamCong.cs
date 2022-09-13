using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSS;using DTO;
namespace AppSach.NhanVien
{
    public partial class frmChamCong : Form
    {
        bool gtri;
        public frmChamCong()
        {
            InitializeComponent();
            LoadDATA();
           txtDay.Text=DateTime.Now.Day.ToString();
           cmbMonth.Text= DateTime.Now.Month.ToString();
            txtYear.Text= DateTime.Now.Year.ToString();
            cmbCa.DataSource = new CaBUSS().LayCaCMB();
            cmbCa.DisplayMember = Constant.Ca_NAME;
            cmbCa.ValueMember = Constant.Ca_CODE;


            customcontrol();
        }
        public void customcontrol()
        {
            Constant.CustomElipGuna(txtDay);
            Constant.CustomElipGuna(txtKey);
            Constant.CustomElipGuna(cmbCa);
 

        }
        private void LoadDATA()
        {
            Constant.CustomDataGridView(dgvLsDangNhap);
            Constant.CustomDataGridView(dgvDSNVDD);
            new NhanVienBUSS().DSNVDD(dgvDSNVDD, txtKeyDD.Text);
            new Login().DSLoginNV(dgvLsDangNhap,txtKey.Text,cmbCa.Text,txtDay.Text,cmbMonth.Text,txtYear.Text);
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDATA();
        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {
            if(txtDay.Text.Length > 0)
            {
                if (int.Parse(txtDay.Text) <0 || int.Parse(txtDay.Text) > 31)
                {
                    txtDay.Text = DateTime.Now.Day.ToString();
                }
            }
            
            LoadDATA();

            
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtYear.Text.Length > 0)
                {
                    if (int.Parse(txtYear.Text) < 0||int.Parse(txtYear.Text) > DateTime.Now.Year)
                    {
                        txtYear.Text = DateTime.Now.Year.ToString();
                    }
                }
            }catch (Exception ex)
            {
                return;
            }
            
            LoadDATA();

        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            LoadDATA();

        }

        private void cmbCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDATA();
          //MessageBox.Show(cmbCa.Text);
        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            cmbCa.SelectedIndex = -1;
            cmbCa.Text = String.Empty;
            
            
            //cmbCa.SelectedIndex = 0;
            Constant.CusTomComBoBox(cmbCa);
            ////
            /// cmbCa.SelectedIndex = -1;

        }

        private void dgvDSNVDD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var GTRI = dgvDSNVDD.Rows[e.RowIndex];
                var ID_DD = GTRI.Cells["IDNV"].Value.ToString();
                var Name = GTRI.Cells["HoVaTenNV"].Value.ToString();
                var Ca = GTRI.Cells["SoCa"].Value.ToString();


                var TrangThai_DD = GTRI.Cells["trangthaiDD"].Value.ToString();
                if(TrangThai_DD.ToLower()==Constant.CHUA_DD.ToLower())
                {
                    //MessageBox.Show(TrangThai_DD);
                    new frmQLCa(ID_DD,Name,int.Parse(Ca)).ShowDialog();
                    LoadDATA();

                }
            }
        }

        private void txtKeyDD_TextChanged(object sender, EventArgs e)
        {
            LoadDATA();
        }

        private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
