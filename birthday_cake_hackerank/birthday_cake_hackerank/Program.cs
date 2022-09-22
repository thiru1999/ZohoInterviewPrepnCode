using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birthday_cake_hackerank
{
    internal class Program
    {
        public static int method(int[] arr1)
        {
            int max = arr1.Max();
            int Count = 0;
            foreach (int i in arr1)
            {
                if (i == max)
                {
                    ++Count;
                }
                

            }
            return Count;

        }
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string[] s=Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(s[i]);
            }
            int k=Program.method(arr);
            Console.WriteLine(k);




        }
    }
}
