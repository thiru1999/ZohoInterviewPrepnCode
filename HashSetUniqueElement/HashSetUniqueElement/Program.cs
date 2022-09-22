using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetUniqueElement //using hashset because its like a membership problem and order is not important
{  
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> opList = Unique(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8, 1, 2 });
            foreach(int i in opList)
            {
                Console.WriteLine(i) ;
            }
        }
        public static List<int> Unique(int[] arr1, int[] arr2)
        {
            List<int> uniqueelementList = new List<int>();
            HashSet<int> secondArray = new HashSet<int>();
            foreach(int i in arr2)
            {
                secondArray.Add(i);

            }
            foreach(int i in arr1)
            {
                if (!secondArray.Contains(i))  //searching in constant Time thatswhy its best for Membership problem
                {
                    uniqueelementList.Add(i);
                }
                
            }
            return uniqueelementList;

        }
    }
}
