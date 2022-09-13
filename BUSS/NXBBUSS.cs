using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Windows.Forms;

namespace BUSS
{
    public class NXBBUSS
    {
       
        public List<NXB> ListNXB()
        {
            return new NXBDAL().ListNXB();
        }
        public void XemBUSS(DataGridView data, string key)
        {
            new NXBDAL().Xem(data, key);
        }
        public int LuuBUSS(string MaNXB,string TenNXB,string LienHe,string DiaChi)
        {
            return new NXBDAL().Them(MaNXB, TenNXB, LienHe, DiaChi);
        }
        public int XoaBUSS(string ID)
        {
            return new NXBDAL().Xoa(ID);
        }
        public int SuaBUSS(string MaNXB, string TenNXB, string LienHe, string DiaChi)
        {
            return new NXBDAL().Sua(MaNXB, TenNXB, LienHe, DiaChi);
        }

        public void DSNXBDAXOA(DataGridView data,string key)
        {
            new NXBDAL().DSXOANXB(data, key);
        }

        public int LayLaiDAL(string key)
        {
            return new NXBDAL().LayLaiDAL(key);
        }

        //Lấy dòng dữ liệu
        public static DataRow LayNXBBUSS(string id)
        {
            return NXBDAL.LayNXB(id);
        }
    }
}
