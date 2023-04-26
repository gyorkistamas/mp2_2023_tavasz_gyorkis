using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_VersenyzoDLL2
{
    public class Versenyzo : IVersenyzo
    {

        public Versenyzo(string nev, string csapat, int perc, int masodperc, int millisecundum)
        {
            this.Nev = nev;
            this.Csapat = csapat;

            this.KorIdo = new TimeSpan(0, 0, perc, masodperc, millisecundum);
        }

        public string Nev { get; private set; }

        public string Csapat { get; private set; }

        public TimeSpan KorIdo { get; private set; }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new Exception("Null-al nem lehet összehasonlítani!");
            }

            if (!(obj is Versenyzo))
            {
                throw new Exception("A kapott objektum nem versenyző!");
            }

            Versenyzo masik = obj as Versenyzo;

            if (this.KorIdo < masik.KorIdo)
            {
                return -1;
            }
            else if (this.KorIdo == masik.KorIdo)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }
    }
}
