using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizedSelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[]{5,4,3,2,1};

            SelectionSort(arr);
            Array.ForEach(arr, op => Console.Write(op + " "));

        }
        static void SelectionSort(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                int last = arr.Length - i - 1;  //Fnding the Last Index
                int maxIndex = FindingMaxIndex(arr, 0, last);   //Finding the Max Index of the array
                int temp = arr[last];
                arr[last] = arr[maxIndex];   //Swapping the Max ARrAY with the Last Index
                arr[maxIndex] = temp;
            }

        }
        static int FindingMaxIndex(int[] arr,int start,int last)
        {
            int max = arr[0];
            for(int i = 1; i <= last; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }

            }
            return Array.IndexOf(arr, max);
        }
    }
}
