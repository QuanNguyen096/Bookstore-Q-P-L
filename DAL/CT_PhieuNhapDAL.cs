using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class CT_PhieuNhapDAL
    {
        public void LayDSCT_Phieu(DataGridView data, string key)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter() { Key = @"key", Value = key });

            data.DataSource = new DataSQL().selectData("[SelectAllCTPhieu]", pr);
        }

        public DataTable REPORT_PhieuNhap(string MaPhieu)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter() { Key = @"MaPhieu", Value = MaPhieu });
            return new DAL.DataSQL().selectData("[ReportPhieuNhap]",pr);
        }

        public int ThemCT_Phieu(string MaPhieu,string TenSach,string MaNXB,string DonGia,string SoLuong,string ThanhTien,string TrangThai)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter() { Key = @"MaPhieu", Value = MaPhieu });
            pr.Add(new CustomParameter() { Key = @"TenSach", Value = TenSach });
            pr.Add(new CustomParameter() { Key = @"MaNXB", Value = MaNXB });
            pr.Add(new CustomParameter() { Key = @"DonGia", Value = DonGia });
            pr.Add(new CustomParameter() { Key = @"SoLuong", Value = SoLuong });
            pr.Add(new CustomParameter() { Key = @"ThanhTien", Value = ThanhTien });
            pr.Add(new CustomParameter() { Key = @"TrangThai", Value = TrangThai });

            return new DataSQL().Execute("[InsertCTPhieu]", pr);
        }

        public int UpdatePhieuNhap(string MaPhieu, string TenSach, string SoLuong)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter() { Key = @"MaPhieu", Value = MaPhieu });
            pr.Add(new CustomParameter() { Key = @"TenSach", Value = TenSach });
            pr.Add(new CustomParameter() { Key = @"SoLuong", Value = SoLuong });

            return new DataSQL().Execute("[UpdateCTPhieuNhap]", pr);
        }
    }
}
