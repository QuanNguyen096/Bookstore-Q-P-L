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
using Microsoft.Reporting.WinForms;

namespace AppSach
{
    public partial class frmBaoCaoDoanhThu : Form
    {
        public string TuNgay;
        public string DenNgay;
        public frmBaoCaoDoanhThu(string TuNgay,string DenNgay)
        {
            InitializeComponent();
            this.TuNgay = TuNgay;
            this.DenNgay = DenNgay;
        }

        private void frmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            try
            {
                repDSHD.LocalReport.ReportEmbeddedResource = "AppSach.BaoCaoThongKe.DSHD.rdlc";
                this.repDSHD.LocalReport.DataSources.Add(new ReportDataSource("DataDSHD", new HoaDonBUSS().REPORT_DSHoaDon(TuNgay, DenNgay)));
                Microsoft.Reporting.WinForms.ReportParameter[] reportParameters = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("paTuNgay",TuNgay),
                    new Microsoft.Reporting.WinForms.ReportParameter("paDenNgay",DenNgay)
                };
                repDSHD.LocalReport.SetParameters(reportParameters);
                repDSHD.RefreshReport();
            }
            catch (Exception ex)
            {
                MsgBoxcs.Show(ex.Message, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Error);
            }
            this.repDSHD.RefreshReport();
        }
    }
}
