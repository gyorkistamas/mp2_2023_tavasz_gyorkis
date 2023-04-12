using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingatlanok
{
    internal class Ingatlan
    {
		private string helyrajziSzam;

		public string HelyrajziSzam
		{
			get { return helyrajziSzam; }
			private set {
				if (string.IsNullOrEmpty(value))
					throw new Exception("A helyrajzi szám nem lehet nullérték");

				foreach (char karakter in value)
				{
					if (!(char.IsNumber(karakter) || karakter == '/'))
						throw new Exception("A helyrajzi szám csak számokat, illetve '/' karaktert tartalmazhat");
				}

				if (value[0] == '/')
					throw new Exception("Az első karakternek számnak kell lennie");
                if (value[value.Length-1] == '/')
                    throw new Exception("Az utolsó karakternek számnak kell lennie");

                if (value[0] == '0')
                    throw new Exception("Az első karakter nem lehet 0");

                helyrajziSzam = value;
			}
		}

		private bool szelessegBeallitva = false;

		private int szelesseg;

		public int Szelesseg
		{
			get { return szelesseg; }
			private set
			{
				if (value < 4)
				{
					throw new Exception("A szélesség értéke túl alacsony.");
				}
                if (value > 20)
                {
                    throw new Exception("A szélesség értéke túl magas.");
                }
				if (szelessegBeallitva)
				{
					throw new Exception("A szélesség már be lett állítva korábban");
				}
                szelesseg = value;
				szelessegBeallitva = true;
			}
		}

		private bool hosszusagBeallitva = false;

		private int hosszusag;

		public int GetHosszusag()
		{
			return hosszusag;
		}

		private void SetHosszusag(int hosszusag)
        {
			if (hosszusag< 4)
			{
					throw new Exception("A szélesség értéke túl alacsony.");
			}
            if (hosszusag > 20)
            {
                    throw new Exception("A szélesség értéke túl magas.");
			}
			if (hosszusagBeallitva)
			{
				throw new Exception("A szélesség már be lett állítva korábban");
			}
			this.hosszusag = hosszusag;
			hosszusagBeallitva = true;
		}

		public Allapot Allapot { get; set; }
		public virtual int Alapterulet
		{
			get
			{
				return hosszusag * szelesseg;
			}
		}

		public Ingatlan(string helyrajziSzam, int szelesseg, int hossz, Allapot allapot)
		{
			this.HelyrajziSzam = helyrajziSzam;
			this.Szelesseg = szelesseg;
			this.SetHosszusag(hossz);
			this.Allapot = allapot;
		} 

		public Ingatlan(string helyrajziSzam, int szelesseg, int hossz)
			: this(helyrajziSzam, szelesseg, hossz, Allapot.Ujepitesu)
		{ }

		public int Vetelar()
		{
			switch (Allapot)
			{
				case Allapot.Ujepitesu:
					return Alapterulet * 600000;
				case Allapot.Korszerusitett:
					return Alapterulet * 500000;
				case Allapot.Felujitott:
					return Alapterulet * 450000;
				case Allapot.Felujitando:
					return Alapterulet * 300000;
				default:
					throw new Exception("nincs ilyen állapot");
			}
		}

        public override string ToString()
        {
			return string.Format("Helyrajzi Szám: {0}\n Szélesség: {1}\n Hossz: {2}\n Állapot: {3}\n Alapterület: {4}\n Vétel Ár: {5}",   
		this.HelyrajziSzam,
				this.Szelesseg,
				this.GetHosszusag(),
				this.Allapot,
				this.Alapterulet,
				this.Vetelar());
        }
        public override bool Equals(object obj)
        {
			if(obj is null)
			 return false;
			if (!(obj is Ingatlan))
				return false;
			Ingatlan ingatlan2 = obj as Ingatlan;
			return this.HelyrajziSzam == ingatlan2.HelyrajziSzam;
        }

    }
}
