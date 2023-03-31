using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orkok
{
    internal class Varazslat
    {
        public string Nev { get; set; }

        public double Szorzo { get; set; }

        public double PajzsSzorzo { get; set; }

        public int Koltseg { get; set; }


        public Varazslat(string nev, double szorzo, double pajzsSzorzo, int koltseg)
        {
            this.Nev = nev;
            this.Szorzo = szorzo;
            this.PajzsSzorzo = pajzsSzorzo;
            this.Koltseg = koltseg;
        }


        public override string ToString()
        {
            return string.Format("{0} - FSz: {1:0.0} - PSz: {2:0.0}", Nev, Szorzo, PajzsSzorzo);
        }
    }
}
