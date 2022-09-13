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
    public class SachDAL
    {
        public List<SachDTO> LaySach()
        {
            return new DataSQL().Sach("SelectSach");
        }

        #region Report
        public DataTable REPORT_Sach()
        {
            
            return new DAL.DataSQL().selectData("[ReportSach]");
        }

        public void ReportSach(DataGridView data)
        {
            
            data.DataSource = new DataSQL().selectData("[ReportSach]");
        }

        public DataTable REPORT_SachBanChay()
        {
            return new DataSQL().selectData("[ReportSPBanChay]");
        }

        public void ReportSachBanChay(DataGridView data)
        {
            data.DataSource = new DataSQL().selectData("[ReportSPBanChay]");
        }

        public DataTable REPORT_SachGanHet()
        {
            return new DataSQL().selectData("[ReportSPGanHet]");
        }

        public void ReportSachGanHet(DataGridView data)
        {
            
            data.DataSource = new DataSQL().selectData("[ReportSPGanHet]");
        }
        #endregion

        public void LaySachDAL(DataGridView data, string key)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@key",
                Value = key
            });
            data.DataSource = new DataSQL().selectData("[SelectAllSach]", list);
        }

        public DataTable LaySachDAL(string key)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@key",
                Value = key
            });
            return new DataSQL().selectData("[ReportSach]", list);
        }
        //string MaSach,string MaLoai,string MaNXB,string Anh,string TenSach,string TenTG,string SoLuong,string DonGia,string MoTa
        public int Them(string MS, string Anh, string Loai,string MaNXB, string TenSach, string TenTg, string SoLuong, string DonGia, string MoTa)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter()
            {
                Key = "@Key",
                Value = MS
            });
            pr.Add(new CustomParameter()
            {
                Key = "@Anh",
                Value = Anh
            });
            pr.Add(new CustomParameter()
            {
                Key = "@MaLoai",
                Value = Loai
            });
            pr.Add(new CustomParameter()
            {
                Key = "@MaNXB",
                Value = MaNXB
            });
            pr.Add(new CustomParameter()
            {
                Key = "@TenSach",
                Value = TenSach
            });
            pr.Add(new CustomParameter()
            {
                Key = "@TenTG",
                Value = TenTg
            });
            pr.Add(new CustomParameter()
            {
                Key = "@SoLuong",
                Value = SoLuong
            });
            pr.Add(new CustomParameter()
            {
                Key = "@DonGia",
                Value = DonGia
            });
            pr.Add(new CustomParameter()
            {
                Key = "@MoTa",
                Value = MoTa
            });
            return new DataSQL().Execute("[InsertSach]", pr);
        }
        public int Sua(string MS, string Anh, string Loai, string MaNXB, string TenSach, string TenTg, string SoLuong, string DonGia, string MoTa)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter()
            {
                Key = "@Key",
                Value = MS
            });
            pr.Add(new CustomParameter()
            {
                Key = "@Anh",
                Value = Anh
            });
            pr.Add(new CustomParameter()
            {
                Key = "@MaLoai",
                Value = Loai
            });
            pr.Add(new CustomParameter()
            {
                Key = "@MaNXB",
                Value = MaNXB
            });
            pr.Add(new CustomParameter()
            {
                Key = "@TenSach",
                Value = TenSach
            });
            pr.Add(new CustomParameter()
            {
                Key = "@TenTG",
                Value = TenTg
            });
            pr.Add(new CustomParameter()
            {
                Key = "@SoLuong",
                Value =SoLuong
            });
            pr.Add(new CustomParameter()
            {
                Key = "@DonGia",
                Value = DonGia
            });
            pr.Add(new CustomParameter()
            {
                Key = "@MoTa",
                Value = MoTa
            });
            return new DataSQL().Execute("[UpdateSach]", pr);
        }
        public int Xoa(string ID)
        {
            List<CustomParameter> parameter = new List<CustomParameter>();
            parameter.Add(new CustomParameter()
            {
                Key = "@Key",
                Value = ID
            });
            return new DataSQL().Execute("[XoaSach]", parameter);
        }
        public int Restore(string id)
        {
            List<CustomParameter> parameter = new List<CustomParameter>();
            parameter.Add(new CustomParameter()
            {
                Key = "@Key",
                Value = id
            });
            return new DataSQL().Execute("[LayLaiSach]", parameter);
        }

        public DataRow Lay1Sach(string id)
        {
            return new DataSQL().Select("[Select1Sach] '" + id + "'");
        }

        public void DSXOASACH(DataGridView data, string key)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@key",
                Value = key
            });
            data.DataSource = new DataSQL().selectData("[SelectAllLSXoaSach]", list);
        }

        public int UpdateSLSach(string Key,string MaSach,string SoLuong)
        {
            List <CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter() { Key = @"Key", Value = Key });
            list.Add(new CustomParameter() { Key = @"MaSach",Value = MaSach});
            list.Add(new CustomParameter() { Key = @"SoLuong", Value = SoLuong });

            return new DataSQL().Execute("[UpdateSLSach]",list);
        }

    }
}
