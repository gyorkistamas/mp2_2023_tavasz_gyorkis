using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_AbstractOrkok
{
    internal class Varazslo : Ork
    {

        public Varazslo(int id, string nev, Varazslat varazslat)
            : base(id, nev)
        {
            this.Varazslat = varazslat;
        }
        public override int Sebzes
        {
            get
            {
                if (this.Mana >= this.Varazslat.Koltseg)
                {
                    return (int)(this.sebzes * this.Varazslat.Szorzo);
                }
                return this.sebzes;
            }
            protected set
            {
                this.sebzes = value;
            }
        }

        public Varazslat Varazslat { get; set; }

        private bool hasznaltVarazslatot = false;

        public int Mana { get; set; }

        public override void Sebzodik(int sebzes)
        {
            if (this.Mana >= this.Varazslat.Koltseg)
            {
                this.Eletero -= (int)(sebzes * this.Varazslat.PajzsSzorzo);
                this.Mana -= this.Varazslat.Koltseg;
            }
            else
            {
                this.Eletero -= sebzes;
            }

        }

        public override void Tamad(Ork ellenfel)
        {
            if (this.Mana >= this.Varazslat.Koltseg)
            {
                ellenfel.Sebzodik((int)(this.Sebzes * this.Varazslat.Szorzo));
                this.Mana -= this.Varazslat.Koltseg;
                hasznaltVarazslatot = true;
            }
            else
            {
                hasznaltVarazslatot = false;
                ellenfel.Sebzodik(this.Sebzes);
            }

            Console.WriteLine("A {0} varázsló megtámadta {1} orkot és {2} sebzett rajta",
                this.Nev, ellenfel.Nev, this.Sebzes);

        }
    }
}
