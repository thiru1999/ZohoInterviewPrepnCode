using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratingThroughLinkedList
{
    public class GFG
    {
        public static void main(String[] args)
        {

            // Creating a LinkedList of Integer type
            LinkedList<int> linkedList = new LinkedList<int>();

            // Inserting some Integer values to our LinkedList
            linkedList.AddFirst(40);

            linkedList.AddFirst(80);
            linkedList.AddFirst(120);

            // LinkedList after insertions: [40, 44, 80, 9]

            // Calling the function to iterate our LinkedList
            iterateUsingForLoop(linkedList);
        }

        // Function to iterate the LinkedList using a simple for
        // loop
        public static void
                 iterateUsingForLoop(LinkedList<int> linkedList)
        {


            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(linkedList.get(i) + " ");
            }
        }
    }
}
