using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Diakok
{
    class Diak
    {

        // HF: neptunkód
        // Validáljuk le, hogy:
        // Pontosan 6 karakter  (Length)
        // Nem kezdődik számmal (char.IsNumber())
        // Nem tartalmaz speciális karakteret


        private string nev;

        public Lakcim lakcim;

        public Tagozat tagozat;

        public DateTime szuletesNap;

        private int kezdesEve;

        private double atlag;

        // Nev, tagozat, lakcim, szuletesnapot, kezdesev, de az átlagot beállítja 0

        // Nev, lakcim, születesnapot, kezdesev, atlag, de a tagozat beállítja nappalira

        // Nev, lakcim, tagozat, szuletesnapot, atlag bekéri, de a kezdésévét beállítja 2021


        public Diak(string nev, Lakcim lakcim, Tagozat tagozat, DateTime szuletesNap, int kezdesEve, double atlag)
        {
            this.SetNev(nev);
            this.lakcim = lakcim;
            //....
        }

        public Diak(string nev, Lakcim lakcim, Tagozat tagozat,int ev, int honap, int nap, int kezdesEve, double atlag) : this(nev, lakcim, tagozat, new DateTime(ev, honap, nap), kezdesEve, atlag) {      }




        //1 <= átlag <= 5

        public double GetAtlag()
        {
            return atlag;
        }

        public void SetAtlag(double atlag)
        {
            if (atlag < 1 || atlag > 5)
            {
                throw new Exception("Hibás átlagot adott meg!");
            }

            this.atlag = atlag;
            
        }



        public string GetNev()
        {
            return nev;
        }

        public void SetNev(string nev)
        {
            if (nev == "" || string.IsNullOrEmpty(nev))
            {
                throw new Exception("A név nem lehet üres");
            }

            this.nev = nev;
        }

        //public int GetKezdesEve()
        //{
        //    return kezdesEve;
        //}

        //public void SetKezdesEve(int kezdes)
        //{
        //    if (kezdes < 1900)
        //    {
        //        throw new Exception("A kezdés éve túl kicsi");
        //    }
        //    else
        //    {
        //        kezdesEve = kezdes;
        //    }
        //}

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

        public void Kiir()
        {
            Console.WriteLine("Név: {0}", nev);
            Console.WriteLine("Születés nap: {0}", szuletesNap);
            Console.WriteLine("Lakcím: {0}, {1}, {2}", lakcim.iranyitoszam, lakcim.utcaNev, lakcim.hazSzam);
            Console.WriteLine("Tagozat: {0}", tagozat);
            Console.WriteLine("Kezdés éve: {0}", kezdesEve);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("Név: {0}\n", nev));

            sb.Append(string.Format("Születés nap: {0}\n", szuletesNap));
            sb.Append(string.Format("Lakcím: {0}, {1}, {2}\n", lakcim.iranyitoszam, lakcim.utcaNev, lakcim.hazSzam));
            sb.Append(string.Format("Tagozat: {0}\n", tagozat));
            sb.Append(string.Format("Kezdés éve: {0}\n", kezdesEve));

            return sb.ToString();
        }

    }
}
