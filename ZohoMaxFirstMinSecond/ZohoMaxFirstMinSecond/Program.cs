﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ZohoMaxFirstMinSecond
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110 };
//            rearrange(arr, 11);
//            foreach(int i in arr)
//            {
//                Console.Write(i + " ");
//            }


//        }
//        public static void rearrange(int[] arr, int n)
//        {
//            List<int> dummyArray = arr.ToList();
//            for(int i = 0; i < n; i++)
//            {
//                if(i==1 || i % 2 != 0)
//                {
//                    arr[i]=dummyArray.Min();
//                    dummyArray.Remove(arr[i]);
//                }
//                if(i==0 || i % 2 == 0)
//                {
//                    arr[i] = dummyArray.Max();

//                    dummyArray.Remove(arr[i]);
//                }

//            }
//            //code here
//        }


//    }
//}
using System;

class main
{

    // Prints max at first position, min at second
    // position, second max at third position, second
    // min at fourth position and so on.
    public static void rearrange(int[] arr, int n)
    {
        // initialize index of first minimum
        // and first maximum element
        int max_idx = n - 1, min_idx = 0;

        // store maximum element of array
        int max_elem = arr[n - 1] + 1;

        // traverse array elements
        for (int i = 0; i < n; i++)
        {

            // at even index : we have to put
            // maximum element
            if (i % 2 == 0)
            {
                arr[i] += (arr[max_idx] % max_elem) * max_elem;
                max_idx--;
            }

            // at odd index : we have to
            // put minimum element
            else
            {
                arr[i] += (arr[min_idx] % max_elem) * max_elem;
                min_idx++;
            }
        }

        // array elements back to it's original form
        for (int i = 0; i < n; i++)
            arr[i] = arr[i] / max_elem;
    }

    // Driver code
    public static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110 };
        int n = arr.Length;
        Console.WriteLine("Original Array");
        for (int i = 0; i < n; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();

        rearrange(arr, n);

        Console.WriteLine("Modified Array");
        for (int i = 0; i < n; i++)
            Console.Write(arr[i] + " ");
    }
}

