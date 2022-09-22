using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoIsIsogram
{
    internal class Program
    {
        public static bool isIsogram(string s)
        {
            HashSet<char> storingString = new HashSet<char>();
            foreach (char i in s)
            {

                if (!storingString.Contains(i))
                {
                    storingString.Add(i);

                }
                else 
                {

                    return false;
                }

            }
            return true;
            //Your code here
        }
        static void Main(string[] args)
        {
            string s = "asbzfqgwlmftdkmrbjuivtkawqpliqgiikjpcqmoctjffvwhhtpeobenrvyzlhjvrtlvlzjnusvzqtixozbfbisudqwrzf";
            bool k = isIsogram(s);
            Console.WriteLine(k);
            
        }
    }
}
