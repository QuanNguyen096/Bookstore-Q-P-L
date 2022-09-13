using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUSS
{
    public class ChucNangXoa
    {
        //Xoa cac km khi den thoi han

        public int XoaKMBUSS(List<CustomParameter> pr)
        {
            return new ChucNangXoaDAL().Xoa(pr);

        }
        public int XoaNVBuss(List<CustomParameter> pr)
        {
            return new ChucNangXoaDAL().XoaNV(pr);

        }
        public int XoaSachBuss()
        {
            return new ChucNangXoaDAL().XoaSach();

        }
    }
}
