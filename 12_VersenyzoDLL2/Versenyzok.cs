using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_VersenyzoDLL2
{
    public class VersenyzokContainer
    {
        private List<Versenyzo> versenyzok = new List<Versenyzo>();

        public List<Versenyzo> Versenyzok
        {
            get
            {
                //Klónozás ide
                return versenyzok;
            }
        }

        public void AddVersenyzo(Versenyzo versenyzo)
        {
            //Megvizsgálni, hogy tartalmazza-e a lista már a versenyzőt

            if (versenyzok.Count == 0)
            {
                versenyzok.Add(versenyzo);
                return;
            }

            int index = 0;

            for (int i = 0; i < versenyzok.Count; i++)
            {
                if (Versenyzok[i].CompareTo(versenyzo) < 0)
                {
                    index++;
                }
                else
                {
                    break;
                }
            }

            versenyzok.Insert(index, versenyzo);
        }
    }
}
