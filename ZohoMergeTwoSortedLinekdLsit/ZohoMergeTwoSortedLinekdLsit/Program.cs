using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoMergeTwoSortedLinekdLsit
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
                this.next = null;
            }
        }
        static void Main(string[] args)
        {
            Node head1 = new Node(5);
            Node head2 = new Node(2);
            Node tail = head1;
            tail.next = new Node(10);
            tail = tail.next;
            tail.next = new Node(15);
            tail = tail.next;
            tail.next = new Node(40);
            Node tail2 = head2;
            tail2.next = new Node(3);
            tail2 = tail2.next;
            tail2.next = new Node(11);

            Node current = sortedMerge( head1, head2);
            while (current != null)
            {
                Console.WriteLine(current.data);
               current = current.next;
            }





        }
        public static Node sortedMerge(Node head1, Node head2)
        {

            Node tempList = new Node(0);
            Node temp = tempList;

            while (head1 != null && head2 != null)
            {
                if (head1.data < head2.data)
                {
                    temp.next = head1;
                    temp = temp.next;
                    head1 = head1.next;
                }
                else
                {
                    temp.next = head2;
                    temp = temp.next;
                    head2 = head2.next;
                }
            }

            temp.next = head1 != null ? head1 : head2;
            return tempList.next;

        }
    }

}
