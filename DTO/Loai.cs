using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
    public class Loai
    {
        private string maloai;
        private string tenloai;

        public Loai()
        {
           
        }

        public Loai(string maloai, string tenloai)
        {
            Maloai = maloai;
            Tenloai = tenloai;
          
        }

        public string Maloai { get => maloai; set => maloai = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
    }
}
