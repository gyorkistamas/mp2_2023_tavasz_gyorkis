using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Égitestek
{
    internal class Bolygo : Egitest
    {
        private const string POSTFIX = "-B";

        private const double MIN_KERINGESI_TAVOLASG = 0.37;

        private const double MAX_KERINGESI_TAVOLSAG = 30.07;

        private BolygoOsztaly bolygoOsztaly;

        public BolygoOsztaly BolygoOsztaly
        {
            get { return this.bolygoOsztaly; }
            set { this.bolygoOsztaly = value; }
        }

        private double keringesiTavolsag;

        public double KeringesiTavolsag
        {
            get { return this.keringesiTavolsag; }
            set
            {
                if (value < MIN_KERINGESI_TAVOLASG)
                    throw new Exception("A keringési távolság értéke túl kicsi!");

                if (value > MAX_KERINGESI_TAVOLSAG)
                    throw new Exception("A keringési távolság értéke túl nagy!");

                this.keringesiTavolsag = value;
            }
        }

        public Bolygo(string nev, int eletkor, BolygoOsztaly osztaly, double keringesiTavolsag)
            :base(nev, eletkor)
        {
            this.Azonosito += POSTFIX;

            this.BolygoOsztaly = bolygoOsztaly;
            this.KeringesiTavolsag = keringesiTavolsag;
        }

        public Bolygo(string nev, int eletkor)
            :this(nev, eletkor, BolygoOsztaly.NemIsmert, MIN_KERINGESI_TAVOLASG) { } 
    }
}
