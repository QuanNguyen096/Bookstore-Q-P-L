using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;using DTO;
namespace BUSS
{
    public class NgonNguBUSS
    {
        public int Them(string ID, string NN)
        {
            return new NgonNguDAL().Them(ID,NN);
        }
        public int Sua(string ID, string NN)
        {
            return new NgonNguDAL().Sua(ID, NN);
        }
        public  DataRow KTNN(string id)
        {
            return new NgonNguDAL().KTNN(id);
        }
    }
}
