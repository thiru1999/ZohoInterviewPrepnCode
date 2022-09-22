using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoSpiralMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1,2,3},
                           {4,5,6 },
                            {7,8,9 }};
            int rowStart = 0;
            int endRow = arr.GetLength(0);
            int colStart = 0;
            int endCol = arr.GetLength(1);
            while (rowStart<endRow && colStart<endCol)
            {
                for(int col = colStart; col < endCol; col++)
                {
                    Console.Write(arr[rowStart, col]);

                }
                rowStart++;
                for(int row = rowStart; row < endRow; row++)
                {
                    Console.Write(arr[row, endCol-1]);


                }
                endCol--;
                for(int col = endCol - 1; col >= colStart; col--)
                {
                    Console.Write(arr[endRow-1, col]);
                }
                endRow--;
                for(int row = endRow-1; row >= rowStart; row--)
                {

                    Console.Write(arr[row,colStart]);

                }
                colStart++;
            }
           

        }
    }
}
