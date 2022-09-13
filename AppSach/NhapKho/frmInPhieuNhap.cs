using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUSS;

namespace AppSach.NhapKho
{
    public partial class frmInPhieuNhap : Form
    {
        public string TenNV;
        public string NgayLapPhieu;
        public string MaPhieu;

        public frmInPhieuNhap(string TenNV,string NgayLapPhieu,string MaPhieu)
        {
            InitializeComponent();
            this.TenNV = TenNV;
            this.NgayLapPhieu = NgayLapPhieu;
            this.MaPhieu = MaPhieu;
        }

        private void frmInPhieuNhap_Load(object sender, EventArgs e)
        {
            try
            {
                repPhieuNhap.LocalReport.ReportEmbeddedResource = "AppSach.NhapKho.ReportPhieuNhap.rdlc";
                this.repPhieuNhap.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", new PhieuNhapBUSS().REPORT_Phieu(MaPhieu)));
                Microsoft.Reporting.WinForms.ReportParameter[] reportParameters = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("paNhanVien",TenNV),
                    new Microsoft.Reporting.WinForms.ReportParameter("paNgayTao",NgayLapPhieu),
                    new Microsoft.Reporting.WinForms.ReportParameter("paMaPhieu",MaPhieu)

                };
                repPhieuNhap.LocalReport.SetParameters(reportParameters);
                repPhieuNhap.RefreshReport();
            }
            catch (Exception ex)
            {
                MsgBoxcs.Show(ex.Message, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Error);
            }
            this.repPhieuNhap.RefreshReport();
        }
    }
}
