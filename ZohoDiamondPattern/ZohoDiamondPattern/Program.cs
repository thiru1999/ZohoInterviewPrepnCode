using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoDiamondPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 5;
            for (int i = 1; i <= 2 * n; i++)
            {
                int dummy = i > n ? 2 * n - i : i;  //n-(row-n)  =>2*n -row
                int noofSpaces = n - dummy;
                for (int k = 0; k < noofSpaces; k++)
                {
                    Console.Write(" ");

                }
                for (int j = 1; j <= dummy; j++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
