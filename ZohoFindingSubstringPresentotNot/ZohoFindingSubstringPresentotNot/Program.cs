using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoFindingSubstringPresentotNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mainString = Console.ReadLine();
            string subString = Console.ReadLine();
            if (mainString.Contains(subString))
            {
                Console.WriteLine(mainString.IndexOf(subString));
            }
            else
            {
                Console.WriteLine("-1");
            }
            
        }
    }
}
