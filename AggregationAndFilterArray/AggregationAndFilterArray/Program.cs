using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationAndFilterArray
{
    internal class Program
    {
        public static int[] Aggregation(int[] arr1, int[] arr2)
        {
            ArrayList result = new ArrayList();

            foreach(int i in arr1)
            {
                if (i % 2 == 0)
                {
                    result.Add(i);

                }
            }
            foreach (int i in arr2)
            {
                if (i % 2 == 0)
                {
                    result.Add(i);


                }
            }
            return (int[])result.ToArray(typeof(int));


        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 4, 56, 7, 9, 89, 98, 70 };
            int[] arr2 = { 4, 6, 4, 36, 8, 10, 90, 78, 980 };
            int[] arr3=Aggregation(arr1, arr2);
            Array.ForEach(arr3, Console.WriteLine);


        }
    }
}
