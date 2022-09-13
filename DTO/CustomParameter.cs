using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomParameter
    {

        private string key;
        private string value;

        public string Key { get => key; set => key = value; }
        public string Value { get => value; set => this.value = value; }
    }
}
