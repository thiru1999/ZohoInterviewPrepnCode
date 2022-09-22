using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoMergeTwoDifferentSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 2, 4, 5, 6, 7, 9, 10, 13 };
            List<int> list2 = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 11, 15 };
            list1.ForEach(item => list2.Add(item));
            //list1.AddRange(list2);
            HashSet<int> UniqueElement = new HashSet<int>();
            UniqueElement = list2.ToHashSet();
            list2 = UniqueElement.ToList();
            list2.Sort();
            list2.ForEach(item => Console.Write(item+","));


        }
    }
}
