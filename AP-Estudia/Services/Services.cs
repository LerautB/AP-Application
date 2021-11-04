using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_Estudia.Services
{
    public static  class Services
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
        public static string Repeat(string s, int n)
        {
            var result = s;

            for (var i = 0; i < n - 1; i++)
            {
                result += s;
            }

            return result;
        }
        public static string randomID(string nom, string prenom)
        {
            string x = "0123456789";
            prenom.Substring(0, prenom.Length + 1 );
            decimal A = 2 / x.Length;
            decimal nbRepeat = Math.Ceiling(A);
            x = Shuffle(Repeat(x, Convert.ToInt32(nbRepeat)));
            string code = x.Substring(1,2);
            string Identifiant = prenom + nom + code;
            return Identifiant;
        }
        public static string randomPassword(int length = 8)
        {
            string x = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            decimal A = length / x.Length;
            decimal nbRepeat = Math.Ceiling(A);
            string mdp = Shuffle(Repeat(x,Convert.ToInt32(nbRepeat)));
            return mdp.Substring(1,length);
        }
    }
}
