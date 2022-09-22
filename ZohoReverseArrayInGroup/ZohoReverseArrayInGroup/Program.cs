using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoReverseArrayInGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            reverseInGroups(arr, 5, 3);
            foreach(int i in arr) {
                Console.Write(i + " ");

            }
            
        }
        public static void reverseInGroups(int[] A, int N, int K)
        {
            int low = 0, high = K - 1;



            for (int i = 0; i < A.Length; i += K)

            {

                low = i;

                high = Math.Min(i + K - 1, A.Length - 1);



                while (low < high)

                {

                    int temp = A[high];

                    A[high] = A[low];

                    A[low] = temp;

                    low++; high--;

                }

            }
            //Your code here
        }

    }
}
