using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSach.NhanVien;
using DTO;
using BUSS;
namespace AppSach.NhanVien
{
    public partial class frmDSDD : Form
    {
        public frmDSDD()
        {
            InitializeComponent();
            Constant.CustomDataGridView(dgvDSDD);
            Constant.CustomDataGridView(dgvLuongThang);
            Constant.CustomDataGridView(dgvLuongNam);
            Constant.CustomElipGuna(txtMM);


            txtYear.Text = DateTime.Now.Year.ToString();
            cmbMonth.Text = DateTime.Now.Month.ToString();
            txtDay.Text = DateTime.Now.Day.ToString();
            new LuongThangBUS().InsertData();
            new LuongNamBus().InsertData();
            txtMM.Text = DateTime.Now.Month.ToString();
            txtSearchNamNam.Text = txtNam.Text = DateTime.Now.Year.ToString();


        }
        // private void 
        private void LoadDATA()
        {

            try
            {
                new BangLuongNgayBUSS().BangLuongNgay(dgvDSDD, txtKey.Text, cmbCa.SelectedValue.ToString(), txtDay.Text, cmbMonth.Text, txtYear.Text);
                new LuongThangBUS().DSLuongThang(dgvLuongThang, txtMM.Text, txtNam.Text, txtSearch.Text);
                new LuongNamBus().DSLuongNam(dgvLuongNam, txtSearchNamNam.Text, txtSearchNam.Text);


            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            LoadDATA();
        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {
           LoadDATA();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            LoadDATA();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDATA();
        }

        private void frmDSDD_Load(object sender, EventArgs e)
        {

            cmbCa.DataSource = new CaBUSS().LayCaCMB();
            cmbCa.DisplayMember = Constant.Ca_NAME;
            cmbCa.ValueMember = Constant.Ca_CODE;
            cmbCa.SelectedIndex = 0;

            Constant.CusTomComBoBox(cmbCa);

            LoadDATA();
        }

        private void cmbCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDATA();
        }

        private void txtMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDATA();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDATA();
        }

        private void txtSearchNamNam_TextChanged(object sender, EventArgs e)
        {
            LoadDATA();
        }

        private void txtSearchNam_TextChanged(object sender, EventArgs e)
        {
            LoadDATA();
        }

        private void txtSearchNamNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtMM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
