using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop
{
    internal class Program                
    {
        public void break_check()             //break checking method
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    break;
                }
                Console.WriteLine(i);

            }
        }
        public void Continue_check()     //continue loop checking method
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);

            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.Continue_check();
            p1.break_check();
            
        }
    }
}
