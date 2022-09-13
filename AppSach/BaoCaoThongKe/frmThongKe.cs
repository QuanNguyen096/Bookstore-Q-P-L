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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
            Constant.CustomElipGuna(dtpTuNgay);
            Constant.CustomElipGuna(dtpDenNgay);

        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            new HoaDonBUSS().ReportDSHD(dgvBaoCaoDT, dtpTuNgay.Value.ToShortDateString(), dtpDenNgay.Value.ToShortDateString());
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MsgBoxcs.Show(Constant.Error_Time, Constant.NOTIFICATION, MsgBoxcs.Buttons.OK, MsgBoxcs.Icon.Error);
                return;
            }
            new HoaDonBUSS().ReportDSHD(dgvBaoCaoDT, dtpTuNgay.Value.ToShortDateString(), dtpDenNgay.Value.ToShortDateString());

        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            new frmBaoCaoDoanhThu(dtpTuNgay.Value.ToShortDateString(),dtpDenNgay.Value.ToShortDateString()).ShowDialog();
        }

       

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if(radTatCa.Checked)
                new SachBUSS().ReportSach(dgvBaoCaoSP);

            if(radBanChay.Checked)
                new SachBUSS().ReportSachBanChay(dgvBaoCaoSP);

            if(radGanHet.Checked)
                new SachBUSS().ReportSachGanHet(dgvBaoCaoSP);
        }

        private void btnXuatBaoCaoSP_Click(object sender, EventArgs e)
        {
            if (radTatCa.Checked)
                new Sach.inDSSP().ShowDialog();
            
            if (radBanChay.Checked)
                new AppSach.BaoCaoThongKe.frmBaoCaoSach().ShowDialog();

            if (radGanHet.Checked)
                new AppSach.BaoCaoThongKe.frmSachGanHet().ShowDialog();
        }
    }
}
