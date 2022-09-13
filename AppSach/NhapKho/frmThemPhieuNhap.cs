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

namespace AppSach.PhieuNhap
{
    public partial class frmThemPhieuNhap : Form
    {
        public float TienThue = 0;
        public string Id;


        public frmThemPhieuNhap(string MaPhieu,string TenNV,bool ReadOnly,string ID,string TrangThai,bool temp)
        {
            InitializeComponent();

            bool Temp = temp;
            if(Temp)
                LoadCTPhieu();
            else
                new CT_PhieuNhapBUSS().LayDSCTPhieu(dgvCTPhieu, lblMaPhieu.Text);


            if (ReadOnly||TrangThai == "Đã Duyệt")
            {
                btnThemCTPhieu.Visible = false;
                btnLuu.Visible = false;
            }
            else
            {
                btnThemCTPhieu.Visible = true;
                btnLuu.Visible = true;
            }

            Id = ID;
            Constant.CustomElipGuna(cbbSoLuong);


            dgvCTPhieu.AutoGenerateColumns = false;
            lblMaPhieu.Text = MaPhieu;
            lblTenNhanVien.Text = TenNV;
            lblThue.Text = "5%";
            lblTienThue.Text = "0";
            lblThanhTien.Text = "0";
            lblNgayTao.Text = DateTime.Now.ToString("dd/MM/yyyy");


            lblTienThue.Enabled = true;

            lblThanhTienCTphieu.Text = ((float)0 * (int)cbbSoLuong.Value).ToString();


        }
        #region NhapTTPhieu
        private void frmThemPhieuNhap_Load(object sender, EventArgs e)
        {
            cbbTenSach.DataSource = new SachBUSS().LaySach();
            cbbTenSach.DisplayMember = "TenSach";
            cbbTenSach.ValueMember = "MaSach";

            Constant.CusTomComBoBox(cbbTenSach);
            Constant.CusTomComBoBox(cbbNXB);
            Constant.CustomElipGuna(cbbNXB);
            Constant.CustomElipGuna(cbbTenSach);


            cbbNXB.DataSource = new NXBBUSS().ListNXB();
            cbbNXB.DisplayMember = "TenNXB";
            cbbNXB.ValueMember = "MaNXB";

            var r = SachBUSS.Lay1Sach(cbbTenSach.SelectedValue.ToString());
            //txtDonGia.Text = r["DonGia"].ToString();
            cbbNXB.Text = r["TenNXB"].ToString();

            new CT_PhieuNhapBUSS().LayDSCTPhieu(dgvCTPhieu, lblMaPhieu.Text);

            //lblThanhTienCTphieu.Text = (float.Parse(txtDonGia.Text) * (int)cbbSoLuong.Value).ToString();

        }

        #endregion

        private DataTable DataTable = new DataTable();

        void LoadCTPhieu()
        {
            DataTable.Columns.Add("Mã Phiếu", typeof(string));
            DataTable.Columns.Add("Tên Sách", typeof(string));
            DataTable.Columns.Add("Nhà Xuất Bản", typeof(string));
            DataTable.Columns.Add("Đơn Giá", typeof(string));
            DataTable.Columns.Add("Số Lượng", typeof(string));
            DataTable.Columns.Add("Thành Tiền", typeof(float));
            DataTable.Columns.Add("Trạng Thái", typeof(string));

            dgvCTPhieu.DataSource = DataTable;

        }


        private void cbbTenSach_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var r = SachBUSS.Lay1Sach(cbbTenSach.SelectedValue.ToString());
            //txtDonGia.Text = r["DonGia"].ToString();
            cbbNXB.Text = r["TenNXB"].ToString();

            lblThanhTienCTphieu.Text = ((float)0 * (int)cbbSoLuong.Value).ToString();
        }

        

