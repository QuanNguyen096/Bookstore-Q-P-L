using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DoiMatKhau
    {
        public int UpdatePassword(string ID, string MK, string NewPassword, string CCCD)
        {
            List<CustomParameter>pr=new List<CustomParameter>();
            pr.Add(new CustomParameter()
            {
                Key = "@ID",
                Value = ID
            });
            pr.Add(new CustomParameter()
            {
                Key = "@CCCD",
                Value = CCCD
            });
            pr.Add(new CustomParameter()
            {
                Key = "@MK",
                Value = MK
            });
            pr.Add(new CustomParameter()
            {
                Key = "@MK2",
                Value = NewPassword
            });

            return new DataSQL().Execute("[DoiMKNV]", pr);
        }
    }
}
