

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumberUsingQueue
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int n = 10;
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");
            for (int i=0; i < n; i++){
                string current = queue.Dequeue();
                if (i == n-1)  // to get the binary of the Particular Number 
                {
                    Console.WriteLine(current);
                }
                queue.Enqueue(current + "0");
                queue.Enqueue(current + "1");

            }


        }
    }
}
