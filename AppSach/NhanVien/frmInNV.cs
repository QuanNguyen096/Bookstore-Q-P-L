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
using BUSS;
using DTO;
namespace AppSach.NhanVien
{
    public partial class frmInNV : Form
    {
        public frmInNV()
        {
            InitializeComponent();
        this.StartPosition=FormStartPosition.CenterScreen;
            Constant.CustomDrag(reportViewer1);
        }

        private void frmInNV_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "AppSach.ReportNhanVien.rdlc";
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("RSNV", new NhanVienBUSS().REPORT_NV()));
            }catch (Exception ex)
            {
                MsgBoxcs.Show(ex.Message, Constant.THONGBAO, MsgBoxcs.Buttons.OKCancel, MsgBoxcs.Icon.Error);
            }
            //reportViewer1.ZoomMode = ZoomMode.Percent;
            //reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
