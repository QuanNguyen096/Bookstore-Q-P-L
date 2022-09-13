using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using System.Data;

namespace BUSS
{
    public class CaBUSS
    {
        public List<Ca> LayCaCMB()
        {
            return new CaDAL().LayCaCMB();
        }
        public void LayDSCA(DataGridView data, string key)
        {
            new CaDAL().LayDSCA(data, key);
        }
        public DataRow Lay1Ca(string id)
        {
            return new CaDAL().Lay1Ca(id);
        }
        public int Sua(string maca, string tenca, string mota, string thoigian)
        {
            
            return new CaDAL().Sua(maca,tenca,mota,thoigian);
        }
    }
}
