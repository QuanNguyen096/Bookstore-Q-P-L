using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Windows.Forms;

namespace BUSS
{
    public class HoaDonBUSS
    {
        public int ThemHDBUSS(string MaHD, int ID, string TenKH, string MaKM)
        {
            return new HoaDonDAL().ThemHD(MaHD,ID,TenKH,MaKM);
        }

        public int XoaHD(string MaHD)
        {
            return new HoaDonDAL().XoaHD(MaHD);
        }

        public int CapNhatHD(string MaHD, string MaKH, string MaKM, string ThanhTien,string VAT)
        {
            return new HoaDonDAL().CapNhatHD(MaHD, MaKH, MaKM, ThanhTien,VAT);
        }

        public void ReportDSHD(DataGridView data,string TuNgay, string DenNgay)
        {
            new HoaDonDAL().ReportDSHD(data,TuNgay, DenNgay);
        }

        public DataTable REPORT_DSHoaDon(string TuNgay,string DenNgay)
        {
            return new DAL.HoaDonDAL().REPORT_DSHoaDon(TuNgay,DenNgay);
        }
    }
}
