using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Generikusok
{
    internal class Versenyzo
    {
        private string nev;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public Versenyzo(string nev)
        {
            this.Nev = nev;
        }
    }
}
