
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoMatrix90Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            try
            {
                if (col != row)
                {
                    throw new Exception("Row Must be Equal To the Column...bcz Square Matrix");

                }

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("eNTER THE column value Again ");
                col = int.Parse(Console.ReadLine());

            }
            int[,] Matrix = new int[row, col];
            for (int r = 0; r < row; r++)
            {
                for(int c = 0; c < col; c++)
                {
                    Matrix[r, c] = int.Parse(Console.ReadLine());

                }
                Console.WriteLine();

            }
            for(int c = col - 1; c >= 0; c--)
            {
                for(int r = 0; r < row; r++)
                {
                    Console.Write(Matrix[r,c]);


                }
                Console.WriteLine();

            }
        }
    }
}
