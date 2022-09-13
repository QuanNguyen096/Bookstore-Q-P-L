using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSS;
using DTO;

namespace AppSach
{
    public partial class frmHoaDon : Form
    {
        public string TK;
        int Sum = 0;
        public string ID;

        public frmHoaDon(string id)
        {
          
            InitializeComponent();
            ID = id;
            
            AutoScaleMode = AutoScaleMode.Font;
            Constant.CustomElipGuna(nuSL);
            Constant.CustomElipGuna(cmbMaSach);
        }

        private DataTable DataTable = new DataTable();

        void LoadCTHD()
        {
            DataTable.Columns.Add("Mã Hóa Đơn", typeof(string));
            DataTable.Columns.Add("Tên Sách", typeof(string));
            DataTable.Columns.Add("Số Lượng", typeof(string));
            DataTable.Columns.Add("Đơn Giá", typeof(string));
            DataTable.Columns.Add("Thành Tiền", typeof(float));

            dgvHoaDon.DataSource = DataTable;

        }

        CT_HoaDonBUSS cT_HoaDonBUSS = new CT_HoaDonBUSS();
        
        private void btnLuuHD_Click(object sender, EventArgs e)
        {

            //new frmInHoaDon().ShowDialog(); 
            //MsgBoxcs.Show(Constant.SAVE_SUCCESSFULLY, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Info);
            btnTaoHoaDon.Enabled = true;
            btnThemSP.Enabled = false;
            btnStart.Enabled = false;
            btnLuuHD.Enabled = false;
            btnHuySP.Enabled = false;

            string[] split = lblDonGia.Text.Split('.');


            new HoaDonBUSS().ThemHDBUSS(lblMaHD.Text, int.Parse(ID), "1", txtKM.Text);

            new HoaDonBUSS().CapNhatHD(lblMaHD.Text,"",txtKM.Text,(Sum).ToString(),Constant.VAT);

            for (int i = 0; i < dgvHoaDon.RowCount-1; i++)
            {
                cT_HoaDonBUSS.ThemCTHD(lblMaHD.Text, dgvHoaDon.Rows[i].Cells[1].Value.ToString(), int.Parse(dgvHoaDon.Rows[i].Cells[2].Value.ToString()), dgvHoaDon.Rows[i].Cells[3].Value.ToString(), float.Parse(dgvHoaDon.Rows[i].Cells[4].Value.ToString())); ; 
            }


            for (int i = 0; i < dgvHoaDon.Rows.Count-1; i++)
            {
                new SachBUSS().UpdateSLSach("Xuat",dgvHoaDon.Rows[i].Cells[1].Value.ToString(), dgvHoaDon.Rows[i].Cells[2].Value.ToString());
            }

            new frmInHoaDon(lblMaHD.Text).ShowDialog();

            lblMaHD.Text = "0";
            lblTenSach.Text = string.Empty;
            lblDonGia.Text = string.Empty;
            lblTongTien.Text = "0";
            lblMax.Text = "0";
            Sum = 0;

            dgvHoaDon.DataSource = null;

            DataTable.Columns.Remove("Mã Hóa Đơn");
            DataTable.Columns.Remove("Tên Sách");
            DataTable.Columns.Remove("Số Lượng");
            DataTable.Columns.Remove("Đơn Giá");
            DataTable.Columns.Remove("Thành Tiền");
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            btnTaoHoaDon.Enabled = false;
            btnThemSP.Enabled = true;
            btnStart.Enabled = true;
            btnLuuHD.Enabled = true;
            btnHuySP.Enabled = true;

            Random rd = new Random();
            int dd = DateTime.Now.Day;
            int MM = DateTime.Now.Month;
            int yyyy = DateTime.Now.Year;
            int Ma =  dd + MM + yyyy + rd.Next(0, 100);

            cmbMaSach.DataSource = new SachBUSS().LaySach();
            cmbMaSach.DisplayMember = "MaSach";
            cmbMaSach.ValueMember = "MaSach";

            Constant.CusTomComBoBox(cmbMaSach);

            var r = SachBUSS.Lay1Sach(cmbMaSach.Text);

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"

            lblTenSach.Text = r["TenSach"].ToString();
            lblDonGia.Text = double.Parse(r["DonGia"].ToString()).ToString("#,### VND", cul.NumberFormat);
            lblMax.Text = r["SoLuong"].ToString();

            lblMaHD.Text = Ma.ToString();

            LoadCTHD();


            //new HoaDonBUSS().ThemHDBUSS(lblMaHD.Text,int.Parse(ID),"1", txtKM.Text);
        }
        private void LayMaSachQRorBarCode(string data)
        {
            cmbMaSach.Text = data;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            frmDocBarCode f = new frmDocBarCode();
            f.truyenMa = new frmDocBarCode.TruyenMa(LayMaSachQRorBarCode);
            f.ShowDialog();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
           this.AutoScaleMode=AutoScaleMode.Font;
            frmXuatHoaDon fr=new frmXuatHoaDon();
            fr.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            fr.ShowDialog();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            btnThemSP.Enabled = false;
            btnCapNhatSP.Enabled = false;
            btnLuuHD.Enabled = false;
            btnHuySP.Enabled = false;
            btnHuySP.Enabled = false;

            //cmbMaSach.DataSource = new SachBUSS().LaySach();
            //cmbMaSach.DisplayMember = "MaSach";
            //cmbMaSach.ValueMember = "MaSach";

            //var r = SachBUSS.Lay1Sach(cmbMaSach.Text);

            //CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"

            //lblTenSach.Text = r["TenSach"].ToString();
            //lblDonGia.Text = double.Parse(r["DonGia"].ToString()).ToString("#,### VND", cul.NumberFormat);
            //lblMax.Text = r["SoLuong"].ToString();


        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {

            int dong = -1;
            for(int i = 0; i< dgvHoaDon.Rows.Count-1; i++)
            {
                if (dgvHoaDon.DataSource == null)
                    break;
                if (cmbMaSach.Text == dgvHoaDon.Rows[i].Cells[1].Value.ToString())
                {
                    dong = dgvHoaDon.Rows[i].Index;
                    break;
                }
            }

            string[] split = lblDonGia.Text.Split('.');

            if (dong != -1)
            {
                DataGridViewRow dataGridViewRow = dgvHoaDon.Rows[dong];
                //cT_HoaDonBUSS.CapNhatCTHD(lblMaHD.Text, cmbMaSach.Text, (int)nuSL.Value);
                dataGridViewRow.Cells[2].Value = int.Parse(dataGridViewRow.Cells[2].Value.ToString()) + (int)nuSL.Value;
                dataGridViewRow.Cells[4].Value = float.Parse(dataGridViewRow.Cells[3].Value.ToString()) * float.Parse(dataGridViewRow.Cells[2].Value.ToString());

            }
            else
            {
                DataTable.Rows.Add(lblMaHD.Text, cmbMaSach.Text, (int)nuSL.Value, split[0] + "000", float.Parse(split[0] + "000") * (int)nuSL.Value);
               
               
            }

            //dgvHoaDon.DataSource = null;
            //new CT_HoaDonBUSS().LayCTHDDAL(dgvHoaDon, lblMaHD.Text);

            int sum = 0;
            for (int i = 0; i < dgvHoaDon.Rows.Count-1; ++i)
            {
                string[] a = dgvHoaDon.Rows[i].Cells[3].Value.ToString().Split(',');
                
                sum += Convert.ToInt32(a[0]) * int.Parse(dgvHoaDon.Rows[i].Cells[2].Value.ToString());
            }
            lblTongTien.Text = string.Format("{0} VND",sum);
            Sum = sum;
        }

        private void cmbMaSach_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var r = SachBUSS.Lay1Sach(cmbMaSach.Text);

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"

            lblTenSach.Text = r["TenSach"].ToString();
            lblDonGia.Text = double.Parse(r["DonGia"].ToString()).ToString("#,### VND", cul.NumberFormat);
            lblMax.Text = r["SoLuong"].ToString();
        }

