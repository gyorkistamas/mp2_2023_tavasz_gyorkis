using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _15_DiakokLinq2
{
    public class Diak : ICloneable
    {

        private Diak()
        { }

        public Diak(string vezetekNev, string keresztNev, DateTime szuletesiDatum, Gender gender, string varos, double jegyekAtlaga)
        {
            this.VezetekNev = vezetekNev;
            this.KeresztNev = keresztNev;
            this.Gender = gender;
            this.SzuletesiDatum = szuletesiDatum;
            this.Varos = varos;
            this.JegyekAtlaga = jegyekAtlaga;
        }

        public string VezetekNev { get; set; }
        public string KeresztNev { get; set; }
        public string Nev { get { return string.Format("{0} {1}", VezetekNev, KeresztNev); } }
        public Gender Gender { get; set; }
        public DateTime SzuletesiDatum { get; set; }
        public int Eletkor { get { return (int)((DateTime.Now - SzuletesiDatum).TotalDays / 365); } }
        public string Varos { get; set; }
        public double JegyekAtlaga { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} ({2} év) - {3} - {4} - {5}", Nev, SzuletesiDatum.ToString("yyyy.MM.dd"), Eletkor, Varos, Gender, JegyekAtlaga);
        }

        public object Clone()
        {
            Diak newDiak = new Diak();
            newDiak.VezetekNev = this.VezetekNev;
            newDiak.KeresztNev = this.KeresztNev;
            newDiak.Gender = Gender;
            newDiak.SzuletesiDatum = SzuletesiDatum;
            newDiak.Varos = this.Varos;
            newDiak.JegyekAtlaga = this.JegyekAtlaga;

            return newDiak;

        }
    }
}
