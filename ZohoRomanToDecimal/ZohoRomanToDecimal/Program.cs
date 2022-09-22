using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoRomanToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = RomanToInt("MCMXCIV");
            Console.WriteLine(op);
        }
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> Conversion = new Dictionary<char, int>();
            int op = 0;
            Conversion['I'] = 1;
            Conversion['V'] = 5;
            Conversion['X'] = 10;
            Conversion['L'] = 50;

            Conversion['C'] = 100;
            Conversion['D'] = 500;

            Conversion['M'] = 1000;
            for (int i = 0; i < s.Length; i++)
            {
                if (i >= s.Length - 1)
                {
                    op += Conversion[s[i]];
                    return op;

                }

                if (Conversion[s[i]] < Conversion[s[i + 1]])
                {
                    op += Conversion[s[i + 1]] - Conversion[s[i]];
                    i++;
                }
                else
                {
                    op += Conversion[s[i]];
                }
                
            }
            return op;

        }
    }
}
    


