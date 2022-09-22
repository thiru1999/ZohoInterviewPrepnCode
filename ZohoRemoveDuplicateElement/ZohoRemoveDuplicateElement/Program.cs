using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoRemoveDuplicateElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = remove_duplicate(new int[] { 2, 2, 2, 2, 2 }, 5);
            Console.WriteLine(op);
        }
        public static int remove_duplicate(int[] a, int n)
        {
            int count = 1;
            for(int i = 1; i < n; i++)
            {
                if (a[i] != a[i - 1])
                {
                    count++;
                }

            }
            return count;
            // code here

        }
    }
}
