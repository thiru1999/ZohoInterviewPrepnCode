using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace max_and_min_value_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s;
            int big_sum = 0;
            int j = 0;
            int small_sum = 0;
            s = Console.ReadLine().Split(' ');
            List<int> sort_list = new List<int>();
            for(int i = 0; i < s.Length; i++)
            {
                int k = int.Parse(s[i]);
                sort_list.Add(k);
            }
            sort_list.Sort();
            for(int i = 0; i < s.Length; i++)
            {
                if (i < 4)
                {
                    small_sum = small_sum + sort_list[i] ;
                }
                if (j >= 1)
                {
                    big_sum = big_sum + sort_list[i];
                }
                j++;


            }

            Console.WriteLine("{0} {1}",small_sum,big_sum);
            Console.WriteLine();
        }
    }
}

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_and_min_value_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s;
            double big_sum = 0;
            int j = 0;
            double small_sum = 0;
            s = Console.ReadLine().Split(' ');
            List<double> sort_list = new List<double>();
            for (int i = 0; i < s.Length; i++)
            {
                double k = double.Parse(s[i]);
                sort_list.Add(k);
            }
            sort_list.Sort();
            for (int i = 0; i < s.Length; i++)
            {
                if (i < 4)
                {
                    small_sum = small_sum + sort_list[i];
                }
                if (j >= 1)
                {
                    big_sum = big_sum + sort_list[i];
                }
                j++;


            }

            Console.WriteLine("{0} {1}", small_sum, big_sum);
            Console.WriteLine();
        }
    }
}

