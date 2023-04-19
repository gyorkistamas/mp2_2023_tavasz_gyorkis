using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace _08_AbstractOrkok
{
    abstract class Ork
    {
        private static int KEZDO_ELETERO = 100;
        private static int KEZDO_SEBZES = 6;

        public Ork(int id, string nev)
        {
            this.Id = id;
            this.Nev = nev;
        }

        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            private set
            {
                this.id = value;
            }
        }

        private string nev;

        public string Nev
        {
            get { return nev; }
            private set { nev = value; }
        }

        private int eletero;

        public int Eletero
        {
            get { return eletero; }
            protected set { eletero = value; }
        }

        public bool Halott
        {
            get
            {
                return this.Eletero <= 0;
            }
        }

        protected int sebzes;

        public abstract int Sebzes
        {
            get;
            protected set;
        }

        public abstract void Sebzodik(int sebzes);

        public abstract void Tamad(Ork ellenfel);

        public override string ToString()
        {
            return string.Format("Id: {0} - Név: {1} - Sebzés - {2} - Életerő: {3}",
                               this.Id, this.Nev, this.Sebzes, this.Eletero);
        }
    }
}
