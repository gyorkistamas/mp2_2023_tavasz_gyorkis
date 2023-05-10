using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Generikusok
{
    internal class Futo : Versenyzo, IComparable
    {
        private TimeSpan korIdo;
        public TimeSpan KorIdo 
        { 
            get {  return korIdo; }
            set { this.korIdo = value; } 
        }

        public Futo(string nev, TimeSpan ido)
            :base(nev)
        {
            this.KorIdo = ido;
        }

        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                throw new Exception("Az obj null!");
            }

            if (!(obj is Futo))
            {
                throw new Exception("Az obj nem fekvenyomó!");
            }

            Futo futo = (Futo)obj;

            if (this.korIdo > futo.korIdo)
            {
                return 1;
            }
            else if (this.korIdo < futo.korIdo)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }
}
