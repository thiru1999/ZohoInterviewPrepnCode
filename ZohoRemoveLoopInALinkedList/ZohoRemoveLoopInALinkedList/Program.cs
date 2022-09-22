using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoRemoveLoopInALinkedList
{

//    Given a linked list of N nodes such that it may contain a loop.

//A loop here means that the last node of the link list is connected to the node at position X(1-based index). If the link list does not have any loop, X=0.

//Remove the loop from the linked list, if it is present, i.e.unlink the last node which is forming the loop.

//    nput:
//N = 3
//value[] = {1,3,4}
//X = 2
//Output: 1
//Explanation: The link list looks like
//1 -> 3 -> 4
//     ^    |
//     |____|    
//A loop is present. If you remove it 
//successfully, the answer will be 1. 
    internal class Program
    {
        public void removeLoop(Node head)
        {
            HashSet<Node> storingNode = new HashSet<Node>();
            Node current = head;
            while (current != null)
            {
                if (storingNode.Contains(current.next))
                {
                    current.next = null;

                }
                else
                {
                    storingNode.Add(current);
                    current = current.next;

                }
            }
            //Your code here
        }
        static void Main(string[] args)
        {
        }
    }
}
