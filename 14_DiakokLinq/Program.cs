using System.ComponentModel;
using System.Linq;

namespace _14_DiakokLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Diak> diakok = new List<Diak>();

            diakok.Add(new Diak("Diák 1", "Eger", "Nappali", new DateTime(2001, 10, 5), 2021, 3.6));

            diakok.Add(new Diak("Diák 2", "Hatvan", "Nappali", new DateTime(2001, 10, 5), 2021, 4.5));

            diakok.Add(new Diak("Diák 3", "Iklad", "Levelező", new DateTime(2000, 3, 10), 2022, 4.5));

            diakok.Add(new Diak("Diák 4", "Eger", "Levelező", new DateTime(2001, 10, 5), 2022, 2.7));

            diakok.Add(new Diak("Diák 5", "Hatvan", "Nappali", new DateTime(2002, 2, 10), 2020, 4.8));

            foreach (Diak diak in diakok)
            {
                Console.WriteLine(diak);
            }

            Console.WriteLine("-----------------------");

            Console.WriteLine("Nappalis diákok simán:");
            foreach (Diak diak in diakok)
            {
                if (diak.tagozat == "Nappali")
                {
                    Console.WriteLine(diak);
                }
            }

            Console.WriteLine("-----------------------");

            Console.WriteLine("Nappalis diákok linq-val:");

            var nappalisDiakok =
                diakok.Where(diak => diak.tagozat == "Nappali");

            foreach (Diak diak1 in nappalisDiakok)
            {
                Console.WriteLine(diak1);
            }


            Console.WriteLine("-----------------------");

            Console.WriteLine("Egri diákok:");

            var egriDiakok =
                diakok.Where(diak => diak.lakcim == "Eger");

            foreach (Diak diak in egriDiakok)
            {
                Console.WriteLine(diak);
            }


            Console.WriteLine("-----------------------");

            Console.WriteLine("Egri vagy Hatvani diákok:");

            var egriVagyHatvaniDiakok = diakok
                .Where(diak => diak.lakcim == "Hatvan" || diak.lakcim == "Eger");

            foreach (Diak diak in egriVagyHatvaniDiakok)
            {
                Console.WriteLine(diak);
            }


            Console.WriteLine("-----------------------");

            Console.WriteLine("Diákok, akiknek 4 felett van az átlaga:");

            var negyesAtlagFelettiDiakok = diakok
                .Where(diak => diak.Atlag > 4);

            foreach (Diak diak in negyesAtlagFelettiDiakok)
            {
                Console.WriteLine(diak);
            }

            Console.WriteLine("-----------------------");

            Console.WriteLine("Nappali és négyes átlag feletti diákok:");

            var nappaliVnegyesDiakok = diakok
                .Where(diak => diak.tagozat == "Nappali")
                .Where(diak => diak.Atlag > 4);

            foreach (Diak diak in nappaliVnegyesDiakok)
            {
                Console.WriteLine(diak);
            }

            Console.WriteLine("-----------------------");

            Console.WriteLine("Diákok átlag szerint:");

            var diakAtlagSzerintRendezve = diakok
                .OrderBy(diak => diak.Atlag);

            foreach (Diak diak in diakAtlagSzerintRendezve)
            {
                Console.WriteLine(diak);
            }

            Console.WriteLine("-----------------------");

            Console.WriteLine("Város szerint csoportosítva a diákok:");

            var varosSzerintCsoportositva = diakok
                .OrderBy(diak => diak.lakcim);

            foreach (var diak in varosSzerintCsoportositva)
            {
                Console.WriteLine(diak);
            }

            // 2022-ben kezdett diákok

            // Egri és 2023-ban kezdett diákok

            // 3-nál kisebb átlaggal rendelkező diákok

            // Egri, Nappalis 2022-ben kezdett diákok

            // Levelezős diákok átlag szerint sorba rendezve

            // legkisebb átlaggal rendelkező diák

            // Diákok átlagának az átlaga

            Console.ReadLine();
        }
    }
}