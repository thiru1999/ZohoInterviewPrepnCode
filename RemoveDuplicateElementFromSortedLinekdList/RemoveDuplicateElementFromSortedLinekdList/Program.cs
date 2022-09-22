using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateElementFromSortedLinekdList
{
    public class Program
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                this.next = next = null;

            }
        }
        public static void Main(string[] args)
        {
            Node head = new Node(2);
            Node first = new Node(2);
            Node second = new Node(2);
            Node third = new Node(5);
            head.next = first;
            first.next = second;
            second.next = third;


            Node current = head;
            while (current.next != null)
            {
                if (current.data == current.next.data)
                {
                    Node dummyNode = current;
                    while(dummyNode.data == dummyNode.next.data)
                    {
                        dummyNode = dummyNode.next;

                    }
                    current.next = dummyNode.next;
                }
                else
                {
                    current = current.next;
                }
            
            }
            Node opcurrent = head;
            while (opcurrent != null)
            {
                Console.WriteLine(opcurrent.data);opcurrent = opcurrent.next;
            }
  



        }
    }
}
