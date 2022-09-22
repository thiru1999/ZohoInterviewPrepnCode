using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoKPangrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pangrams("thequickbrooxjumpsoverthelazydog"));
        }
        public static bool Pangrams(string str)
        {
            HashSet <char > storingAlphabet= new HashSet<char>();

            foreach(char i in str)
            {
                storingAlphabet.Add(i);

            }
            if (storingAlphabet.Count == 26)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
