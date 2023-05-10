using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Generikusok
{
    class Rangsor<T> : IEnumerable where T: Versenyzo, IComparable
    {
        private List<T> versenyzok = new List<T>();

        public void Add(T versenyzo)
        {
            int index = 0;

            while(index < versenyzok.Count &&
                   versenyzok[index].CompareTo(versenyzo) > 0)
            {
                index++;
            }

            versenyzok.Insert(index, versenyzo);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (T versenyzo in versenyzok)
            {
                yield return versenyzo;
            }
        }

        public T this[int index]
        {
            get
            {
                return versenyzok[index];
            }
        }
    }
}
