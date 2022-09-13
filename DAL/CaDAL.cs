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
    public class CaDAL
    {
        public List<Ca> LayCaCMB()
        {
            return new DataSQL().Ca("SelectAllCaList");
        }
        public void LayDSCA(DataGridView data, string key)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@key",
                Value = key
            });
            data.DataSource = new DataSQL().selectData("[SelectAllCa]", list);
        }
        public DataRow Lay1Ca(string id)
        {
            return new DataSQL().Select("[Select1Ca] '" + id + "'");
        }
        public int Sua(string maca,string tenca,string mota,string thoigian)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter()
            {
                Key = "@Key",
                Value = maca
            });
            pr.Add(new CustomParameter()
            {
                Key = "@TenCa",
                Value = tenca
            });
            pr.Add(new CustomParameter()
            {
                Key = "@MoTa",
                Value = mota
            });
            pr.Add(new CustomParameter()
            {
                Key = "@ThoiGian",
                Value = thoigian
            });
            return new DataSQL().Execute("[UpdateCa]", pr);
        }
    }
}
