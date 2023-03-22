using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Égitestek
{
    class Csillag : Egitest
    {
        private static string POSTFIX = "-CS";
        public Csillag(string nev, int eletkor, CsillagOsztaly osztaly, double atmero) : base(nev, eletkor)
        {
            this.Azonosito += POSTFIX;
            this.Atmero = atmero;
        }

        // HF: Bekéri a nevet, életkort, átmérőt, a csillagosztályt beállítja nem ismertre

        // Csillagosztályhoz statikus Formatter osztály

        public Csillag() : base()
        {
            this.Azonosito += POSTFIX;
        }

        private CsillagOsztaly csillagOsztaly;

        public CsillagOsztaly CsillagOsztaly
        {
            get { return csillagOsztaly; }
            set { this.csillagOsztaly = value; }
        }

        private bool atmeroMegadva = false;
        private double atmero;

        public double Atmero
        {
            get 
            {
                if (!atmeroMegadva)
                    throw new Exception("Az átmérő nem lett megadva!");

                return atmero;
            }
            set
            {
                this.Atmero = value;
                this.atmeroMegadva = true;
            }
        }

        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();
            sr.Append(base.ToString());

            sr.AppendFormat("Csillagosztályt: {0}\n", this.CsillagOsztaly);

            sr.AppendFormat("Átmérő: {0}", atmeroMegadva ? this.Atmero : "Nincs megadva");

            return sr.ToString();
        }
    }
}
