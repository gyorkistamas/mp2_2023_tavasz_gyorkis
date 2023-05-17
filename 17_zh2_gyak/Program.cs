using _18_zh2_gyak_dll;
using System.Security.Cryptography.X509Certificates;

namespace _17_zh2_gyak
{
    internal class Program
    {
        static Random rnd = new Random();

        static void TelepitSzenzorHalozat(string input, SzenzorHalozat halozat)
        {
            
            try
            {
                StreamReader sr = new StreamReader(input);
                while (!sr.EndOfStream)
                {
                    try
                    {
                        string sor = sr.ReadLine();
                        string[] adatok = sor.Split(';');
                        Homero homero = new Homero(int.Parse(adatok[1]), int.Parse(adatok[2]),
                                                   int.Parse(adatok[3]), int.Parse(adatok[4]));
                        if (rnd.NextDouble() < 0.3)
                            homero.SetAktiv(false);
                        halozat.Telepit(homero);
                    }
                    catch (AlacsonyAlsoHatarException e)
                    {
                        Console.WriteLine("Hibás alsó határt talált.");
                    }
                    catch(SzenzorInaktivException e) 
                    {
                        Console.WriteLine("A fájlban van inaktív szenzor.");
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Váratlan hiba történt!");
                    }
                    
                }
                sr.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("A fájl beolvasása során hiba történt!");              
            }

            
        }

        static void Main(string[] args)
        {
            SzenzorHalozat halozat = new SzenzorHalozat();
            TelepitSzenzorHalozat("szenzorok.csv", halozat);

            foreach (Szenzor szenzor in halozat)
            {
                Console.WriteLine(szenzor);
            }

            Console.WriteLine("Aktív szenzorok: ");
            foreach (Szenzor szenzor in halozat.AktivSzenzorok)
            {
                Console.WriteLine(szenzor);
            }

            
            double atlag = halozat.AktivAtlag(szenzor => szenzor.Pozicio.x);
            Console.WriteLine("Átlag: {0}", atlag);

            Console.ReadLine();
        }
    }
}