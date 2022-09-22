using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryFreqOfEachElementInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Frequency(new int[] { 1, 2, 4, 2, 1, 3, 1, 2, 3, 4, 5, 1, 2, 3 });


        }
        public static void Frequency(int[] arr)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach(int i in arr)
            {
                if (freq.ContainsKey(i))
                {
                    freq[i]++;

                }
                else
                {
                    freq[i] = 1;
                }
            }
            foreach(KeyValuePair<int,int> x in freq)
            {
                Console.WriteLine(x.Key+"->"+x.Value);
            }
            
        }
    }
}
