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
    public class HoaDonDAL
    {
        public int ThemHD(string MaHD, int ID, string MaKH,string MaKM)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter()
            {
                Key = "@MaHD",
                Value = MaHD
            });

            pr.Add(new CustomParameter()
            {
                Key = "@ID",
                Value = ID.ToString()
            });
            pr.Add(new CustomParameter()
            {
                Key = "@MaKH",
                Value = MaKH
            });
            pr.Add(new CustomParameter()
            {
                Key = "@MaKM",
                Value = MaKM
            });
            pr.Add(new CustomParameter()
            {
                Key = "@ThanhTien",
                Value = "0"
            });
            pr.Add(new CustomParameter()
            {
                Key = "@VAT",
                Value = ""
            });
            pr.Add(new CustomParameter()
            {
                Key = "@TienThue",
                Value = "0"
            });
            pr.Add(new CustomParameter()
            {
                Key = "@TongTien",
                Value = "0"
            });

            return new DataSQL().Execute("[InsertHD]", pr);
        }

        public int XoaHD(string MaHD)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter() { Key = @"key",Value = MaHD });

            return new DataSQL().Execute("[XoaHD]", pr);
        }

        public int CapNhatHD(string MaHD,string MaKH,string MaKM,string ThanhTien,string VAT)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter() { Key = @"MaHD", Value = MaHD });
            pr.Add(new CustomParameter() { Key = @"MaKH", Value = MaKH });
            pr.Add(new CustomParameter() { Key = @"MaKM", Value = MaKM });
            pr.Add(new CustomParameter() { Key = @"ThanhTien", Value = ThanhTien });
            pr.Add(new CustomParameter() { Key = @"VAT", Value = VAT });



            return new DataSQL().Execute("[UpdateHD]", pr);
        }

        public void ReportDSHD(DataGridView data,string TuNgay,string DenNgay)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@TuNgay",
                Value = TuNgay
            });
            list.Add(new CustomParameter()
            {
                Key = "@DenNgay",
                Value = DenNgay
            });
                data.DataSource = new DataSQL().selectData("[ReportDSHD]", list);
        }

        public DataTable REPORT_DSHoaDon(string TuNgay,string DenNgay)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter() { Key = @"TuNgay", Value = TuNgay });
            list.Add(new CustomParameter() { Key = @"DenNgay", Value = DenNgay });

            return new DAL.DataSQL().selectData("[ReportDSHD]", list);
        }
    }
}
