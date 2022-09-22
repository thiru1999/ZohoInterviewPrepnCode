using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoSnakePatternProblem
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[,] snakeMatrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    //        for(int row = 0; row < 3; row++)
    //        {
    //            if (row % 2 == 0)
    //            {
    //                for (int col = 0; col < 3; col++)
    //                {
    //                    Console.Write(snakeMatrix[row, col]+" ");


    //                }

    //            }

    //            else if(row % 2 != 0)
    //            {
    //                for (int col = 2; col >=0; col--)
    //                {
    //                    Console.Write(snakeMatrix[row, col] + " ");


    //                }
    //            }
    //            Console.WriteLine();


    //        }
    //    }
    //}




    class Solution
    {
        public static void Main()
        {
            List<List<int>> A = new List<List<int>>();
            A.Add(new List<int>(){ 1, 2, 3 });
            A.Add(new List<int>() { 4, 5, 6 });
            A.Add(new List<int>() { 7, 8, 9 });
            List<int> output = new List<int>();
            output = snakePattern(A);
            foreach(int i in output)
            {
                Console.Write(i+" ") ;
            }


           
        }
        //Function to return list of integers visited in snake pattern in matrix.
        public static  List<int> snakePattern(List<List<int>> matrix)
        {

            int length = matrix.Count;
            List<int> opList = new List<int>();
            for (int row = 0; row < 3; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        opList.Add(matrix[row][ col]);


                    }

                }

                else if (row % 2 != 0)
                {
                    for (int col = 2; col >= 0; col--)
                    {
                        opList.Add(matrix[row][ col]);


                    }
                }
            }
            return opList;
        }
    }

       
}
