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
    public partial class frmSachGanHet : Form
    {
        public frmSachGanHet()
        {
            InitializeComponent();
        }

        private void frmSachGanHet_Load(object sender, EventArgs e)
        {
            try
            {
                repSachGanHet.LocalReport.ReportEmbeddedResource = "AppSach.BaoCaoThongKe.ReportSachGanHet.rdlc";
                this.repSachGanHet.LocalReport.DataSources.Add(new ReportDataSource("DataSachGanHet", new SachBUSS().REPORT_SachGanHet()));

                repSachGanHet.RefreshReport();
            }
            catch (Exception ex)
            {
                MsgBoxcs.Show(ex.Message, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Error);
            }
            this.repSachGanHet.RefreshReport();
        }
    }
}
