using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_zh2_gyak_dll
{
    public abstract class Szenzor : ICloneable
    {
        public Szenzor(Pozicio pozicio)
        {
            this.Pozicio = pozicio;
        }

        public Pozicio Pozicio { get; private set; }
        public abstract bool Aktiv { get; }

        public abstract void Adatkuldes();

        public abstract object Clone();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Pozicio: x: {0} y: {1}\n ", Pozicio.x, Pozicio.y);
            sb.AppendFormat("Aktiv: {0} ", Aktiv);
            return sb.ToString();
        }

    }
}
