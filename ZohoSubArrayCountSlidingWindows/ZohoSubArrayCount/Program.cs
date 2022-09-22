using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoSubArrayCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubArrayCount(new int[] { 1, 2, 1, 3, 2 }, 2, 3);
        }

        static void SubArrayCount(int[] arr,int SubArrayNo,int noToCheck)   
        {
            int sum = 0;
            int count = 0; 
            for(int i = 0; i < SubArrayNo; i++)   //Sliding Window Technique+>Adding one element on the right removing one element on the Left this is called Sliding Window Techniques

            {
                sum += arr[i];
            }
            for(int i = SubArrayNo; i < arr.Length; i++)
            {
                if (sum == noToCheck)
                {
                    count++;
                }
                sum +=arr[i];
                sum -= arr[i - 2];
            }
            Console.WriteLine(count);
        }
    }
}
