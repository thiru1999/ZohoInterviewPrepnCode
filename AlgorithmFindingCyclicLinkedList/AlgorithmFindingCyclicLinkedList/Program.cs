using System;
using System.Collections.Generic;
using System.Collections;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmFindingCyclicLinkedList
{
    class CustomLinkedList
    {
        Node head;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public Boolean hasCycle()
        {
            HashSet<Node> StoringNode = new HashSet<Node>();
  
            Node current = head;
            while (current!=null)
            {
                if (StoringNode.Contains(current)==true)
                {
                    return true;

                }
                else
                {
                    StoringNode.Add(current);
                    current = current.next;
                }


            }


            return false ;
        }

        static void Main(string[] args)
        {
            CustomLinkedList noCycleLinkedList = new CustomLinkedList();
            Node firstNode = new Node(3);
            Node secondNode = new Node(4);
            Node thirdNode = new Node(5);
            Node fourthNode = new Node(6);
            Node fifthNode = new Node(7);

            noCycleLinkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fifthNode;

            Console.WriteLine(noCycleLinkedList.hasCycle());

            CustomLinkedList cycleLinkedList = new CustomLinkedList();
            cycleLinkedList.head = firstNode;
            thirdNode.next = secondNode;

            Console.WriteLine(cycleLinkedList.hasCycle());
        }
    }
}