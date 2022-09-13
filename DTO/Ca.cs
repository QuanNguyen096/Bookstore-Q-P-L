using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ca
    {
        private string tenca,mota,thoigian;
        private int maca;
        public int Maca { get => maca; set => maca = value; }
        public string Tenca { get => tenca; set => tenca = value; }
        public string Mota { get => mota; set => mota = value; }
        public string Thoigian { get => thoigian; set => thoigian = value; }
    }
}
