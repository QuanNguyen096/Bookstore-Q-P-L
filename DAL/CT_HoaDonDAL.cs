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
    public class CT_HoaDonDAL
    {
        public void LayCTHDDAL(DataGridView data, string key)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@key",
                Value = key
            });
            data.DataSource = new DataSQL().selectData("[SelectAllCTHD]", list);
        }

        public int ThemCTHD(string MaHD,string MaSach,int Soluong, string DonGia,float ThanhTien)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter()
            { Key = @"MaHD", Value = MaHD });
            pr.Add(new CustomParameter()
            { Key = @"MaSach", Value = MaSach });
            pr.Add(new CustomParameter()
            { Key = @"SoLuong", Value = Soluong.ToString() });
            pr.Add(new CustomParameter()
            { Key = @"DonGia", Value = DonGia.ToString() });
            pr.Add(new CustomParameter()
            { Key = @"ThanhTien", Value = ThanhTien.ToString() });

            return new DataSQL().Execute("[InsertCTHD]", pr);
        }

        public int XoaCTHD(string MaHD)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter() { Key = @"key", Value = MaHD });

            return new DataSQL().Execute("[XoaCTHD]", pr);
        }

        public int CapNhatCTHD(string MaHD,string MaSach,int SoLuong)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter() { Key = @"MaHD", Value = MaHD });
            pr.Add(new CustomParameter() { Key = @"MaSach",Value = MaSach });
            pr.Add(new CustomParameter() { Key = @"SoLuong", Value = SoLuong.ToString() });

            return new DataSQL().Execute("[UpdateCTHD]", pr);

        }

        public DataTable REPORT_HoaDon(string MaHD)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@MaHD",
                Value = MaHD
            });
            return new DAL.DataSQL().selectData("[ReportHoaDon]",list);
        }

        #region Phong

        #endregion
    }
}
