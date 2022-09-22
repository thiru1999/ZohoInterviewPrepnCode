using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ZohoRegexMobieNoChecking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Regex rx = new Regex(@"^\+[0-9]{2}\-[0-9]{4,5}\-[0-9]{4,5}"); //FOR Phone Number Verification
            //string no = "+91-78234-7234";
            string no = "kuma+rveera227@gmail.comff";
            Regex rx = new Regex(@"[a-z 0-9 _ \-\.]+[@]+[a-z]+[a-z]{2,3}");   //.com or .in{2,3}
            Console.WriteLine(rx.IsMatch(no));
           
        }
    }
}
