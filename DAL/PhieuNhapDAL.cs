using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class PhieuNhapDAL
    {
        public int ThemPhieuNhap(string MaPhieu,string MaNV,string TongTien,string Thue,string TienThue, string ThanhTien)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter()
            {
                Key =@"MaPhieu",
                Value = MaPhieu
            });
            pr.Add(new CustomParameter()
            {
                Key = @"MaNV",
                Value = MaNV
            });
            pr.Add(new CustomParameter()
            {
                Key = @"ThanhTien",
                Value = ThanhTien
            });
            pr.Add(new CustomParameter()
            {
                Key = @"Thue",
                Value = Thue
            });
            pr.Add(new CustomParameter()
            {
                Key = @"TienThue",
                Value = TienThue
            });
            pr.Add(new CustomParameter()
            {
                Key = @"TongTien",
                Value = TongTien
            });
            

            return new DataSQL().Execute("[InsertPhieuNhap]", pr);
        }

        public int Duyetphieu(string MaPhieu)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter() { Key = @"MaPhieu", Value = MaPhieu });
            return new DataSQL().Execute("[DuyetPhieu]", pr);
        }

        public int UpdatePhieuNhap(string MaPhieu,string ThanhTien,string Thue,string TienThue,string TongTien)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter() { Key = @"MaPhieu", Value = MaPhieu });
            pr.Add(new CustomParameter() { Key = @"ThanhTien", Value = ThanhTien });
            pr.Add(new CustomParameter() { Key = @"Thue", Value = Thue });
            pr.Add(new CustomParameter() { Key = @"TienThue", Value = TienThue });
            pr.Add(new CustomParameter() { Key = @"TongTien", Value = TongTien });

            return new DataSQL().Execute("[UpdatePhieuNhap]", pr);

        }
        public void LayDSPhieuNhap(DataGridView data, string key)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter() { Key = @"Key", Value = key });

            data.DataSource = new DataSQL().selectData("[SelectAllPhieu]", pr);
        }

          
    }
}
