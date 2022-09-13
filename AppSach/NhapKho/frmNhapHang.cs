using BUSS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSach
{
    public partial class frmNhapHang : Form
    {
        public string ID;
        public string Ten;
        public bool Readonly = true;
        public frmNhapHang(string id,string ten,string ChucVu)
        {
            InitializeComponent();
            ID = id;
            Ten = ten;
            if(ChucVu == "Admin")
                dgvPhieuNhap.Columns[0].Visible = true;
            else
                dgvPhieuNhap.Columns[0].Visible = false;
        }

        private void btnTaoHDNhap_Click(object sender, EventArgs e)
        {
            Readonly = false;

            Random rd = new Random();
            int dd = DateTime.Now.Day;
            int MM = DateTime.Now.Month;
            int yyyy = DateTime.Now.Year;
            int Ma = dd + MM + yyyy + rd.Next(0, 100);


            bool temp = true;
            new PhieuNhap.frmThemPhieuNhap(Ma.ToString(),Ten,Readonly,ID,"3",temp).ShowDialog();

            new PhieuNhapBUSS().LayDSPhieuNhap(dgvPhieuNhap, txtKey.Text);

        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            new PhieuNhapBUSS().LayDSPhieuNhap(dgvPhieuNhap, txtKey.Text);
        }


        private void dgvPhieuNhap_DoubleClick(object sender, EventArgs e)
        {
            Readonly = false;
            bool temp = false;
            new PhieuNhap.frmThemPhieuNhap(dgvPhieuNhap.SelectedRows[0].Cells["colMaPhieu"].Value.ToString(), dgvPhieuNhap.SelectedRows[0].Cells["colTenNV"].Value.ToString(), Readonly, dgvPhieuNhap.SelectedRows[0].Cells["colTenNV"].FormattedValue.ToString(), dgvPhieuNhap.SelectedRows[0].Cells["colTrangThai"].FormattedValue.ToString(),temp).ShowDialog();
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)//hang 1 chi so 0, hang 2 so 1
            {
                if (e.ColumnIndex == dgvPhieuNhap.Columns["colDuyet"].Index)
                {
                    Readonly = false;
                    int a = 0;
                    if (dgvPhieuNhap.SelectedRows[0].Cells["colTrangThai"].Value.ToString() == "Đã Duyệt")
                    {
                        MsgBoxcs.Show("Bạn đã duyệt phiếu này rồi", Constant.THONGBAO, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);
                        return;
                    }
                    DialogResult dialogResult =  MsgBoxcs.Show("Bạn có muốn duyệt phiếu",Constant.THONGBAO,MsgBoxcs.Buttons.YesNo,MsgBoxcs.Icon.Info);
                    
                    if(dialogResult == DialogResult.Yes)
                    {
                        
                        a = new PhieuNhapBUSS().DuyetPhieu(dgvPhieuNhap.SelectedRows[0].Cells["colMaPhieu"].Value.ToString());
                        new AppSach.NhapKho.frmInPhieuNhap(Ten, DateTime.Now.ToShortDateString(), dgvPhieuNhap.SelectedRows[0].Cells["colMaPhieu"].Value.ToString()).ShowDialog();
                    }
                    if (a == 1)
                    {
                        //MessageBox.Show(Constant.APPROVAL_SUCCESSFULLY);
                        MsgBoxcs.Show(Constant.APPROVAL_SUCCESSFULLY, Constant.THONGBAO, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Info);
                    }
                    
                    new PhieuNhapBUSS().LayDSPhieuNhap(dgvPhieuNhap, txtKey.Text);

                }

            }
        }
    }
}
