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

namespace AppSach.BaoCaoThongKe
{
    public partial class frmBaoCaoSach : Form
    {
        public frmBaoCaoSach()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSach_Load(object sender, EventArgs e)
        {
            try
            {
                repSachBanChay.LocalReport.ReportEmbeddedResource = "AppSach.BaoCaoThongKe.ReportSachBanChay.rdlc";
                this.repSachBanChay.LocalReport.DataSources.Add(new ReportDataSource("DataSachBanChay", new SachBUSS().REPORT_SachBanChay()));
                
                repSachBanChay.RefreshReport();
            }
            catch (Exception ex)
            {
                MsgBoxcs.Show(ex.Message, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Error);
            }
            this.repSachBanChay.RefreshReport();
        }
    }
}
