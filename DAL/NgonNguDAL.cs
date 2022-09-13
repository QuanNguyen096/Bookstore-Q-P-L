using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NgonNguDAL
    {
        public int Them(string ID,string NN)
        {
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                Key = "@ID",
                Value = ID
            });

            parameters.Add(new CustomParameter()
            {
                Key = "@trangthai",
                Value = NN
            });

            return new DataSQL().Execute("InserNgonNgu", parameters);
        }
        public int Sua(string ID, string NN)
        {
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                Key = "@ID",
                Value = ID
            });

            parameters.Add(new CustomParameter()
            {
                Key = "@trangthai",
                Value = NN
            });

            return new DataSQL().Execute("UpdateNgonNgu", parameters);
        }
        public DataRow KTNN(string id)
        {
            return new DataSQL().Select("Select1NgonNgu '" + id + "'");
        }
    }
}
