using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   Zoho3SumTriplets
{
    internal class Program
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);
            List<KeyValuePair<int, int>> map = new List<KeyValuePair<int, int>>();
            HashSet<string> opStore = new HashSet<string>();
            for(int i = 0; i < nums.Length; i++)
            {
                map.Add(new KeyValuePair<int, int> (nums[i], i ));
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    int currentSum = nums[i] + nums[j];
                    int k = -1 * currentSum;
                    var x = map.Where((l) => l.Key == k).ToList();
                    
                    
                    if (x.Count>0)
                    {
                        foreach (var m in x)
                        {
                            if (!opStore.Contains(nums[i] + ":" + nums[j] + ":" + k) && m.Value > i && m.Value > j)
                            {
                                opStore.Add(nums[i] + ":" + nums[j] + ":" + k);
                                List<int> dummy = new List<int>();
                                dummy.Add(nums[i]);
                                dummy.Add((nums[j]));
                                dummy.Add(k);
                                result.Add(dummy);
                            }

                        }
                        
                    }
                }
            }
            return result;
        }   
        static void Main(string[] args)
        {
            Console.WriteLine(ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }));
        }
    }
}
