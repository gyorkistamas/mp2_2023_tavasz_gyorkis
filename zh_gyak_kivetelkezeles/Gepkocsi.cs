using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh_gyak_kivetelkezeles
{
    internal class Gepkocsi
    {
		//private List<char> karakterek = new List<char>()
		//{
		//	'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
		//          'A', 'B', 'C', 'D', 'E', '5', '6', '7', '8', '9',
		//      };

		private string karakterek = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-";

		private string rendszam;

		public string Rendszam
		{
			get { return rendszam; }
			private set
			{
				if (string.IsNullOrEmpty(value))
					throw new Exception("");

				for (int i = 0; i < value.Length; i++)
				{
					if (!karakterek.Contains(value[i]))
						throw new
						InvalidCharacterException(value[i]);
				}

				if (value.Length != 7)
					throw new Exception("A rendszám pontosan 7 karakterhosszú");

				for(int i = 0;i < 3; i++)
				{
					if (!char.IsLetter(value[i]))
						throw new Exception("Az első három karakter csak betű lehet");
				}

				for(int i = value.Length - 1; i > 3; i--)
				{
					if (!char.IsDigit(value[i]))
						throw new Exception("Az utolsó három karakter csak számjegy lehet");
				}

				if (value[6] == '0' && value[5] == '0' && value[4] == '0')
					throw new Exception("A vége nem lehet csupa nulla!");

				this.rendszam = value;
			}
		}

		private int evjarat;

		public int Evjarat
		{
			get { return evjarat; }
			set { evjarat = value; }
		}

		private int eredetiAr;

		public int GetEredetiAr()
		{
			return eredetiAr;
		}

		private void SetEredetiAr(int value)
		{
			this.eredetiAr = value;
		}

		private Allapot allapot;

		public Allapot Allapot
		{
			get { return allapot; }
			set { allapot = value; }
		}

		public int Kor
		{
			get;
		}

		public virtual int ExtraAr
		{
			get;
		}

		public Gepkocsi(string rendszam, int evjarat, int eredetiAr, Allapot allapot)
		{
			this.Rendszam = rendszam;
			this.Evjarat = evjarat;
			this.SetEredetiAr(eredetiAr);
			this.Allapot = allapot;
		}

		public Gepkocsi(string rendszam, int evjarat, int eredetiAr) : this(rendszam, evjarat, eredetiAr, Allapot.Megkimelt)
		{ }

		public virtual int VetelAr()
		{
			return 0;
		}

        public override string ToString()
        {
			string text = "";

			text += $"Rendszám: {this.Rendszam}\n";
			text += $"Évjárat: {this.Evjarat}\n";
			text += $"Eredeti ár: {this.GetEredetiAr()}\n";
			text += $"Állapot: {this.Allapot}\n";
			text += $"Kor: {this.Kor}\n";
			text += $"Extra ár: {this.ExtraAr}\n";
			text += $"Vételár: {this.VetelAr()}\n";

			// text += string.Format("Rendszám: {0}\n", this.Rendszam);

			return text;

		}

        public override bool Equals(object obj)
        {
			if (obj is null)
				return false;

			if (!(obj is Gepkocsi))
				return false;

			Gepkocsi masik = obj as Gepkocsi;

			return this.Rendszam == masik.Rendszam;
        }

    }
}
