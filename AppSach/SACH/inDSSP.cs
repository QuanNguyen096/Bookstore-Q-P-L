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

namespace AppSach.Sach
{
    public partial class inDSSP : Form
    {
        public inDSSP()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void inDSSP_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "AppSach.BaoCaoThongKe.Sach.rdlc";
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSach", new SachBUSS().REPORT_Sach()));
            }
            catch (Exception ex)
            {
                MsgBoxcs.Show(ex.Message, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Error);
            }
            //reportViewer1.ZoomMode = ZoomMode.Percent;
            //reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }
    }
}
