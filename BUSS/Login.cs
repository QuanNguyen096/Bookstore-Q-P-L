using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BUSS
{
    public class Login
    {
        public int KTLogin(string TK,string MK)
        {
            return new LoginDAL().KTLogin(TK, MK);
        }
        public DataRow LayNV(string id)
        {
            return new LoginDAL().TimNV(id);
        }
        #region LoginTam _ file luu tam thoi
        public int UpdateLoginTemp(string ID,string TK, string MK,string Anh,string ChucVu)
        {
            return new LoginDAL().UpdateLoginTemp(ID,TK,MK,Anh, ChucVu);
        }
        public DataRow TimNVLogin(string id = "0")
        {
            return new LoginDAL().TimNVLogin(id);
        }
        public DataRow TimNVLogin_2(string id = "1")
        {
            return new LoginDAL().TimNVLogin_2(id);
        }
        #endregion


        #region Login Save Date (file log)
        public int InsertLoginData(string ID, string txt)
        {
            
            return new LoginDAL().InsertLoginData(ID,txt);
        }

        public void DSLSLogin(DataGridView data, string key)
        {

            new LoginDAL().DSLSLogin(data,key);
        }

        public void DSLoginNV(DataGridView data, string key,string ca, string dd, string mm, string yyyy)
        {
            new LoginDAL().DSLoginNV(data,key,ca,dd,mm,yyyy);
        }
        #endregion
    }

}
