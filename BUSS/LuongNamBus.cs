using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;using DAL;
using System.Windows.Forms;

namespace BUSS
{
    public class LuongNamBus
    {
        public void DSLuongNam(DataGridView data, string YYYY, string key)
        {
            new LuongNamDAL().DSLuongNam(data,YYYY,key);
        }
        public int InsertData()
        {
           return new LuongNamDAL().InsertData();
        }
    }
}
