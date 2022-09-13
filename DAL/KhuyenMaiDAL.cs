using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class KhuyenMaiDAL
    {
        public void DSKM(DataGridView data)
        {
            List<CustomParameter> customParameters = new List<CustomParameter>();
            data.DataSource = new DataSQL().selectData("SelectALLKM", customParameters);
        }
        public int Them(List<CustomParameter> pr)
        {
            return new DataSQL().Execute("InsertKM", pr);
        }
        public int Xoa(List<CustomParameter> pr)
        {
            return new DataSQL().Execute("XoaKM", pr);
        }
        public int Sua(List<CustomParameter> pr)
        {
            return new DataSQL().Execute("UpdateKM", pr);
        }
    }
}
