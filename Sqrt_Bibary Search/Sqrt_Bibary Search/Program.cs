using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search_Algorithm
{
    public static class Program
    {
        static long mySqrt(int x)
        {
            long start = 0, end = x, ans = -1;

            while (start <= end)
            {
                long mid = start + (end - start) / 2;

                if (mid * mid == x)
                {
                    return mid;
                }
                else if (mid * mid < x)
                {
                    ans = mid;
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return ans;
        }
        static void Main(string[] args)
        {

            long x = 8;
            float ans = mySqrt(x);
            Console.WriteLine(ans);

        }
    }
}
  /*  return ans;
            float increment = 0.01f;
            float k = ans;
            while(k*k != x)
            {
                if(k * k < x)
                {
                    k += increment;

                }
                if (k * k > x)
                {
                    k -= increment;

                }

            }
            return k;
         */


