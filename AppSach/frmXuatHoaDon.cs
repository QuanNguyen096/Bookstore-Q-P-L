using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using DTO;
using System.Data.SqlClient;

namespace AppSach
{
    public partial class frmXuatHoaDon :Form
    {
        public frmXuatHoaDon()
        {
            InitializeComponent();
    
        }
        public DataTable getData()
        {
            string sqlCon = Constant.CONNECTION_STRING_MYSQL;
            DataTable dt = new DataTable();
            string query = "Select tensach,soluong,FORMAT(DonGia,'#,###' + ' VNĐ') AS DonGia1,DonGia from dbSach";
            using (SqlConnection sqlConnection = new SqlConnection(sqlCon))
            {
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
        private void frmXuatHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                InHoaDon.LocalReport.ReportEmbeddedResource = "AppSach.TaoHoaDon.rdlc";
                ReportDataSource rs = new ReportDataSource();
                rs.Name = "DataSet1";
                rs.Value = getData();
                InHoaDon.LocalReport.DataSources.Add(rs);
                this.InHoaDon.RefreshReport();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
