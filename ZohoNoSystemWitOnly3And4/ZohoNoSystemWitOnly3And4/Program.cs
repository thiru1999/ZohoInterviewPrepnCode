using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoNoSystemWitOnly3And4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indexToFind = int.Parse(Console.ReadLine());
            List<string> ListWithOnly3And4 = new List<string>();
            string s1 = "3";
            string s2 = "4";
            ListWithOnly3And4.Add(s1);
            ListWithOnly3And4.Add(s2);
            for(int i = 0; i < 10; i=i+2)
            {
                ListWithOnly3And4.Add(ListWithOnly3And4[i] + s1);
                ListWithOnly3And4.Add(ListWithOnly3And4[i] + s2);

                ListWithOnly3And4.Add(ListWithOnly3And4[i+1] + s1);
                ListWithOnly3And4.Add(ListWithOnly3And4[i + 1] + s2);
            }
            foreach(string s in ListWithOnly3And4)
            {
                Console.Write(s+" ");
            }





        }
    }
}
