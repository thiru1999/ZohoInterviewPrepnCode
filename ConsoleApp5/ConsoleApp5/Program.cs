using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Program
    {
        public static string MakeTitle(string str)
        {
            string input = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
            return input;
        }
        public static void Main()
        {
            string k = MakeTitle("capitalize every word");
            Console.WriteLine(k);   
        }
    }
}
