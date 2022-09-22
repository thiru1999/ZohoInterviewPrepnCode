using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoPatternXProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int size = input.Length;
            for(int iter = 0; iter < size; iter++)
            {
                for(int iterchecking = 0; iterchecking < size; iterchecking++)
                {
                    if (iter == iterchecking || iterchecking == size - iter-1)
                    {
                        Console.Write(input[iter]);
                    }
                    else
                    {
                        Console.Write(" ");


                    }

                }
                Console.WriteLine();
                
            }
        }
    }
}
