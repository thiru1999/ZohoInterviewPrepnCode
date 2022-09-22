using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> l1 = new List<string>();
            l1.Add("thiru");
            l1.Add("TMK");
            l1.Add("MANI");
            l1.Add("KUMAR");
            l1.Sort();
            foreach(string s in l1)
            {
                Console.WriteLine(s);
            }
           

        }
    }
}
