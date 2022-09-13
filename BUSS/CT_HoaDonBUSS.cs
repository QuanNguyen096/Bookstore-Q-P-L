using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using System.Data;

namespace BUSS
{
    public class CT_HoaDonBUSS
    {
        public void LayCTHDDAL(DataGridView data, string key)
        {
            new CT_HoaDonDAL().LayCTHDDAL(data, key);
        }

        public int ThemCTHD(string MaHD, string MaSach, int Soluong, string DonGia,float ThanhTien)
        {
            return new CT_HoaDonDAL().ThemCTHD(MaHD, MaSach, Soluong, DonGia,ThanhTien);
        }

        public int XoaCTHD(string MaHD)
        {
            return new CT_HoaDonDAL().XoaCTHD(MaHD);
        }

        public int CapNhatCTHD(string MaHD,string MaSach, int SoLuong)
        {
            return new CT_HoaDonDAL().CapNhatCTHD(MaHD,MaSach, SoLuong);
        }

        public DataTable REPORT_HoaDon(string MaHD)
        {
            return new DAL.CT_HoaDonDAL().REPORT_HoaDon(MaHD);
        }
    }
}