        private void btnHuySP_Click(object sender, EventArgs e)
        {
            MsgBoxcs.Show(Constant.DESTRUCT_SUCCESSFULLY, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Info);
            btnTaoHoaDon.Enabled = true;
            btnThemSP.Enabled = false;
            btnStart.Enabled = false;
            btnLuuHD.Enabled = false;
            btnHuySP.Enabled = false;

            new CT_HoaDonBUSS().XoaCTHD(lblMaHD.Text);
            new HoaDonBUSS().XoaHD(lblMaHD.Text);

            lblMaHD.Text = "0";
            lblTenSach.Text = string.Empty;
            lblDonGia.Text = string.Empty;
            dgvHoaDon.DataSource = null;

            cmbMaSach.DataSource = null;


            DataTable.Columns.Remove("Mã Hóa Đơn");
            DataTable.Columns.Remove("Tên Sách");
            DataTable.Columns.Remove("Số Lượng");
            DataTable.Columns.Remove("Đơn Giá");
            DataTable.Columns.Remove("Thành Tiền");

        }

        private void cmbMaSach_TextChanged(object sender, EventArgs e)
        {
            var r = SachBUSS.Lay1Sach(cmbMaSach.Text);

            if (r == null)
                return;

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"

            lblTenSach.Text = r["TenSach"].ToString();
            lblDonGia.Text = double.Parse(r["DonGia"].ToString()).ToString("#,### VND", cul.NumberFormat);
            lblMax.Text = r["SoLuong"].ToString();

            nuSL.Maximum = decimal.Parse(lblMax.Text);
        }
    }
}
