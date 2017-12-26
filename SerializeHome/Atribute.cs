using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeHome
{
    class Atribute : System.Attribute
    {
        public string Info { get; set; }
        public Atribute() { }
        public Atribute(string info)
        {
            Info = info;
        }
    }
}
