using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n;
            int flag = 1;
            n = int.Parse(Console.ReadLine());
            int m;
            m = n / 2;
            for(int i = 2; i < m; i++)
            {
                if (n % i == 0)
                {
                    
                    flag = 0;
                    break;
                }

                

            }
            if (flag == 0)
            {
                Console.WriteLine("Not rprime");
            }
            else
            {
                Console.WriteLine(" rprime");
            }
        }
    }
}
