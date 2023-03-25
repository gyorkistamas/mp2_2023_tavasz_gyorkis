using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Égitestek
{
    class Univerzum
    {
        // Ebben tároljuk az égitesteket
        // Mivel a bolygó és a csillag osztály az Égitest osztály gyermekosztályai, így kompatibilisek vele.
        // Ez azt jelenti, hogy mivel Egitest a listám típusa, így Csillag és Bolygó típusó objektumokat is bele tudok rakni.
        private List<Egitest> egitestek = new List<Egitest>();

        public void AddEgitest(string nev, int eletkor)
        {
            Egitest ujEgitest = new Egitest(nev, eletkor);

            if (egitestek.Contains(ujEgitest))
                throw new Exception("A lista már tartalmazza ezt az égitestet");

            egitestek.Add(ujEgitest);
        }

        public void AddCsillag(string nev, int eletkor, CsillagOsztaly osztaly, double atmero)
        {
            Csillag ujCsillag = new Csillag(nev, eletkor, osztaly, atmero);

            if (egitestek.Contains(ujCsillag))
                throw new Exception("A lista már tartalmazza ezt az égitestet");

            egitestek.Add(ujCsillag);
        }

        public void AddBolygo(string nev, int eletkor, BolygoOsztaly osztaly, double keringesiTavolsag)
        {
            Bolygo ujBolygo = new Bolygo(nev, eletkor, osztaly, keringesiTavolsag);

            if (egitestek.Contains(ujBolygo))
                throw new Exception("A lista már tartalmazza ezt az égitestet");

            egitestek.Add(ujBolygo);
        }

        // Amikor végigmegyünk a listánkon, hogy másolatot csináljunk belőle, akkor minden, a listában található elem Égitestként van kezelve, akkor is ha bolygóként vagy csillagként raktuk bele.
        // Tehát nem férünk hozzá a bolygó és a csillag osztályban deklarált mezőkhöz, metódusokhoz.
        // Ettől ezek nincsenek elveszve, csak vissza kell alakítanunk a Bolygó/Csillag típusúra, hogy előrjük ezeket is.
        public List<Egitest> OsszesEgitest
        {
            get
            {
                List<Egitest> masolat = new List<Egitest>();

                foreach(Egitest egitest in egitestek)
                {
                    if (egitest is Bolygo)
                    {
                        Bolygo temp = egitest as Bolygo;

                        Bolygo bolygoMasolat = new Bolygo(temp.Nev, temp.Eletkor, temp.BolygoOsztaly, temp.KeringesiTavolsag);

                        masolat.Add(bolygoMasolat);
                    }
                    else if (egitest is Csillag)
                    {
                        Csillag temp = egitest as Csillag;

                        Csillag csillagMasolat = new Csillag(temp.Nev, temp.Eletkor, temp.CsillagOsztaly, temp.Atmero);

                        masolat.Add(csillagMasolat);
                    }
                    else
                    {
                        Egitest egitestMasolat = new Egitest(egitest.Nev, egitest.Eletkor);

                        masolat.Add(egitestMasolat);
                    }
                }

                return masolat;
            }
        }


        // Csak a csillagokkal visszatérő property
        public List<Csillag> Csillagok
        {
            get
            {
                List<Csillag> masolat = new List<Csillag>();

                //Végigmegyünk a listán
                foreach(Egitest egitest in egitestek)
                {
                    //Az 'is' operátor segítségével megvizsgálhatjuk, hogy az objektumunk egy bizonyos típusu-e.
                    // Itt megnézzük a lista minden elemőrél, hogy az csillag-e. Ha igen, akkor ez igazat fog vissza adni.
                    if (egitest is Csillag)
                    {
                        // Ha csillag, akkor átkasztolom csillag típusúvá, hogy hozzáférjek a csillag osztályban deklarált dolgokhoz.
                        // Itt akár lehet ezt is használni, ugyanazt eredményezné:
                        // Csillag temp = egitest as Csillag
                        Csillag temp = (Csillag)egitest;

                        Csillag csillagMasolat = new Csillag(temp.Nev, temp.Eletkor, temp.CsillagOsztaly, temp.Atmero);

                        masolat.Add(csillagMasolat);

                    }
                }

                return masolat;
            }
        }

        public List<Csillag> NeutronCsillagok
        {
            get
            {
                List<Csillag> masolat = new List<Csillag>();

                foreach (Egitest egitest in egitestek)
                {
                    //Ennél az elágazásnál azt is meg kell vizsgálni, hogy a csillag neutroncsillag-e
                    // Ezért először megnézzük, hogy az aktuális listaelem csillag-e,
                    // ha igen, akkor itt helyben az and után zárójelben átkasztolom Csillaggá,
                    // és így a zárójel után egy ponttal már hozzáférek a Csillagosztályhoz
                    // Megjegy.: a rövidzár kiértékelés miatt ha az adott elem nem csillag,
                    // akkor a feltétel második részére nem fut rá, így ott nem keletkezhet
                    // amiatt hiba, hogy nem csillag-ot szeretnénk azzá kasztolni.
                    if (egitest is Csillag &&
                        (egitest as Csillag).CsillagOsztaly == CsillagOsztaly.Neutron)
                    {
                        Csillag temp = egitest as Csillag;

                        Csillag csillagMasolat = new Csillag(temp.Nev, temp.Eletkor, temp.CsillagOsztaly, temp.Atmero);

                        masolat.Add(csillagMasolat);
                    }
                }

                return masolat;
            }
        }

        // Bolygókat lekérdező property-t
        public List<Bolygo> Bolygok
        {
            get
            {
                List<Bolygo> masolat = new List<Bolygo>();

                foreach (Egitest egitest in egitestek)
                {
                    if (egitest is Bolygo)
                    {
                        Bolygo temp = (Bolygo)egitest;

                        Bolygo bolygoMasolat = new Bolygo(temp.Nev, temp.Eletkor, temp.BolygoOsztaly, temp.KeringesiTavolsag);

                        masolat.Add(bolygoMasolat);

                    }
                }

                return masolat;
            }
        }



        // Legtávolabbi bolygó
        // Bolygó a visszatérési értéke
        // Mi van akkor, ha üres a listánk
        public Bolygo LegTavolabbiBolygo
        {
            get
            {
                if (egitestek.Count == 0)
                {
                    throw new Exception("Az égitestek lista üres!");
                }

                Bolygo max = null;

                foreach(Egitest egitest in egitestek)
                {
                    if (egitest is Bolygo)
                    {
                        max = egitest as Bolygo;
                        break;
                    }
                }

                if (max == null)
                {
                    throw new Exception("A lista nem tartalmaz bolygót!");
                }

                foreach (Egitest egitest in egitestek)
                {
                    if (egitest is Bolygo &&
                        (egitest as Bolygo).KeringesiTavolsag > max.KeringesiTavolsag)
                    {
                        max = egitest as Bolygo;
                    }
                }

                return new Bolygo(max.Nev, max.Eletkor, max.BolygoOsztaly, max.KeringesiTavolsag);

            }
        }


    }
}
