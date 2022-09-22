using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoPattern3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for(int row = 0; row <= n; row++)
            {
                for(int i = 0; i < n - row; i++)
                {
                    Console.Write(" ");
                }
                for(int col=row; col >= 1; col--)
                {
                    Console.Write(col + " ");
                }
                for(int nxt = 2; nxt <= row; nxt++)
                {
                    Console.Write(nxt+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
