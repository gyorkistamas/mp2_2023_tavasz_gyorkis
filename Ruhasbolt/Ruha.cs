using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruhasbolt
{
    internal class Ruha
    {
        #region Fields
        private string azonosito;
        private Nem nem;
        private string gyarto;
        private int ar;
        private string szin;
        #endregion

        #region Property
        public string Gyarto
        {
            get { return gyarto; }

            private set 
            {
                if (value.Length < 3)
                {
                    throw new Exception("A gyártónak legalább 3 karakternek kell lennie!");
                }

                this.gyarto = value.Substring(0, 1).ToUpper() + value.Substring(1, value.Length - 1);

            }
        }


        public int Ar
        {
            get { return ar; }

            set
            {
                if (value <= 0)
                {
                    throw new Exception("Az ár nem lehet nulla vagy annál kisebb!");
                }

                this.ar = value;
            }
        }

        public string Szin
        {
            get { return szin; }

            set { this.szin = value; }
        }

        private bool nemBeallitva = false;
        public Nem Nem
        {
            get { return nem; }

            set
            {
                if (nemBeallitva)
                {
                    throw new Exception("A nem már be van állítva");
                }

                this.nem = value;
                this.nemBeallitva = true;
            }
        }

        private bool azonositoBeallitva = false;
        public string Azonosito
        {
            get { return azonosito; }
            private set
            {
                if (azonositoBeallitva)
                {
                    throw new Exception("Az azonosító már be lett állítva!");
                }

                if (value.Length > 8)
                {
                    throw new Exception("Az azonosító hosszabb, mint 8 karakter!");
                }

                this.azonosito = value.PadLeft(8, '0');

            }
        }
        #endregion

        #region Constructors

        public Ruha(string azonosito, string gyarto, Nem nem, string szin, int ar)
        {
            this.Azonosito = azonosito;
            this.Gyarto = gyarto;
            this.Nem = nem;
            this.Szin = szin;
            this.Ar = ar;
        }

        public Ruha(string azonosito, string gyarto, string szin, int ar) 
        : this(azonosito, gyarto, Nem.UNISEX, szin, ar) { }

        #endregion

        // HF: a Nem-hez statikus formatter osztály készítése, és használata itt
        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();

            sr.AppendFormat("Azonosító: {0}\n", this.Azonosito);
            sr.AppendFormat("Gyártó: {0}\n", this.Gyarto);
            sr.AppendFormat("Nem: {0}\n", this.Nem);
            sr.AppendFormat("Szín: {0}\n", this.Szin);
            sr.AppendFormat("Ár: {0}\n", this.Ar);

            return sr.ToString();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Ruha))
            {
                return false;
            }

            Ruha masik = obj as Ruha;

            return this.Azonosito == masik.Azonosito && this.Gyarto == masik.Gyarto;
        }
    }
}