        private void btnThemCTPhieu_Click(object sender, EventArgs e)
        {

            int dong = -1;
            for (int i = 0; i < dgvCTPhieu.Rows.Count; i++)
            {
                if (dgvCTPhieu.DataSource == null)
                    break;
                if (cbbTenSach.Text == dgvCTPhieu.Rows[i].Cells[1].Value.ToString())
                {
                    dong = dgvCTPhieu.Rows[i].Index;
                    break;
                }
            }
            int a;

            if (dong != -1)
            {
                //a = new CT_PhieuNhapBUSS().UpdateCTPhieuNhap(lblMaPhieu.Text, cbbTenSach.Text, cbbSoLuong.Value.ToString());
                DataGridViewRow dataGridViewRow = dgvCTPhieu.Rows[dong];
                //cT_HoaDonBUSS.CapNhatCTHD(lblMaHD.Text, cmbMaSach.Text, (int)nuSL.Value);
                dataGridViewRow.Cells[4].Value = int.Parse(dataGridViewRow.Cells[4].Value.ToString()) + (int)cbbSoLuong.Value;
                dataGridViewRow.Cells[5].Value = float.Parse(dataGridViewRow.Cells[3].Value.ToString()) * float.Parse(dataGridViewRow.Cells[4].Value.ToString());
            }
            else
            {
                string trangthai = "0";

                if (cbbTenSach.SelectedValue == null)
                {
                    trangthai = "1";
                    //new CT_PhieuNhapBUSS().ThemCT_Phieu(lblMaPhieu.Text, cbbTenSach.Text, cbbNXB.SelectedValue.ToString(), txtDonGia.Text, cbbSoLuong.Value.ToString(), lblThanhTienCTphieu.Text, trangthai);
                    DataTable.Rows.Add(lblMaPhieu.Text, cbbTenSach.Text, cbbNXB.Text, txtDonGia.Text, cbbSoLuong.Value.ToString(), lblThanhTienCTphieu.Text, trangthai);
                    dgvCTPhieu.DataSource = DataTable;
                }
                else
                {
                    //a = new CT_PhieuNhapBUSS().ThemCT_Phieu(lblMaPhieu.Text, cbbTenSach.Text, cbbNXB.SelectedValue.ToString(), txtDonGia.Text, cbbSoLuong.Value.ToString(), lblThanhTienCTphieu.Text, trangthai); 
                    DataTable.Rows.Add(lblMaPhieu.Text, cbbTenSach.Text, cbbNXB.Text, txtDonGia.Text, cbbSoLuong.Value.ToString(), lblThanhTienCTphieu.Text, trangthai);
                    dgvCTPhieu.DataSource = DataTable;
                } 
            }

            //new CT_PhieuNhapBUSS().LayDSCTPhieu(dgvCTPhieu, lblMaPhieu.Text);
        }

        private void cbbSoLuong_ValueChanged(object sender, EventArgs e)
        {
            lblThanhTienCTphieu.Text = (float.Parse(txtDonGia.Text) * (int)cbbSoLuong.Value).ToString();
        }

        

        private void dgvCTPhieu_DataSourceChanged(object sender, EventArgs e)
        {
            
            float sum = 0;
            for (int i = 0; i < dgvCTPhieu.RowCount; i++)
            {
                if (dgvCTPhieu.Rows[i].Cells[2].Value.ToString() == cbbTenSach.Text)
                {
                    sum = float.Parse(lblThanhTien.Text);

                }
                sum += float.Parse(dgvCTPhieu.Rows[i].Cells[5].Value.ToString());
            }
            lblThanhTien.Text = sum.ToString();


            string[] spit = lblThue.Text.Split('%');
            TienThue = sum * (float)0.05;
            lblTienThue.Text = TienThue.ToString();
            lblTongtien.Text = (sum + TienThue).ToString();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //new PhieuNhapBUSS().UpdatePhieuNhap(lblMaPhieu.Text, lblThanhTien.Text,lblThue.Text, lblTienThue.Text, lblTongtien.Text);
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            new PhieuNhapBUSS().ThemPhieu(lblMaPhieu.Text, Id, "0", "0", "0", "0");

            new PhieuNhapBUSS().UpdatePhieuNhap(lblMaPhieu.Text, lblThanhTien.Text, lblThue.Text, lblTienThue.Text, lblTongtien.Text);

            for (int i = 0; i < dgvCTPhieu.RowCount; i++)
            {
                new CT_PhieuNhapBUSS().ThemCT_Phieu(lblMaPhieu.Text, dgvCTPhieu.Rows[i].Cells[1].Value.ToString(), dgvCTPhieu.Rows[i].Cells[2].Value.ToString(), dgvCTPhieu.Rows[i].Cells[3].Value.ToString(), dgvCTPhieu.Rows[i].Cells[4].Value.ToString(), dgvCTPhieu.Rows[i].Cells[5].Value.ToString(), dgvCTPhieu.Rows[i].Cells[6].Value.ToString());
            }

            this.Close();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            new frmThemOrEditSach(null,null).ShowDialog();
        }

        private void lblThanhTienCTphieu_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDonGia.Text) || string.IsNullOrEmpty(cbbSoLuong.ToString()))
            {
                lblThanhTienCTphieu.Text = ((float)0 * (int)cbbSoLuong.Value).ToString();
            }
            else
            {
                lblThanhTienCTphieu.Text = (float.Parse(txtDonGia.Text) * (int)cbbSoLuong.Value).ToString();
            }
            
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            new frmThemNXB(null).ShowDialog();
            cbbNXB.DataSource = new NXBBUSS().ListNXB();
            cbbNXB.DisplayMember = Constant.NXB_NAME;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }
    }
}
