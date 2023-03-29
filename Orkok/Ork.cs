using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Orkok
{
    internal class Ork
    {
		private static int KEZDO_ELETERO = 100;
		private static int KEZDO_SEBZES = 6;


		public Ork(int id, string nev)
		{
			this.Id = id;
			this.Nev = nev;
			this.Sebzes = KEZDO_SEBZES;
			this.Eletero = KEZDO_ELETERO;
		}


        private int id;

		public int Id
		{
			get
			{ 
				return id;
			}
			private set 
			{ 
				this.id = value;
			}
		}


		private string nev;

		public string Nev
		{
			get { return nev; }
			private set { nev = value; }
		}

		private int eletero;

		public int Eletero
		{
			get { return eletero; }
			protected set { eletero = value; }
		}

		public bool Halott
		{
			get
			{
				return this.Eletero <= 0;
			}
		}

		//public bool Halott()
		//{
		//	return this.Eletero <= 0;
		//}

		private int sebzes;

		public virtual int Sebzes
		{
			get { return sebzes; }
			protected set { sebzes = value; }
		}


		public virtual void Sebzodik(int sebzes)
		{
			this.Eletero -= sebzes;
		}

		protected virtual void Tamad(Ork ellenfel)
		{
			ellenfel.Sebzodik(this.Sebzes);
		}


		public virtual void TamadAnimacio(Ork ellenfel)
		{
			Tamad(ellenfel);
			Console.WriteLine("{0} puszta kézzel megtámadta a {1} orkot!", 
								this.Nev, ellenfel.Nev);
		}

        public override string ToString()
        {
			return string.Format("{0} - {1}: Sebzés: {2} Életerő: {2}", 
									this.Id, this.Nev, this.Sebzes, this.Eletero);
        }

    }
}
