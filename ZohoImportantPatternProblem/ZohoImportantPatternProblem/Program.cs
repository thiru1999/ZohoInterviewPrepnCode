
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoImportantPatternProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 11;
            int space =0;
            int star = n / 2 + 1;
            for(int i = 1; i <= 11; i++)
            {
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*" );
                }
                for(int k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }
                for(int l = 0; l < star; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
                if(i< n / 2 + 1)
                {
                    star -= 1;
                    space += 2;
                }
                if (i == n / 2 + 1)
                {
                    space = n - 3;
                    star = 2;
                }
                if (i > n / 2 + 1)
                {
                    star += 1;
                    space -= 2;
                }

            }
            
        }
    }
}
