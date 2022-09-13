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

namespace AppSach
{
    public partial class frmInHoaDon : Form
    {
        public string mahd;
        public frmInHoaDon(string MaHD)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            mahd = MaHD;
        }

        

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "AppSach.TaoHoaDon.rdlc";
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", new CT_HoaDonBUSS().REPORT_HoaDon(mahd)));
            }
            catch (Exception ex)
            {
                MsgBoxcs.Show(ex.Message, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Error);
            }
            //reportViewer1.ZoomMode = ZoomMode.Percent;
            //reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
