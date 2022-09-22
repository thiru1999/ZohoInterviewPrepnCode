using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Diagnostics;

namespace string_stringbuilder
{
   
    public class Program
    {
        
        static void Main(string[] args)
        {
            string s1 = "";
            StringBuilder sb1 = new StringBuilder();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            
            for (int i = 0; i < 100000; i++)
            {
                s1=s1+i;

            }
            sw.Stop();
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (int i = 0; i < 100000; i++)
            {
                sb1.Append(i);

            }
            sw1.Stop();

            Console.WriteLine(sw1.ElapsedMilliseconds);
            Console.WriteLine(sw.ElapsedMilliseconds);


        }
    }
}
