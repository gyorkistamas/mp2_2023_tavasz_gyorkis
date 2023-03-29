using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orkok
{
    internal class Fegyver
    {
        public string Nev { get; set; }

        public double Szorzo { get; set; }

        public Fegyver(string nev, double szorzo)
        {
            this.Nev = nev;
            this.Szorzo = szorzo;
        }

        public override string ToString()
        {
            return string.Format("Név: {0} - Szorzó: {1}", this.Nev, this.Szorzo);
        }
    }
}
