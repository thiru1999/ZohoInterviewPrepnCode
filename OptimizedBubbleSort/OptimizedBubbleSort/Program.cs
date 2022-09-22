using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizedBubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 4, 3, 2, 1 };
            BubbleSort(arr);
            Array.ForEach(arr,input=>Console.Write(input+" "));
        }
        static void BubbleSort(int[] arr)   //Time complexity Worst Case=>o(n^2)
                                            //Space Complexity Worst Case  => O(n)
        {
            bool swap = false;
            for(int outerLoop=0;outerLoop< arr.Length; outerLoop++)
            {
                //For Each Step Maximum item will come at the Last Respective Index so no need to check it till the Last One;thats why len-i-1;
                for(int innerLoop = 1; innerLoop <= arr.Length - outerLoop - 1; innerLoop++)
                {
                    //Swap the Item is Smaller Than the previous item
                    if (arr[innerLoop] < arr[innerLoop - 1])
                    {
                        int temp = arr[innerLoop-1];
                        arr[innerLoop - 1] = arr[innerLoop];
                        arr[innerLoop] = temp;
                        swap = true;
                    }
                }
                //this is For Suppose if the array is already Sorted, in the First Loop if there is No swapping Happened Means We can break the Loop
                if (!swap)
                {
                    break;
                }
            }

        }
    }
}
