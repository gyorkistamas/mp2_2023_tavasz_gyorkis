using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Égitestek
{
    internal class Egitest
    {
        private static int ID = 1;

        private const string PREFIX = "E-";

        public Egitest(string nev, int eletkor)
        {
            this.Nev = nev;
            this.Eletkor = eletkor;

            this.Azonosito = PREFIX + ID.ToString().PadLeft(6, '0');

            ID++;

        }

        public Egitest(string nev) : this(nev, 0)
        { }

        public Egitest() : this(null, 0) { }

        private string azonosito;

        public string Azonosito
        {
            get { return azonosito; }

            protected set
            {
                if (value == null || value.Length == 0)
                    throw new Exception("Az azonosító nem lehet null");

                if (this.azonosito != null &&
                    value.Length < this.azonosito.Length)
                    throw new Exception("Az új azonosító nem lehet rövidebb!");

                this.azonosito = value;
            }
        }

        private string nev;
        public string Nev
        {
            get { return nev; }

            set
            {
                if ((value != null) && value.Length < 2)
                    throw new Exception("A hossza legalább kettőnek kell lennie");

                this.nev = value;
            }
        }

        public int Eletkor { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Azonosító: {0}\n", this.Azonosito);

            sb.AppendFormat("Név: {0}\n", this.Nev == null ? "-" : this.Nev);

            sb.AppendFormat("Életkor: {0}\n", this.Eletkor == 0 ? "Nincs megadva" : $"{this.Eletkor} éves");

            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Egitest))
                return false;

            Egitest masik = obj as Egitest;

            return this.Nev == masik.Nev;
        }

    }
}
