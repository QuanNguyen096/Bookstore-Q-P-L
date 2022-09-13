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
    public class KhachHangBUSS
    {
        public void DSKH(DataGridView data, string key)
        {
            string
            Key = key;
            new KhachHangDAL().DSKH(data, key);
        }
        public int ThemBUSS(string maso, string tenkh, string gioitinh, string lienhe, string diachi, DateTime dateNgSinh)
        {
            return new KhachHangDAL().Them(maso,tenkh,gioitinh,lienhe,diachi,dateNgSinh);
        }
        public int SuaBUSS(List<CustomParameter> pr)
        {
            return new KhachHangDAL().Sua(pr);
        }
        
       public int XoaBUSS(List<CustomParameter> pr)
        {
            return new KhachHangDAL().Xoa(pr);
        }

        public void DSKHDelBUSS(DataGridView data,string key)
        {
            string
            Key = key;
            new KhachHangDAL().DSKHDel(data, key);
        }
    }
}
