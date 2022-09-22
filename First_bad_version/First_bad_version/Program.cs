using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_bad_version
{


    public class Solution
    {

        static void Main(string[] args)
        {
            Solution s = new Solution();
            int n = int.Parse(Console.ReadLine());
            int k = s.FirstBadVersion(n);
            Console.WriteLine(k);



        }


        public int FirstBadVersion(int n)
        {
            int start = 0;
            int end = n;
            int mid;
            while (start <= end)
            {
                mid = start + (end - start) / 2;
                if (VersionControl.isBadVersion(mid) && !VersionControl.isBadVersion(mid - 1))
                {
                    return mid;

                }
                if (VersionControl.isBadVersion(mid))
                {
                    end = mid - 1;

                }
                else
                {
                    start = mid + 1;
                }
            }
            return 1;
        }
    }



    public static  class VersionControl
    {
        public static bool isBadVersion(int version)
        {
            int to_check_version = 5;
            if (to_check_version == version)
            {
                return true;
            }
            return false;

        }
    }
}
