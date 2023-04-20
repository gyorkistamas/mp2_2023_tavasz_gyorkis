using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Konyvek
{
    class Konyvesbolt : IEnumerable
    {
        private List<Konyv> konyvek;

        private string nev;

        public string Nev { get { return nev; } set { this.nev = value; } }

        public Konyvesbolt(string nev) 
        {
            this.Nev = nev;

            konyvek = new List<Konyv>();
        }


        public void Addkonyv(string szerzo, string cim, int ar, string isbn)
        {

            Konyv konyv = new Konyv(szerzo, cim, ar, isbn);

            if (konyvek.Contains(konyv))
            {
                throw new Exception("Ez a könyv már megtalálható a könyvesboltban");
            }


            konyvek.Add(konyv);
        }

        public List<Konyv> OsszesKonyv
        {
            get
            {
                List<Konyv> masolat = new List<Konyv>();

                foreach (Konyv konyv in konyvek)
                {
                    masolat.Add(konyv.Clone() as Konyv);
                }

                return masolat;
            }
        }

        public void RemoveKonyv(string szerzo, string cim)
        {
            for (int i = 0; i < konyvek.Count; i++)
            {
                if (konyvek[i].Szerzo == szerzo && konyvek[i].Cim == cim)
                {
                    konyvek.RemoveAt(i);
                    break;
                }
            }
        }

        public List<Konyv> AdottSzerzojuKonyvek(string szerzo)
        {
            List<Konyv> masolat = new List<Konyv>();

            foreach (Konyv konyv in konyvek)
            {
                if (konyv.Szerzo == szerzo)
                {
                    masolat.Add(konyv.Clone() as Konyv);
                }
            }

            return masolat;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < konyvek.Count; i++)
            {
                yield return konyvek[i].Clone() as Konyv;
            }
        }

        public Konyv LegdragabbKonyv
        {
            get
            {
                if (konyvek.Count == 0)
                {
                    throw new Exception("A könyvesbolt üres.");
                }

                Konyv legdragabb = konyvek[0];

                for (int i = 1; i < konyvek.Count; i++)
                {
                    if (konyvek[i].Ar > legdragabb.Ar)
                    {
                        legdragabb = konyvek[i];
                    }
                }

                return legdragabb.Clone() as Konyv;

            }
        }

        public Konyv this[int index]
        {
            get
            {
                if (index >= konyvek.Count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                return konyvek[index].Clone() as Konyv;
            }
        }

        public Konyv this[string szerzo, string cim]
        {
            get
            {
                Konyv masolat = null;

                foreach (Konyv konyv in konyvek)
                {
                    if (konyv.Szerzo == szerzo && konyv.Cim == cim)
                    {
                        masolat = konyv;
                        break;
                    }
                }

                if (masolat == null)
                {
                    throw new Exception("Nincs ilyen szerzőjű és című könyv a könyvesboltban!");
                }

                return masolat.Clone() as Konyv;
            }
        }

        // ISBN szám alapján indexer
        public Konyv this[string isbn]
        {
            get
            {
                Konyv masolat = null;

                foreach (Konyv konyv in konyvek)
                {
                    if (konyv.Isbn == isbn)
                    {
                        masolat = konyv;
                        break;
                    }
                }

                if (masolat == null)
                {
                    throw new Exception("Nincs ilyen szerzőjű és című könyv a könyvesboltban!");
                }

                return masolat.Clone() as Konyv;
            }
        }
    }
}
