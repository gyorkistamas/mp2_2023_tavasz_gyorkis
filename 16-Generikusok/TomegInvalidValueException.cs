using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Generikusok
{
    internal class TomegInvalidValueException : Exception
    {
        public int ertek;

        public TomegInvalidValueException(string message, int ertek)
            :base(message)
        {
            this.ertek = ertek;
        }
    }
}
