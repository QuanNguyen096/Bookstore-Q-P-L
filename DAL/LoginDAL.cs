using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class LoginDAL
    {
        public int KTLogin(string TK,string MK)
        {
            List<CustomParameter> ls = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    Key ="@TenTK",Value= TK
                },
                new CustomParameter()
                {
                    Key ="@MK",Value= MK
                }
            };
           var a = new DataSQL().selectData("[LoginApp]", ls);
            if(a.Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public DataRow TimNV(string id)
        {
            return new DataSQL().Select("TruyVan '" + id + "'");
        }

        #region LoginTam _ file luu tam thoi
        public int UpdateLoginTemp(string ID,string TK,string MK,string Anh,string ChucVu)
        {
            List<CustomParameter> parameters = new List<CustomParameter>();

            parameters.Add(new CustomParameter()
            {
                Key = "@ID",
                Value = ID
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@TK",
                Value = TK
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@MK",
                Value = MK
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@Anh",
                Value = Anh
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@ChucVu",
                Value = ChucVu
            });

            return new DataSQL().Execute("UpdateLoginTam", parameters);
        }
        #endregion
        #region Login Save Date (file log)
        public int InsertLoginData(string ID,string txt)
        {
            List<CustomParameter>pr=new List<CustomParameter>();
            pr.Add(new CustomParameter()
            {
                Key = "@Key",
                Value = ID
            });
            pr.Add(new CustomParameter()
            {
                Key = "@Status",
                Value = txt
            });
            return new DataSQL().Execute("InsertLSLogin",pr);
        }
        public DataRow TimNVLogin(string id)
        {
            return new DataSQL().Select("SelectLoginTam '" + id + "'");
        }
        public DataRow TimNVLogin_2(string id)
        {
            return new DataSQL().Select("SelectLoginTam_ '" + id + "'");
        }
        public void DSLSLogin(DataGridView data, string key)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@key",
                Value = key
            });
            data.DataSource = new DataSQL().selectData("[SelectAllLSLogin_]", list);
        }

        public void DSLoginNV(DataGridView data, string key,string Ca,string dd,string mm,string yyyy)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@key",
                Value = key
            });
            list.Add(new CustomParameter()
            {
                Key = "@TenCa",
                Value = Ca
            });
            list.Add(new CustomParameter()
            {
                Key = "@Date_Day",
                Value = dd
            });
            list.Add(new CustomParameter()
            {
                Key = "@Date_Month",
                Value = mm
            });
            list.Add(new CustomParameter()
            {
                Key = "@Date_Year",
                Value = yyyy
            });
            data.DataSource = new DataSQL().selectData("[SearchLSLogin_Ca_NV]", list);
        }

        #endregion
    }
}
