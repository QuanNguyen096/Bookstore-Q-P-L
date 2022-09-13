using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUSS
{
    public class DoiMatKhau
    {
        
        public int UpdateNewPassword(string ID,string MK, string NewPassword, string CCCD)
        {
            return new DAL.DoiMatKhau().UpdatePassword(ID, MK, NewPassword, CCCD);
        }
    }
}
