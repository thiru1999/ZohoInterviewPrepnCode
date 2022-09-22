using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoIntersectionPointinYShapedLinkedLsit
{
    internal class Program
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
        static void Main(string[] args)
        {
            Node head = new Node(2);
            Node first = new Node(2);
            Node second = new Node(2);
            Node third = new Node(5);
            head.next = first;
            first.next = second;
            second.next = third;
        }
        public int intersectPoint(Node head1, Node head2)
        {
            Node current1 = head1;
            Node current2 = head2;
            int count1 = 0;
            int count2 = 0;
            while (current1 != null)
            {
                count1 += 1;
                current1 = current1.next;

            }
            while (current2 != null)
            {
                count2 += 1;
                current2 = current2.next;

            }
            int min = Solution.Min(count1, count2);
            if (min == count1)
            {
                Node opCurrent1 = head1;
                for (int i = 1; i <= count1 + 1; i++)
                {
                    opCurrent1 = opCurrent1.next;
                }
                return opCurrent1.next.data;
            }
            else
            {
                Node opCurrent2 = head2;
                for (int i = 1; i <= count2 + 1; i++)
                {
                    opCurrent2 = opCurrent2.next;
                }
                return opCurrent2.next.data;
            }
            return -1;



            //Your code here
        }
        public static int Min(int a, int b)
        {
            if (a <= b)
            {
                return a;
            }
            return b;
        }
    }
}
