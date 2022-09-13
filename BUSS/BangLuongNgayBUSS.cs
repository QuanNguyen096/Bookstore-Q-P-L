using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Windows.Forms;

namespace BUSS
{
    public class BangLuongNgayBUSS
    {
        public void BangLuongNgay(DataGridView data, string key,string ca,string dd,string mm,string yyyy)
        {
             new BangLuongNgayDAL().BangLuongNgay(data, key,ca,dd,mm,yyyy);
        }
    }
}
