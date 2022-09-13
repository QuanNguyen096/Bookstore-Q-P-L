using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class BangLuongNgayDAL
    {
        public void BangLuongNgay(DataGridView data, string key,string ca,string dd,string mm,string yyyy)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@key",
                Value = key
            });
            list.Add(new CustomParameter()
            {
                Key = "@ca",
                Value = ca
            });
            list.Add(new CustomParameter()
            {
                Key = "@day",
                Value = dd
            });
            list.Add(new CustomParameter()
            {
                Key = "@month",
                Value = mm
            });
            list.Add(new CustomParameter()
            {
                Key = "@year",
                Value = yyyy
            });
            data.DataSource = new DataSQL().selectData("SelectLuongNgayNV", list);
        }
    }
}
