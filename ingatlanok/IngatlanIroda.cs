using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingatlanok
{
    internal class IngatlanIroda
    {
        private List<Ingatlan> ingatlanok=new List<Ingatlan>();

        public List<CsaladiHaz> CsaladiHazak
        {
            get
            {
                List<CsaladiHaz> UjLista = new List<CsaladiHaz>();
                for (int i = 0; i < ingatlanok.Count; i++)
                {
                    if (ingatlanok[i] is CsaladiHaz)
                    {
                        CsaladiHaz temp = ingatlanok[i] as CsaladiHaz;

                        CsaladiHaz masolat = new CsaladiHaz(
                            temp.HelyrajziSzam,
                            temp.Szelesseg,
                            temp.GetHosszusag(),
                            temp.Allapot,
                            temp.TelekSzelesseg,
                            temp.Telekhosszusag,
                            temp.Szintek);


                        UjLista.Add(masolat);
                    }
                }
                return UjLista;
            }
        }
        public CsaladiHaz LCSFCSH
        {
            get
            {
                CsaladiHaz mincs = null;
                foreach(Ingatlan i in ingatlanok)
                {
                    if(i is CsaladiHaz)
                    {
                        if(i.Allapot == Allapot.Felujitando
                            &&(mincs== null || i.VetelAr() < mincs.VetelAr()))
                        {
                            mincs = i as CsaladiHaz;
                        }
                    }
                }

                if (mincs==null) 
                {
                    throw new Exception("Nincs családi ház a listában");
                }

                CsaladiHaz s = new CsaladiHaz(mincs.HelyrajziSzam, mincs.Szelesseg, mincs.GetHosszusag(), mincs.Allapot, mincs.TelekSzelesseg, mincs.Telekhosszusag, mincs.Szintek);

                return s;
            }
        }

        public Ingatlan this[string index]
        {
            get
            {
                Ingatlan keresett = null;
                for (int i = 0; i < ingatlanok.Count; i++)
                {
                    if (ingatlanok[i].HelyrajziSzam == index)
                    {
                        keresett = ingatlanok[i];
                        break;
                    }
                }
                if (keresett == null)
                {
                    //throw new Exception("Nincs ilyen helyrajzi számú ingatlan a listában");

                    throw new IndexOutOfRangeException();
                }
                //Másolás
                return keresett;
            }
        }
        public void AddIngatlan(Ingatlan newingatlan)
        {
            if (ingatlanok.Contains(newingatlan))
            {
                throw new Exception("Az ingatlan már szerepel az adatbázisban!");
            }
            ingatlanok.Add(newingatlan);
        }

        public List<CsaladiHaz> CsaladiHazakAdottArig(Allapot allapot, int maxAr)
        {
            List<CsaladiHaz>temp= new List<CsaladiHaz>();
            for (int i = 0; i < temp.Count; i++)
            {
                if (ingatlanok[i] is CsaladiHaz && ingatlanok[i].Allapot ==allapot && ingatlanok[i].VetelAr() < maxAr)
                {
                    temp.Add(ingatlanok[i] as CsaladiHaz);
                }
            }
            return temp;
        }


    }
}
