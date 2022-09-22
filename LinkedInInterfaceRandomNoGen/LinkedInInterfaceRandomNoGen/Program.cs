using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInInterfaceRandomNoGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomNoGen n = new RandomNoGen();
            n.GetRandomNum(20);
        }
    }
}
