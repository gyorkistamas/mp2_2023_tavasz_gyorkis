using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _13_BovitoMetodusok
{
    static class BovitoMetodus
    {
        public static string ToNameFormat(this string name, char karakter)
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

            newValue += karakter;

            return newValue;
        }
    }
}
