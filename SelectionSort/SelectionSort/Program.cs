﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SelectionSort
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] opArray=Sort(new int[] { 23, 4, 354, 123, 24, 34 });
//            Array.ForEach(opArray, Console.Write);
//        }
//        public static int[] Sort(int[] arr)
//        {
//            int idx;
//            for(int i = 0; i < arr.Length; i++)
//            {
//                int min = arr[i];

//                for (int j = i + 1; j < arr.Length; j++)
//                {
//                    if (min > arr[j])
//                    {
//                        min = arr[j];
//                        idx = j;
//                        arr[idx] = arr[i];
//                        arr[i] = min;
//                    }

//                }

//            }
//            return arr;


//        }
//    }
//}
// C# program for implementation
// of Selection Sort
using System;

class GFG
{
	static void sort(int[] arr)
	{
		int n = arr.Length;

		// One by one move boundary of unsorted subarray
		for (int i = 0; i < n - 1; i++)
		{
			// Find the minimum element in unsorted array
			int min_idx = i;
			for (int j = i + 1; j < n; j++)
				if (arr[j] < arr[min_idx])
					min_idx = j;

			// Swap the found minimum element with the first
			// element
			int temp = arr[min_idx];
			arr[min_idx] = arr[i];
			arr[i] = temp;
		}
	}

	// Prints the array
	static void printArray(int[] arr)
	{
		int n = arr.Length;
		for (int i = 0; i < n; ++i)
			Console.Write(arr[i] + " ");
		Console.WriteLine();
	}

	// Driver code
	public static void Main()
	{
		int[] arr = { 64, 25, 12, 22, 11 };
		sort(arr);
		Console.WriteLine("Sorted array");
		printArray(arr);
	}

}
// This code is contributed by Sam007
