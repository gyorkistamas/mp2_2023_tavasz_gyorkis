using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_AbstractOrkok
{
    internal class Harcos : Ork
    {
        public Harcos(int id, string nev, Fegyver fegyver)
            :base(id, nev)
        {
            this.fegyver = fegyver;
        }

        private Fegyver fegyver;

        public Fegyver Fegyver
        {
            get
            {
                return fegyver;
            }
        }

        public override int Sebzes
        { 
            get
            {
                return (int)(this.sebzes * this.fegyver.Szorzo);
            }
            protected set
            {
                this.sebzes = value;
            }
        }

        public override void Sebzodik(int sebzes)
        {
            this.Eletero -= sebzes;
        }

        public override void Tamad(Ork ellenfel)
        {
            if (ellenfel.Halott)
            {
                Console.WriteLine("Az {0} ork nem támadja meg az ellenfelét, mert már halott!");
            }
            else
            {
                ellenfel.Sebzodik(this.Sebzes);
                Console.WriteLine("Az {0} ork {1}-t sebzett az ellenfelén", this.Nev, this.Sebzes);
            }

        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" - Fegyver: {0} - Fegyver szorzója: {1}", this.fegyver.Nev, this.fegyver.Szorzo);
        }
    }
}
