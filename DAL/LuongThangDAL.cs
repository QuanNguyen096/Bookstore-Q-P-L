using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class LuongThangDAL
    {
        public void DSLuongThang(DataGridView data,string MM,string YYYY, string key)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter() { Key = "@key", Value = key });
            pr.Add(new CustomParameter() { Key = "@MM", Value = MM });
            pr.Add(new CustomParameter() { Key = "@Year", Value = YYYY });

            data.DataSource = new DataSQL().selectData("[SelectLuongThang]", pr);
        }
        public int InsertData()
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter() { Key = "@MM", Value = DateTime.Now.Month.ToString() });
            pr.Add(new CustomParameter() { Key = "@Year", Value = DateTime.Now.Year.ToString() });
            return new DataSQL().Execute("[InsertLuongThang]", pr);
        }
    }
}
