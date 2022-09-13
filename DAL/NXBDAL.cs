using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class NXBDAL
    {
     
        public List<NXB> ListNXB()
        {
            return new DataSQL().Nxb("[SelectNXB]");
        }
        public void Xem(DataGridView data, string key)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@key",
                Value = key
            });
            data.DataSource = new DataSQL().selectData("[SelectAllNXB]", list);
        }
        public int Them(string MaNXB, string TenNXB, string LienHe, string DiaChi)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@MANXB",
                Value = MaNXB
            });
            list.Add(new CustomParameter()
            {
                Key = "@TENNXB",
                Value = TenNXB
            });
            list.Add(new CustomParameter()
            {
                Key = "@LIENHE",
                Value = LienHe
            });
            list.Add(new CustomParameter()
            {
                Key = "@DIACHI",
                Value = DiaChi
            });
            return new DataSQL().Execute("INSERTNXB", list);
        }
        public int Xoa(string ID)
        {
            List<CustomParameter> parameter = new List<CustomParameter>();

            parameter.Add(new CustomParameter()
            {
                Key = "@Key",
                Value = ID
            });
            return new DataSQL().Execute("DELETENXB", parameter);
        }
        public int Sua(string MaNXB, string TenNXB, string LienHe, string DiaChi)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@MANXB",
                Value = MaNXB
            });
            list.Add(new CustomParameter()
            {
                Key = "@TENNXB",
                Value = TenNXB
            });
            list.Add(new CustomParameter()
            {
                Key = "@LIENHE",
                Value = LienHe
            });
            list.Add(new CustomParameter()
            {
                Key = "@DIACHI",
                Value = DiaChi
            });
            return new DataSQL().Execute("UpdateNXB", list);
        }

        public int LayLaiDAL(string id)
        {
            List<CustomParameter> parameter = new List<CustomParameter>();
            parameter.Add(new CustomParameter()
            {
                Key = "@Key",
                Value = id
            });
            return new DataSQL().Execute("LayLaiNXB", parameter);
        }

        public void DSXOANXB(DataGridView data, string key)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@key",
                Value = key
            });
            data.DataSource = new DataSQL().selectData("[SelectAllLSNXB]", list);
        }

        //lay du lieu
        public static DataRow LayNXB(string id)
        {
            return new DataSQL().Select("LAYRA1NXB '" + id + "'");
        }
    }
}
