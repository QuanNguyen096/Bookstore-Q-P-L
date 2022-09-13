using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUSS
{
    public class LoaiBUSS
    {
        public List<Loai> LayLoai()
        {
            return new LoaiDAL().LayLoai();
        }
        //**
        public void LayLoaiBUSS(DataGridView data, string key)
        {
            new LoaiDAL().LayLoaiDAL(data, key);
        }

        public int ThemLoaiBUSS(string MaLoai,string TenLoai)
        {
            return new LoaiDAL().ThemLoaiDAL(MaLoai, TenLoai);
        }

        public int SuaLoaiBUSS(string MaLoai, string TenLoai)
        {
            return new LoaiDAL().SuaLoaiDAL(MaLoai, TenLoai);
        }

        public int XoaLoaiBUSS(string Maloai,DateTime dt)
        {
            return new LoaiDAL().XoaLoaiDAL(Maloai, dt);
        }

        public int LayLaiBUSS(string id)
        {
            return new LoaiDAL().LayLaiDAL(id);
        }

        public static DataRow LayLoaiBUSS(string MaLoai)
        {
            return new LoaiDAL().LayLoai(MaLoai);
        }

        public void DSLOAIDAXOABUSS(DataGridView data, string key)
        {
            new LoaiDAL().DSXOALOAI(data, key);
        }

    }
}
