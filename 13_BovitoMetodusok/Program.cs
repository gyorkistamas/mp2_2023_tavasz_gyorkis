namespace _13_BovitoMetodusok
{
    internal class Program
    {

        static string ToNameFormat(string name)
        {
            string newValue = "";
            for (int i = 0; i < name.Length; i++)
            {
                if (i == 0 || name[i - 1] == ' ')
                {
                    newValue += char.ToUpper(name[i]);
                }
                else
                {
                    newValue += name[i];
                }
            }

            return newValue;
        }

        static void Main(string[] args)
        {
            string nev = "györkis tamás";

            Console.WriteLine(nev.ToNameFormat('*'));

            Console.ReadLine();
        }
    }
}