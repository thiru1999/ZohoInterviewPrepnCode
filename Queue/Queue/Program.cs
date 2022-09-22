

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Queue<int> acess = new Queue<int>();
            acess.Enqueue(10);
            acess.Enqueue(20);
            acess.Enqueue(30);
            acess.Enqueue(40);
            acess.Enqueue(50);
            acess.Enqueue(60);
           foreach(var ele in acess)
            {
                Console.WriteLine(ele);
            }

        }
    }
}
