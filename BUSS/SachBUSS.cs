using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Windows.Forms;
using System.Data;

namespace BUSS
{
    public class SachBUSS
    {
        public List<SachDTO> LaySach()
        {
            return new SachDAL().LaySach();
        }

        #region Report
        public DataTable REPORT_Sach()
        {
            return new DAL.SachDAL().REPORT_Sach();
        }

        public void ReportSach(DataGridView data)
        {
            new SachDAL().ReportSach(data);
        }

        public DataTable REPORT_SachBanChay()
        {
            return new DAL.SachDAL().REPORT_SachBanChay();
        }

        public void ReportSachBanChay(DataGridView data)
        {
            new SachDAL().ReportSachBanChay(data);
        }

        public DataTable REPORT_SachGanHet()
        {
            return new DAL.SachDAL().REPORT_SachGanHet();
        }

        public void ReportSachGanHet(DataGridView data)
        {
            new SachDAL().ReportSachGanHet(data);
        }

        #endregion
        public void LaySachBUSS(DataGridView data, string key)
        {
            new SachDAL().LaySachDAL(data, key);
        }
        public DataTable LaySachBUSS( string key)
        {
            return new SachDAL().LaySachDAL(key);
        }
        public int ThemBUSS(string MS, string Anh, string Loai,string MaNXB,string TenSach ,string TenTg, string SoLuong,string DonGia,string MoTa)
        {
            return new SachDAL().Them(MS, Anh, Loai, MaNXB, TenSach, TenTg, SoLuong, DonGia, MoTa);
        }
        public int SuaBUSS(string MS, string Anh, string Loai,string MaNXB, string TenSach, string TenTg, string SoLuong, string DonGia, string MoTa)
        {

            return new SachDAL().Sua(MS, Anh, Loai, MaNXB, TenSach, TenTg, SoLuong, DonGia, MoTa);
        }
        public int XoaBUSS(string ID)
        {

            return new SachDAL().Xoa(ID);
        }
        public int RestoreBUSS(string id)
        {

            return new SachDAL().Restore(id);
        }

        public static void DSSACHDAXOABUSS(DataGridView data, string key)
        {
            new SachDAL().DSXOASACH(data, key);
        }

        public static DataRow Lay1Sach(string id)
        {
            return new SachDAL().Lay1Sach(id);
        }

        public int UpdateSLSach(string key,string MaSach,string SoLuong)
        {
            return new SachDAL().UpdateSLSach(key,MaSach, SoLuong);
        }
        
    }
}
