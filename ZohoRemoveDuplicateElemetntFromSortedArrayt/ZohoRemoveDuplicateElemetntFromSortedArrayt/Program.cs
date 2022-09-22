using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoRemoveDuplicateElemetntFromSortedArrayt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = Distinct(new int[] { 1, 2, 2, 3,5 });
            Console.WriteLine(k);
        }
        public static int Distinct(int[] arr)
        {
            int flag = 0;
            int count = 0;
            for(int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i + 1] && flag==0)
                {
                    count++;
                    flag = 1;

                }
                if (arr[i] != arr[i + 1])
                {
                    count++;
                }

            }
            return count;
        }
    }
}
