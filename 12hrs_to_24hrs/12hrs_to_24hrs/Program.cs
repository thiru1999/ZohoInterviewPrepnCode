using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12hrs_to_24hrs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            DateTime d = DateTime.Parse(s);
            Console.WriteLine(d.ToString("HH:mm:ss"));
        }
    }
}
