using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orkok
{
    internal class Varazslo : Ork
    {
        public Varazslo(int id, string nev, Varazslat varazslat) : base(id, nev)
        {
            this.Varazslat = varazslat;
            this.Mana = 40;
        }

        public Varazslat Varazslat { get; set; }

        public int Mana { get; set; }

        private bool HasznaltVarazslatot = false;

        public override int Sebzes
        {
            get
            {
                if (HasznaltVarazslatot)
                    return (int)(base.Sebzes * this.Varazslat.Szorzo);

                return base.Sebzes;
            }
        }

        public override void Sebzodik(int sebzes)
        {
            if (this.Mana >= this.Varazslat.Koltseg)
            {
                this.Eletero -= (int)(sebzes * this.Varazslat.PajzsSzorzo);
                this.Mana -= this.Varazslat.Koltseg;
            }
            else
                base.Sebzodik(sebzes);
        }


        protected override void Tamad(Ork ellenfel)
        {
            if (this.Mana >= this.Varazslat.Koltseg)
            {
                ellenfel.Sebzodik((int)(this.Sebzes * this.Varazslat.Szorzo));
                this.Mana -= this.Varazslat.Koltseg;
                HasznaltVarazslatot = true;
            }
            else
                HasznaltVarazslatot = false;
            base.Tamad(ellenfel);
        }


        public override void TamadAnimacio(Ork ellenfel)
        {
            Tamad(ellenfel);
            Console.WriteLine("{0} megtámadta {1}-t és {2}-t sebzett rajta.\nEredmény: {3}", this.Nev, ellenfel.Nev, this.Sebzes, ellenfel);
        }

        public override string ToString()
        {
            return string.Format("{0} - V: {1}", base.ToString(), Varazslat);
        }
    }
}
