using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh_gyak_kivetelkezeles
{
    internal class RendszamInvalidLengthException : Exception
    {
        public int Hossz { get; private set; }

        public RendszamInvalidLengthException(int hossz)
            : base("A rendszám pontosan 7 karakterhosszú")
        {
            this.Hossz = hossz;
        }
    }
}
