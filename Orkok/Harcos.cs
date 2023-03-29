using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orkok
{
    class Harcos : Ork
    {

        public Harcos(int id, string nev, Fegyver fegyver) : base(id, nev)
        {
            this.Fegyver = fegyver;
        }

        private Fegyver fegyver;

        public Fegyver Fegyver
        {
            get { return fegyver; }
            set { fegyver = value; }
        }

        public override int Sebzes
        { 
            get
            {
                return (int)(base.Sebzes * this.Fegyver.Szorzo);
            }
        }

        protected override void Tamad(Ork ellenfel)
        {
            if (!ellenfel.Halott)
                base.Tamad(ellenfel);
        }

        public override void TamadAnimacio(Ork ellenfel)
        {
            if (ellenfel.Halott)
            {
                Console.WriteLine("{0} nem támadja meg {1}, mert távoll áll tőle a hullagyalázás!", this.Nev, ellenfel.Nev);
            }
            else
            {
                Console.WriteLine("{0} megtámadta egy fegyverrel {1}-t", this.Nev, ellenfel.Nev);
            }
        }

        //ToString()
        // Kiiírja a Harcos összes adatát, és mellé a fegyverének adatait is
        // Használjuk fel az ősosztály ToString() metódusát, ne írjuk meg teljesen előről

    }
}
