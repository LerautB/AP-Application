using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_Estudia.Services
{
    public class Services
    {
        public static string Shuffle(this string str)
        {
            char[] array = str.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }
        public string randomID(string nom, string prenom)
        {
            string x = "0123456789";
            prenom.SubString(0, prenom.Length + 1 );
            int code = SubString()
            string Identifiant = prenom + nom + code;
        }
        public string randomPassword(int length = 8)
        {

        }
    }
}
