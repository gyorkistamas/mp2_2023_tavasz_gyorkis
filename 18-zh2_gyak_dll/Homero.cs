using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_zh2_gyak_dll
{
    public class Homero : Szenzor, IHomero
    {
        bool aktiv = false;
        public void HatarokatBeallit(int alsoHatar, int felsoHatar)
        {
            AlsoHatar = alsoHatar;

            FelsoHatar = felsoHatar;
        }

        public double HomersekletetMer()
        {
            Random r = new Random();
            if (aktiv)
            {
                return r.Next(AlsoHatar * 100, FelsoHatar * 100) / 100.0;
            }
            throw new SzenzorInaktivException();
        }

        private int alsoHatar;

        public int AlsoHatar
        {
            get { return alsoHatar; }

            private set
            {
                if (value < -60)
                {
                    throw new AlacsonyAlsoHatarException();
                }

                alsoHatar = value;
            }
        }

        public int FelsoHatar
        {
            get;
            private set;
        }

        public override bool Aktiv => throw new NotImplementedException();

        public bool GetAktiv()
        {
            return aktiv;
        }
        public void SetAktiv(bool x)
        {
            aktiv = x;
        }

        public override void Adatkuldes()
        {
            double mertHomerseklet = HomersekletetMer();

            Console.WriteLine("Hőmérséklet a(z) ({0} ;{1}) pozíción {2}" +
                "időpontban : {3}°C\r\n", Pozicio.x, Pozicio.y, DateTime.Now, mertHomerseklet);
        }

        public override object Clone()
        {
            Homero masolat = new Homero(Pozicio.x, Pozicio.y,AlsoHatar, FelsoHatar);
            return masolat;
            
        }
        public Homero(int x, int y, int alsohatar, int felsohatar) : base(new Pozicio(x, y))
        {
            HatarokatBeallit(alsohatar, felsohatar);
            SetAktiv(true);
        }
        public override string ToString()
        {
            return string.Format("Hőmérő: {0}, A:{1} - F{2}",
                base.ToString(), AlsoHatar, FelsoHatar);
        }
    }
}
