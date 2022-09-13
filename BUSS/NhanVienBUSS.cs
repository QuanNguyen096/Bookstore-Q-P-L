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
    public class NhanVienBUSS
    {
        static string Key;
        //Do du lieu len luoi
        public static void XemBUSS(DataGridView data, string key,string ID)
        {
            Key = key;
            DAL.NhanVien.Instance.Xem(data, key, ID);
        }
        public static void DSNVDAXOABUSS(DataGridView data, string key)
        {
            Key = key;
            DAL.NhanVien.Instance.DSXOANV(data, key);
        }
        //Thuc thi them, sua,xoa
        public int ThemBUSS(string taikhoan,string anh,string ho,string tenlot,string ten,string cccd,string gioitinh,string matkhau,string sdt,string mail,DateTime ngaysinh,string dc,string luong,string cv,string Ca)
        {
            return new DAL.NhanVien().Them(taikhoan, anh, ho, tenlot, ten, cccd, gioitinh, matkhau, sdt, mail, ngaysinh, dc, luong, cv,Ca);
        }
        public int SuaBUSS(string id,string anh, string ho, string tenlot, string ten, string cccd, string gioitinh, string matkhau, string sdt, string mail, DateTime ngaysinh, string dc, string luong, string cv,string Ca)
        {
            return new DAL.NhanVien().Sua(id, anh, ho, tenlot, ten, cccd, gioitinh, matkhau, sdt, mail, ngaysinh, dc, luong, cv,Ca);
        }
        public int XoaBUSS(string IDLogin,string ID,DateTime dt)
        {
            return new DAL.NhanVien().Xoa(IDLogin, ID, dt);
        }
        public int RestoreBUSS(string id)
        {
            
            return new DAL.NhanVien().Restore(id);
        }
        //Lay dong du lieu
        public static DataRow LayNVBUSS(string id)
        {
            return DAL.NhanVien.LayNV(id);
        }
        public DataTable REPORT_NV()
        {
           return new DAL.NhanVien().REPORT_NV();
        }
        //dsddd
        public void DSNVDD(DataGridView data, string key)
        {
             new DAL.NhanVien().DSNVDD(data,Key);
        }
    }
}
