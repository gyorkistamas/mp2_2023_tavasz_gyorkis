using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_DiakokLinq2
{
    class Diakok : IEnumerable
    {
        private List<Diak> diakok = new List<Diak>();

        public IEnumerator GetEnumerator()
        {
            foreach(Diak diak in diakok)
            {
                yield return diak.Clone() as Diak;
            }
        }

        public void AddDiak(Diak diak)
        {
            diakok.Add(diak.Clone() as Diak);
        }

        public delegate bool DiakDelegate(Diak diak);
        public List<Diak> Where(DiakDelegate predikatum)
        {
            List<Diak> temp = new List<Diak>();

            foreach (Diak diak in diakok)
            {
                if (predikatum(diak))
                {
                    temp.Add(diak.Clone() as Diak);
                }
            }

            return temp;
        }


        //public delegate double AverageDelegate(Diak diak);
        public double Average(Func<Diak, double> selector)
        {
            double sum = 0;

            foreach (Diak diak in diakok)
            {
                sum += selector(diak);
            }

            return sum / diakok.Count;
        }

        // Max kiválasztó függvény
        public double Max(Func<Diak, double> selector)
        {
            double max = double.MinValue;

            foreach (Diak diak in diakok)
            {
                if (selector(diak) > max)
                {
                    max = selector(diak);
                }
            }

            return max;
        }

        // Hf.: Szum, Min, Count

    }
}
