using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Generikusok
{
    internal class Fekvenyomo : Versenyzo, IComparable
    {
        private int kinyomottTomeg;

        // [0, 20]
        public int KinyomottTomeg
        {
            get { return kinyomottTomeg; }
            set
            { 
                if (value < 0 || value > 20)
                {
                    throw new TomegInvalidValueException("Rossz értéket adtak meg!", value);
                }
                this.kinyomottTomeg = value;
            }
        }

        public Fekvenyomo(string nev, int tomeg)
            :base(nev)
        {
            this.KinyomottTomeg = tomeg;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new Exception("Az obj null!");
            }

            if (!(obj is Fekvenyomo))
            {
                throw new Exception("Az obj nem fekvenyomó!");
            }

            Fekvenyomo masik = obj as Fekvenyomo;

            return this.kinyomottTomeg - masik.kinyomottTomeg;
        }
    }
}
