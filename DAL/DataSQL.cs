using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class DataSQL
    {
        private string connectionString = Constant.CONNECTION_STRING_MYSQL;
        //private string connectionString = @"Data Source=.;Initial Catalog=AppSach;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private DataTable table;
        private string str = "";

        private static DataSQL instance;

  
        public static DataSQL Instance
        {
            get
            {
                if (instance == null) instance = new DataSQL();
                return instance;
            }
        }

        public DataSQL()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {
                connection.Close();

            }
        }

        public DataTable selectData(string sql, List<CustomParameter> parameters)
        {
            try
            {
                connection.Open();
                command = new SqlCommand(str, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = sql;
                foreach (var p in parameters) { command.Parameters.AddWithValue(p.Key, p.Value); }
                table = new DataTable();
                table.Load(command.ExecuteReader());
                return table;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                connection?.Close();
            }
        }
        public DataTable selectData(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }   
            connection?.Close();
            
        }
        public DataRow Select(string str)
        {
            try
            {
                connection.Open();

                command = new SqlCommand(str, connection);
                table = new DataTable();
                table.Load(command.ExecuteReader());
                return table.Rows[0];

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public int Execute(string str, List<CustomParameter> customParameters)
        {
            try
            {
                connection.Open();
                command = new SqlCommand(str, connection);
                command.CommandType = CommandType.StoredProcedure;
                foreach (var p in customParameters)
                {
                    command.Parameters.AddWithValue(p.Key, p.Value);
                }

                var re = command.ExecuteNonQuery();
                return (int)re;
            }
            catch (Exception ex)
            {
                return Constant.GTRI_KHONG_THUC_THI_THANH_CONG;
            }
            finally
            {
                connection.Close();
            }
        }
        public int Execute(string str)
        {
            try
            {
                connection.Open();
                command = new SqlCommand(str, connection);
                command.CommandType = CommandType.StoredProcedure;
                var re = command.ExecuteNonQuery();
                return (int)re;
            }
            catch (Exception ex)
            {
                return Constant.GTRI_KHONG_THUC_THI_THANH_CONG;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<SachDTO> Sach(string sql)
        {
            connection.Open();
            List<SachDTO> list = new List<SachDTO>();

            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlDataReader adapter = command.ExecuteReader();

            if(adapter.HasRows)
            {
                while(adapter.Read())
                {
                    SachDTO l = new SachDTO()
                    { 
                        MaSach = (String)adapter["MaSach"],
                        TenSach = (String)adapter["TenSach"]
                    };
                    list.Add(l);
                }
            }
            connection.Close();
            return list;
        }

        public List<Loai> Loai(string sql)
        {
            connection.Open();
            List<Loai> list = new List<Loai>();

            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader adapter = command.ExecuteReader();
            if (adapter.HasRows)
            {
                while (adapter.Read())
                {
                    Loai l = new Loai()
                    {
                        Maloai= (String)adapter[Constant.TYPE_CODE],
                        Tenloai= (String)adapter[Constant.TYPE_NAME]
                    };
                    list.Add(l);

                }
            }
            connection.Close();
            return list;
        }
        public List<NXB> Nxb(string sql)
        {
            connection.Open();
            List<NXB> list = new List<NXB>();
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader adapter = command.ExecuteReader();
            if (adapter.HasRows)
            {
                while (adapter.Read())
                {
                    NXB l = new NXB()
                    {
                        Manxb= (String)adapter[Constant.NXB_CODE],Tennxb= (String)adapter[Constant.NXB_NAME].ToString()
                    };
                    list.Add(l);

                }
            }
            connection.Close();
            return list;
        }
        public List<Ca> Ca(string sql)
        {
            connection.Open();
            List<Ca> list = new List<Ca>();
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader adapter = command.ExecuteReader();
            if (adapter.HasRows)
            {
                while (adapter.Read())
                {
                    Ca l = new Ca()
                    {
                        Maca = (int)adapter[Constant.Ca_CODE],
                        Tenca = (String)adapter[Constant.Ca_NAME],
                        Mota = (String)adapter[Constant.MOTA],
                        Thoigian = (String)adapter[Constant.TIME]
                    };
                    list.Add(l);
                }
            }
            connection.Close();
            return list;
        }
    }
}
