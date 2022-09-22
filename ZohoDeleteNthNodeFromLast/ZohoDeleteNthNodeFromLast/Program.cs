using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoDeleteNthNodeFromLast
{
    public class Program
    {
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
        public static int getNthFromLast(Node head, int k)
        {
            Node current = head;
            int count = 0;
            while (current != null)
            {
                count += 1;
                current = current.next;
            }
            Node opCurrent = head;

            for (int i = 1; i <= ((count - k) + 1); i++)
            {
                
                if (i == ((count - k) + 1))
                {
                    return opCurrent.data;
                }
                opCurrent = opCurrent.next;

            }
            return 0;
            //Your code here
        }
        static void Main(string[] args)
        {
            Node head = new Node(2);
            Node first = new Node(2);
            Node second = new Node(2);
            Node third = new Node(5);
            head.next = first;
            first.next = second;
            second.next = third;

            int k = Program.getNthFromLast(head, 2);
            Console.WriteLine(k);


        }
    }
}
