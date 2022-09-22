using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratingThroughStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            Queue<String> myqueue = new Queue<string>();

            // Inserting the elements into the Stack
            myStack.Push("Geeks");
            myStack.Push("Geeks Classes");
            myStack.Push("Noida");
            myStack.Push("Data Structures");
            myStack.Push("GeeksforGeeks");

            // To get an Enumerator
            // for the Stack
            IEnumerator<string> enumerator =
             myStack.GetEnumerator();
            IEnumerator<string> enumerator1 = myqueue.GetEnumerator(); // for queue

            // If MoveNext passes the end of the
            // collection, the enumerator is positioned
            // after the last element in the Stack
            // and MoveNext returns false.
            while (enumerator.MoveNext())
            {

                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
