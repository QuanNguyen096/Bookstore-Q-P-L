using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
namespace BUSS
{
    public class LuongThangBUS
    {
        public void DSLuongThang(DataGridView data,string MM,string YYYY, string key)
        {
            new LuongThangDAL().DSLuongThang(data,MM,YYYY,key);
        }
        public int InsertData()
        {
            return new LuongThangDAL().InsertData();
        }
    }
}
