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
    public class KhuyenMaiBUSS
    {
        public void DSKMBUSS(DataGridView data)
        {
            new KhuyenMaiDAL().DSKM(data);
        }
        public int ThemKMBUSS(List<CustomParameter>pr)
        {
            return new KhuyenMaiDAL().Them(pr);
        }
        public int XoaKMBUSS(List<CustomParameter> pr)
        {
            return new KhuyenMaiDAL().Xoa(pr);

        }
        public int SuaKMBUSS(List<CustomParameter> pr)
        {
            return new KhuyenMaiDAL().Sua(pr);

        }
    }
}
