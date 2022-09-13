using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NXB
    {
        private int id;
        private string manxb;
        private string tennxb;
        private string lienhe;
        private string diachi;

        public int Id { get => id; set => id = value; }
        public string Manxb { get => manxb; set => manxb = value; }
        public string Tennxb { get => tennxb; set => tennxb = value; }
        public string Lienhe { get => lienhe; set => lienhe = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
