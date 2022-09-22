using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizedInsertionSort
{
    internal class Program
    {
        static void InsertionSort(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i + 1; j > 0; j--)
                {
                    if (arr[j] < arr[j-1]){
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                         
                    }
                    else
                    {
                        break;
                    }
                }
                
            }
        }
        static void Swap(int[] arr,int last,int maxIndex )
        {
           int temp = last;
           last = maxIndex;   //Swapping the Max ARrAY with the Last Index
            maxIndex = temp;
        }
        
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 4, 3, 2, 1 };
            InsertionSort(arr);
            Array.ForEach(arr, output => Console.Write(output));
        }
    }
}
