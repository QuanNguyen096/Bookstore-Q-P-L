using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string id;
        private string ho;
        private string tenlot;
        private string ten;
		private string anh;
		private string gioitinh;
		private string sdt;
		private string mail;
		private string cccd;
		private string diachi;
		private string luong;
		private string chucvu;
		private string taikhoan;
		private string matkhau;
		private DateTime ngaysinh;
		private string ngayvaolam;

        public NhanVien(string id, string ho, string tenlot, string ten, string anh, string gioitinh, string sdt, string mail, string cccd, string diachi, string luong, string chucvu, string taikhoan, string matkhau, DateTime ngaysinh, string ngayvaolam)
        {
            Id = id;
            Ho = ho;
            Tenlot = tenlot;
            Ten = ten;
            Anh = anh;
            Gioitinh = gioitinh;
            Sdt = sdt;
            Mail = mail;
            Cccd = cccd;
            Diachi = diachi;
            Luong = luong;
            Chucvu = chucvu;
            Taikhoan = taikhoan;
            Matkhau = matkhau;
            Ngaysinh = ngaysinh;
            Ngayvaolam = ngayvaolam;
        }
        public NhanVien(string id, string ho, string tenlot, string ten, string anh, string gioitinh, string sdt, string mail, string cccd, string diachi, string luong, string chucvu, string taikhoan, string matkhau, DateTime ngaysinh)
        {
            Id = id;
            Ho = ho;
            Tenlot = tenlot;
            Ten = ten;
            Anh = anh;
            Gioitinh = gioitinh;
            Sdt = sdt;
            Mail = mail;
            Cccd = cccd;
            Diachi = diachi;
            Luong = luong;
            Chucvu = chucvu;
            Matkhau = matkhau;
            Ngaysinh = ngaysinh;
        }
        public string Id { get => id; set => id = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Tenlot { get => tenlot; set => tenlot = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Anh { get => anh; set => anh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Luong { get => luong; set => luong = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Ngayvaolam { get => ngayvaolam; set => ngayvaolam = value; }
    }
}
