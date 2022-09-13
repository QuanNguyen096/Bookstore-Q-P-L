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
    public class NhanVien
    {
        private static NhanVien instance;
        public static NhanVien Instance
        {
            get
            {
                if (instance == null) instance = new NhanVien();
                return instance;
            }
        }


        public int Them(string taikhoan, string anh, string ho, string tenlot, string ten, string cccd, string gioitinh, string matkhau, string sdt, string mail, DateTime ngaysinh, string dc, string luong, string cv,string Ca)
        {
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                Key = "@taikhoan",
                Value = taikhoan
            });

            parameters.Add(new CustomParameter()
            {
                Key = "@Anh",
                Value = anh
            });

            parameters.Add(new CustomParameter()
            {
                Key = "@Ho",
                Value = ho
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@TenLot",
                Value = tenlot
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@Ten",
                Value = ten
            });

            parameters.Add(new CustomParameter()
            {
                Key = "@CCCD",
                Value = cccd
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@GioiTinh",
                Value = gioitinh
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@matkhau",
                Value = matkhau
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@sdt",
                Value = sdt
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@mail",
                Value = mail
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@NgaySinh",
                Value = ngaysinh.ToString("yyyy-MM-dd")
            });

            parameters.Add(new CustomParameter()
            {
                Key = "@DiaChi",
                Value = dc
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@Luong",
                Value = luong
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@ChucVu",
                Value = cv
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@MaCa",
                Value = Ca
            });
            return new DataSQL().Execute("InsertNV", parameters);
        }
        public int Sua(string id, string anh, string ho, string tenlot, string ten, string cccd, string gioitinh, string matkhau, string sdt, string mail, DateTime ngaysinh, string dc, string luong, string cv,string Ca)
        {
            List<CustomParameter> parameters = new List<CustomParameter>();

            parameters.Add(new CustomParameter()
            {
                Key = "@ID",
                Value = id
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@Anh",
                Value = anh
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@Ho",
                Value = ho
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@TenLot",
                Value = tenlot
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@Ten",
                Value = ten
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@CCCD",
                Value = cccd
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@GioiTinh",
                Value = gioitinh
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@matkhau",
                Value = matkhau
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@sdt",
                Value = sdt
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@mail",
                Value = mail
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@NgaySinh",
                Value = ngaysinh.ToString("yyyy-MM-dd")
            });

            parameters.Add(new CustomParameter()
            {
                Key = "@DiaChi",
                Value = dc
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@Luong",
                Value = luong
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@ChucVu",
                Value = cv
            });
            parameters.Add(new CustomParameter()
            {
                Key = "@MaCa",
                Value = Ca
            });
            return new DataSQL().Execute("UpdateNhanVien", parameters);
        }
        public int Xoa(string IDLogin,string ID, DateTime dt)
        {
            List<CustomParameter> parameter = new List<CustomParameter>();
            parameter.Add(new CustomParameter()
            {
                Key = "@Key",
                Value = ID
            });
            parameter.Add(new CustomParameter()
            {
                Key = "@IDLogin",
                Value = IDLogin
            });
            parameter.Add(new CustomParameter()
            {
                Key = "@Key2",
                Value = Constant.IDAMIN
            });
            parameter.Add(new CustomParameter()
            {
                Key = "@ngaysexoa",
                Value = dt.ToString("yyyy/MM/dd")
            });
            return new DataSQL().Execute("[XoaNVNotData]", parameter);
        }
        public int Restore(string id)
        {
            List<CustomParameter> parameter = new List<CustomParameter>();
            parameter.Add(new CustomParameter()
            {
                Key = "@Key",
                Value = id
            });
            return new DataSQL().Execute("[LayLaiNV]", parameter);
        }
        public void Xem(DataGridView data,string key,string ID)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@key",
                Value = key
            });
     
            data.DataSource = new DataSQL().selectData("[SelectAllNhanVien]",list);
        }
        public void DSXOANV(DataGridView data, string key)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@key",
                Value = key
            });
            data.DataSource = new DataSQL().selectData("[SelectAllLSXoaNhanVien]", list);
        }
        public static DataRow LayNV(string id)
        {
            return new DataSQL().Select("LAYRA1NV '" + id + "'");
        }
      
        #region sua truc tiep tren luoi
        //sua truc tiep
        public bool SuaNV(string key, DTO.NhanVien nhanVien)
        {
            List<CustomParameter> par = new List<CustomParameter>();
            par.Add(new CustomParameter()
            {
                Key = "@ID",
                Value = nhanVien.Id
            });
            par.Add(new CustomParameter()
            {
                Key = "@Ho",
                Value = nhanVien.Ho
            }); par.Add(new CustomParameter()
            {
                Key = "@TenLot",
                Value = nhanVien.Tenlot
            }); par.Add(new CustomParameter()
            {
                Key = "@Ten",
                Value = nhanVien.Ten
            }); par.Add(new CustomParameter()
            {
                Key = "@Anh",
                Value = nhanVien.Anh
            }); par.Add(new CustomParameter()
            {
                Key = "@GioiTinh",
                Value = nhanVien.Gioitinh
            }); par.Add(new CustomParameter()
            {
                Key = "@SDT",
                Value = nhanVien.Sdt
            }); par.Add(new CustomParameter()
            {
                Key = "@Mail",
                Value = nhanVien.Mail
            }); par.Add(new CustomParameter()
            {
                Key = "@CCCD",
                Value = nhanVien.Cccd
            }); par.Add(new CustomParameter()
            {
                Key = "@MatKhau",
                Value = nhanVien.Matkhau
            });
            par.Add(new CustomParameter()
            {
                Key = "@DiaChi",
                Value = nhanVien.Diachi
            }); par.Add(new CustomParameter()
            {
                Key = "@Luong",
                Value = nhanVien.Luong
            }); par.Add(new CustomParameter()
            {
                Key = "@NgaySinh",
                Value = nhanVien.Ngaysinh.ToShortDateString()
            });

            if (DataSQL.Instance.Execute("[UpdateNhanVien]", par) > 0) return true; return false;
        }
        #endregion sua truc tiep tren luoi
        //public List<CustomParameter> XemSV(string key)
        //{
        //    List<CustomParameter> list = new List<CustomParameter>();
        //    list.Add(new CustomParameter()
        //    {
        //        Key = "@key",
        //        Value = key
        //    });
        //    return list;
        //}

        public DataTable REPORT_NV()
        {
          return new DAL.DataSQL().selectData("[ReportNhanVien]");
        }

        //dsddnv
        public void DSNVDD(DataGridView data, string key)
        {
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                Key = "@key",
                Value = key
            });
            data.DataSource = new DataSQL().selectData("[DSNV_DD]", list);
        }

    }
}
