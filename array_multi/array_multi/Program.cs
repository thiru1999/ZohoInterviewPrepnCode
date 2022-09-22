using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_multi
{
      public class Program
      { 
            
            
           public static  double Maximum_find(double[] arr)
           {
               double min = arr[0];
               foreach (var item in arr)
               {
              
                   if (item < min)
                   {
                       min = item;
                   }
               }
               return min;
           }


           public static void FindLargest( double[][] values)
           {
               List<double> list = new List<double>();
               for (int i = 0; i < values.Length; i++)
               {
                   double k = Program.Maximum_find(values[i]);
                   list.Add(k);
                   

               }
               Console.WriteLine(String.Join(",", list));

        }
           static void Main(string[] args)
           {
            double[][] arr = new double[][]
            {
                   new double[] { 1, 2, 3 },
                   new double[] { 4, 5, 6 },
                   new double[] { 1,2}

            };
                 
               Program p = new Program();
               Program.FindLargest(arr);





           }
      }


   /* class ArrayClass2D
    {
        static void Print2DArray(int[,] arr)
        {
            // Display the array elements.
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    System.Console.WriteLine("Element({0},{1})={2}", i, j, arr[i, j]);
                }
            }
        }
        static void Main()
        {
            // Pass the array as an argument.
            Print2DArray(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }*/
}
