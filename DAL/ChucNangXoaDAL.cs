using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class ChucNangXoaDAL
    {
        public int Xoa(List<CustomParameter> pr)
        {
            return new DataSQL().Execute("XoaKMHTHan", pr);
        }
        public int XoaNV(List<CustomParameter> pr)
        {
            return new DataSQL().Execute("deleteNV7ngay", pr);
        }
        //---
        public int XoaLoai()
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter()
            {
                Key = "@Key",
                Value = " "
            });
            return new DataSQL().Execute("deleteLoai7ngay",pr);
        }
        public int XoaNXB()
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter()
            {
                Key = "@Key",
                Value = " "
            });
            return new DataSQL().Execute("deleteNXB7ngay", pr);
        }

        public int XoaSach()
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter()
            {
                Key = "@Key",
                Value = " "
            });
            return new DataSQL().Execute("deleteSach7ngay", pr);
        }
    }
}
