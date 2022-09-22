using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoCreateDiagonelMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int referenceI, referenceJ;

            int dummyRow = 0, dummyCol = 0;
            int[,] Matrix = new int[row, col];
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    Matrix[r, c] = int.Parse(Console.ReadLine());

                }
                Console.WriteLine();

            }
            for(int r = 0; r < row; r++)
            {
                referenceI = r;
                referenceJ = 0;
                while (referenceI>=0)
                {
                    Console.Write(Matrix[referenceI, referenceJ]+" ");
                    referenceJ++;
                    referenceI--;
                }
                Console.WriteLine();

            }
            for (int r = 1; r <= col-1; r++)
            {
                referenceI = col-1;
                referenceJ = r;
                while (referenceJ<=col-1)
                {
                    
                    Console.Write(Matrix[referenceI, referenceJ]+" ");
                    referenceJ++;
                    referenceI--;

                }
                Console.WriteLine();

            }
        }
    }
}
