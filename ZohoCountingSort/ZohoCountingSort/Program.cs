using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoCountingSort
{
    class Solution
    {
        //Function to arrange all letters of a string in lexicographical 
        //order using Counting Sort.
        public static string countSort(string arr)
        {
            int[] count = new int[26];
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = (int)arr[i] - 97;
                count[temp] += 1;

            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 26; i++)
            {
                while (count[i] > 0)
                {
                    int temp = i + 97;

                    sb.Append((char)temp);
                    count[i]--;
                }
            }
            return sb.ToString();
            //code here
        }
        public static void Main()
        {
            Console.WriteLine( countSort("dssfasd"));

        }

    }

}
