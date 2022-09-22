using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int addFive = 5;
            int k=i.change(addFive);
            Console.WriteLine(k);

        }
    }
    public static class intExtension
    {
        public static int change(this int i,int anotherNumber)
        {
            return i + anotherNumber;

        }
    }

}
