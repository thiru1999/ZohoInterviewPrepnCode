using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoLargestNoWithGivenSum
{
    class Solution
    {
        //Complete this function
        public static string largestNumber(int n, int sum)
        {
            int max = 9;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                if (sum == 0)
                {
                    sb.Append(0);
                }
                if (max <=sum)
                {
                    sum = sum - max;
                    sb.Append(max);


                }
                else if (sum < max && sum!=0)
                {
                    sb.Append(sum);
                    sum = 0;
                }
                
            }
            return sb.ToString();
            //Your code here
        }
        public static void Main()
        {
            string k = largestNumber(2, 9);
            Console.WriteLine(k) ;
        }

    }
}
