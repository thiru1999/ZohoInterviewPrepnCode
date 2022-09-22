using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoFindDuplicatesInArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = duplicates(new int[] { 2, 3, 1, 2, 3 },5);
            Array.ForEach(arr1, Console.Write);
            //arr1.ForEach(Console.WriteLine);

            
 
        }


        public static int[] duplicates(int[] arr, int n)
        {
            Dictionary<int, int> StoringCount = new Dictionary<int, int>();
            HashSet<int> storingOutput = new HashSet<int>();


            List<int> op = new List<int>();

            Array.Sort(arr);
            foreach (int i in arr)
            {

                if (StoringCount.ContainsKey(i))
                {
                    storingOutput.Add(i);

                }
                else
                {
                    StoringCount[i] = 1;
                }
            }
            if (storingOutput.Count == 0)
            {
                storingOutput.Add(-1);
                return storingOutput.ToArray();
            }

            return storingOutput.ToArray();
            //Your code here
        }
    }
}
