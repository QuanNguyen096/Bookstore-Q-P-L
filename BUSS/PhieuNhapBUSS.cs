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
    public class PhieuNhapBUSS
    {
        public void LayDSPhieuNhap(DataGridView data,string key)
        {
            new PhieuNhapDAL().LayDSPhieuNhap(data, key);
        }

        public DataTable REPORT_Phieu(string MaPhieu)
        {

            return new DAL.CT_PhieuNhapDAL().REPORT_PhieuNhap(MaPhieu);
        }

        public int DuyetPhieu(string MaPhieu)
        {
            return new PhieuNhapDAL().Duyetphieu(MaPhieu);
        }

        public int UpdatePhieuNhap(string MaPhieu,string ThanhTien,string Thue,string TienThue,string TongTien)
        {
            return new PhieuNhapDAL().UpdatePhieuNhap(MaPhieu, ThanhTien, Thue, TienThue, TongTien);
        }

        public int ThemPhieu(string MaPhieu, string MaNV, string TongTien, string Thue, string TienThue, string ThanhTien)
        {
            return new PhieuNhapDAL().ThemPhieuNhap(MaPhieu,MaNV,TongTien,Thue,TienThue, ThanhTien);
        }
    }
}
