using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUSS
{
    public class DiemDanhBUS
    {
        public int DiemDanhNhanVien_TinhLuongNGay(string ID,string VP,string MT)
        {
            return new DiemDanhDAL().DiemDanhNhanVien_TinhLuongNGay(ID,VP,MT);
        }
        public int ReseetDDD(string Key)
        {
            return new DiemDanhDAL().ReseetDDD(Key);
        }
    }
}
