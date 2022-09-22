

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    internal class Program
    {
        public static int[] LeftRotate(int[] arr)
        {
            int temp = arr[0];
            for(int i = 0; i < (arr.Length); i++)
            {
                if (i == (arr.Length)-1)
                {
                    arr[i] = temp;
                    continue;
                }
                arr[i] = arr[i + 1];
            }
            return arr;
            
        }
        public static int[] RightRotate(int[] arr)
        {
            int temp = arr[(arr.Length) - 1];
            for (int i = (arr.Length)-1; i >0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = temp;
            return arr;

        }
        static void Main(string[] args)
        {
            //int[] arr1 = LeftRotate(new int[]  { 1,2,3,4,5,6});
            int[] arr2 = RightRotate(new int[] { 1, 2, 3, 4, 5, 6 });
            //Array.ForEach(arr1, Console.WriteLine);
            Array.ForEach(arr2, Console.WriteLine);


        }
    }
}
