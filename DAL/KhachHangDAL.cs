using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class KhachHangDAL
    {
        public void DSKH(DataGridView data,string key)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@key",
                Value = key
            });
            data.DataSource = new DataSQL().selectData("SelectAllKH", list);
        }
        public int Them(string maso, string tenkh, string gioitinh, string lienhe, string diachi,DateTime dateNgSinh)
        {
            List<CustomParameter> pr = new List<CustomParameter>();

            pr.Add(new CustomParameter()
            {
                Key = "@MaKH",
                Value = maso
            }) ;
            pr.Add(new CustomParameter()
            {
                Key = "@TenKH",
                Value = tenkh
            });
            pr.Add(new CustomParameter()
            {
                Key = "@GioiTinh",
                Value = gioitinh
            });
            pr.Add(new CustomParameter()
            {
                Key = "@LienHe",
                Value = lienhe
            });
            pr.Add(new CustomParameter()
            {
                Key = "@DiaChi",
                Value = diachi
            });
            pr.Add(new CustomParameter()
            {
                Key = "@NgaySinh",
                Value = dateNgSinh.ToString("yyyy/MM/dd")
            });
            return new DataSQL().Execute("InsertKH", pr);
        }
        public int Sua(List<CustomParameter> pr)
        {
            return new DataSQL().Execute("UpdateKH", pr);
        }
        public int Xoa(List<CustomParameter> pr)
        {
            return new DataSQL().Execute("DelKH", pr);
        }

        public void DSKHDel(DataGridView data, string key)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@key",
                Value = key
            });
            data.DataSource = new DataSQL().selectData("[SelectAllKHDEL]", list);
        }
    }
}
