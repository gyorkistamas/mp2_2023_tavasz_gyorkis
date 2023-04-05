using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh_gyak_kivetelkezeles
{
    internal class InvalidCharacterException : Exception
    {
        public char InvalidCharater { get; private set; }

        public InvalidCharacterException(char character)
            : base ("Nem megengedett karaktert használt!")
        {
            this.InvalidCharater = character;
        }
    }
}
