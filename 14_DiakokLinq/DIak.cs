using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_DiakokLinq
{
    internal class Diak
    {
        private string nev;

        public string lakcim;

        public string tagozat;

        public DateTime szuletesNap;

        private int kezdesEve;

        private double atlag;

        // Nev, tagozat, lakcim, szuletesnapot, kezdesev, de az átlagot beállítja 0

        // Nev, lakcim, születesnapot, kezdesev, atlag, de a tagozat beállítja nappalira

        // Nev, lakcim, tagozat, szuletesnapot, atlag bekéri, de a kezdésévét beállítja 2021


        public Diak(string nev, string lakcim, string tagozat, DateTime szuletesNap, int kezdesEve, double atlag)
        {
            this.Nev = nev;
            this.lakcim = lakcim;
            this.tagozat = tagozat;
            this.szuletesNap = szuletesNap;
            this.kezdesEve = kezdesEve;
            this.atlag = atlag;
        }

        public double Atlag
        {
            get { return atlag; }
            set { this.atlag = value; }
        }


        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }


        public int KezdesEve
        {
            get
            {
                return kezdesEve;
            }

            set
            {
                if (value < 1900)
                {
                    throw new Exception("A kezdés éve túl kicsi");
                }

                this.kezdesEve = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("Név: {0}\n", nev));

            sb.Append(string.Format("Születés nap: {0}\n", szuletesNap));
            sb.Append(string.Format("Lakcím: {0}\n", this.lakcim));
            sb.Append(string.Format("Tagozat: {0}\n", this.tagozat));
            sb.Append(string.Format("Kezdés éve: {0}\n", kezdesEve));
            sb.Append(string.Format("Átlag: {0}\n", this.atlag));

            return sb.ToString();
        }
    }
}
