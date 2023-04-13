using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingatlanok
{
    internal class CsaladiHaz : Ingatlan
    {
		private int telekSzelesseg;

		public int TelekSzelesseg
		{
			get { return telekSzelesseg; }
			private set {
				if (value < 10 || value > 100)
				{
					throw new Exception("A telek szélessége 10 és 100 között legyen.");
				}
				if (value < base.Szelesseg)
				{
					throw new Exception("A telek szélessége nem lehet kisebb az ingatlan szélességénél");
				}
				telekSzelesseg = value; }
		}

		private int telekHosszusag;

		public int Telekhosszusag
		{
			get 
			{
				return telekHosszusag;
			}
			private set
			{
                if (value < 10 || value > 100)
                {
                    throw new Exception("A telek hosszusag 10 és 100 között legyen.");
                }
                if (value < base.GetHosszusag())
                {
                    throw new Exception("A telek hosszusag nem lehet kisebb az ingatlan hosszusaganal");
                }
				telekHosszusag = value;
			}
		}

		private int szintek;

		public int Szintek
		{
			get { return szintek; }
			set
			{
				if (value < 1 || value > 3)
				{
					throw new Exception("A szint nem lehet kisebb mint 1, vagy nagyobb mint 3");		
				}
				this.szintek = value;
			}
		}

        public override int Alapterulet
		{
			get
			{
				return base.Alapterulet * this.Szintek;
			}
		}

		public int KertTerulet
		{
			get
			{
				return (this.telekSzelesseg * this.telekHosszusag) - base.Alapterulet;
			}
		}

        public CsaladiHaz(string helyrajziSzam, int szelesseg, int hosszusag, Allapot allapot, int telekSzelesseg, int telekHosszusag, int szintek)
			:base(helyrajziSzam,szelesseg,hosszusag,allapot)
        {
			this.TelekSzelesseg = telekSzelesseg;
			this.Telekhosszusag = telekHosszusag;
			this.Szintek = szintek;
        }

        public CsaladiHaz(string helyrajziSzam, int szelesseg, int hosszusag, int telekSzelesseg, int telekHosszusag)
            : this(helyrajziSzam, szelesseg, hosszusag, Allapot.Ujepitesu, telekSzelesseg, telekHosszusag, 1)
        {
            
        }
		public override int VetelAr()
		{
			int ar = 0;
			switch (this.Allapot)
			{
				case Allapot.Ujepitesu: ar = Alapterulet * 650000;
					break;
				case Allapot.Korszerusitett:
                    ar = Alapterulet * 600000;
                    break;
				case Allapot.Felujitott:
                    ar = Alapterulet * 550000;
                    break;
				case Allapot.Felujitando:
                    ar = Alapterulet * 400000;
                    break;
				default:ar = 0;
					break;
			}
			ar = ar + KertTerulet * 200000;
            return ar;
		}
        public override string ToString()
        {
            return base.ToString()+ telekHosszusag + telekSzelesseg + szintek + KertTerulet ;
        }
    }
}
