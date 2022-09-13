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
    public class LoaiDAL
    {

        public List<Loai> LayLoai()
        {
            return new DataSQL().Loai("SelectLoai");
        }
        //*****/
        public void LayLoaiDAL(DataGridView data, string key)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@key",
                Value = key
            });
            data.DataSource = new DataSQL().selectData("[SelectAllLoai]", list);
        }

        public int ThemLoaiDAL(string MaLoai, string TenLoai)
        {
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                Key = "@TenLoai",
                Value = TenLoai
            });

            parameters.Add(new CustomParameter()
            {
                Key = "@MaLoai",
                Value = MaLoai
            });
            return new DataSQL().Execute("[InsertLoai]", parameters);
        }

        public int SuaLoaiDAL(string MaLoai, string TenLoai)
        {
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                Key = "@TenLoai",
                Value = TenLoai
            });

            parameters.Add(new CustomParameter()
            {
                Key = "@MaLoai",
                Value = MaLoai
            });
            return new DataSQL().Execute("[UpdateLoai]", parameters);
        }

        public int XoaLoaiDAL(string Maloai, DateTime dt)
        {
            List<CustomParameter> parameter = new List<CustomParameter>();
            parameter.Add(new CustomParameter()
            {
                Key = "@MaLoai",
                Value = Maloai
            });
            parameter.Add(new CustomParameter()
            {
                Key = "@ngaysexoa",
                Value = dt.ToString("yyyy/MM/dd")

            });
            return new DataSQL().Execute("XoaLoai", parameter);
        }

        public int LayLaiDAL(string id)
        {
            List<CustomParameter> parameter = new List<CustomParameter>();
            parameter.Add(new CustomParameter()
            {
                Key = "@Key",
                Value = id
            });
            return new DataSQL().Execute("LayLaiLoai", parameter);
        }

        public DataRow LayLoai(string maloai)
        {
            return new DataSQL().Select("LayRa1MaLoai '" + maloai + "'");
        }

        public void DSXOALOAI(DataGridView data, string key)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@key",
                Value = key
            });
            data.DataSource = new DataSQL().selectData("[SelectAllLSLoai]", list);
        }
       
    }
}
