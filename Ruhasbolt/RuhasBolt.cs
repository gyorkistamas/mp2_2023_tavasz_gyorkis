using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruhasbolt
{
    class RuhasBolt
    {
        private List<Ruha> ruhak;
        private string nev;

        public RuhasBolt(string nev)
        {
            this.nev = nev;
            this.ruhak = new List<Ruha>();
        }

        public List<Ruha> AdottSzinuRuhak(string szin)
        {
            List<Ruha> listaMasolat = new List<Ruha>();

            foreach (Ruha ruha in ruhak)
            {
                if (ruha.Szin == szin)
                {
                    Ruha masolat = new Ruha(ruha.Azonosito, ruha.Gyarto, ruha.Nem,  ruha.Szin, ruha.Ar);

                    listaMasolat.Add(masolat);
                }
            }

            return listaMasolat;
        }
    }
}
