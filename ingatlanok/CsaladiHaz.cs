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


    }
}
