using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search_Algorithm
{
    public class Program
    {
        static int Binary_search(int[] arr,int target)
        {
     
            int start = 0;
            int end = arr.Length;
            int Count = 0;
            
            while (start < end)
            {
                Console.WriteLine(Count);
                ++Count;
                int mid = (start + end) / 2;

            
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    start = mid + 1;
                    

                }
                else if (arr[mid] > target)
                {
                    end = mid - 1;
                    
                }
            }
            return -1;   
        }
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5 };
            int target = 5;
            int ans = Binary_search(arr, target);
            Console.WriteLine(ans);

        }
    }
}
