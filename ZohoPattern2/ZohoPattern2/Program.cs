using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoPattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=4;
            for (int i = 0; i <2 *n-1; i++){
                
                for(int j = 0; j <2 * n-1; j++)
                {
                    int dummy = n-(Math.Min(Math.Min(i, j), Math.Min((2 * n-2) - i, (2 * n-2 )- j)));
                    Console.Write(dummy + " ");

                }
                Console.WriteLine();

            }
        }
    }
}
