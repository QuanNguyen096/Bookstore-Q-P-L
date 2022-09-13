using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Windows.Forms;

namespace BUSS
{
    public class CT_PhieuNhapBUSS
    {
        public void LayDSCTPhieu(DataGridView data, string key)
        {
            new CT_PhieuNhapDAL().LayDSCT_Phieu(data, key);
        }
        public int ThemCT_Phieu(string MaPhieu, string TenSach, string MaNXB, string DonGia, string SoLuong, string ThanhTien,string TrangThai)
        {
            return new CT_PhieuNhapDAL().ThemCT_Phieu(MaPhieu, TenSach, MaNXB, DonGia, SoLuong, ThanhTien,TrangThai);
        }

        public int UpdateCTPhieuNhap(string MaPhieu,string TenSach,string SoLuong)
        {
            return new CT_PhieuNhapDAL().UpdatePhieuNhap(MaPhieu, TenSach, SoLuong);
        }
    }
}
