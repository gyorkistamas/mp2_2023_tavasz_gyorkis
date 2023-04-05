using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh_gyak_kivetelkezeles
{
    internal class RendszamIsNullOrEmptyException : Exception
    {
        public RendszamIsNullOrEmptyException(string message) 
            : base(message)
        { }

        public RendszamIsNullOrEmptyException()
        { }
    }
}
