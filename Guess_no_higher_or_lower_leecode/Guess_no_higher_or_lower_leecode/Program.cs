using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Guess_no_higher_or_lower_leetcode
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 2126753390;
            int k = GuessNumber(n);
            Console.WriteLine(k);
        }
        public static int GuessNumber(int n)
        {
            int start = 0;
            int end = n;
            int mid = 0;
            while (start <= end)
            {
                mid = (start + end) / 2;
             
                int l = guess(mid);
                if (l == 0)
                {
                    return mid;
                }
                else if (l == 1)
                {
                    
                    end = mid - 1;

                }
                else
                {
                    
                    start = mid + 1;
                }
            }
            return mid;
        }
        public static int guess(int mid)
        {
            int pick = 1702766719;
            if (pick == mid)
            {
                return 0;
            }
            else if (pick < mid)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
