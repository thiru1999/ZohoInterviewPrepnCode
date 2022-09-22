
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteBackHalflinkedList
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
    public class CustomLinkedList
    {
        public Node head;
        public Node tail;




        public void AddFirst(int data)
        {

            Node Linked = new Node(data);
            
      
            Linked.next = head;
            head = Linked;


        }
        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
        public void DeleteBackHalf()
        {
            Node fast = head;
            Node slow = head;
            while (fast.next!=null)
            {
                slow = slow.next;
                fast = fast.next.next;

            }
            slow.next = null;
        }
        public void AddLast(int data)
        {
            if (head == null)
            {
                Node head = new Node(data);
                head.data = data;
                head.next = null;


            }
            else
            {
                Node Linked = new Node(data);
                Linked.data = data;
                Linked.next = null;
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;

                }
                current.next = Linked;

            }
        }
        public void DeleteKNode(int k)
        {
            Node current = head;
            int count=0;
            while (current.next != null)
            {
                current = current.next;
                count = count + 1;
            }
            current = head;
            for(int i = 1; i < ((count - k) + 1); i++)
            {
                current = current.next;
                
            }
            current.next = current.next.next;
        }
        
        internal class Program
        {
            static void Main(string[] args)
            {
                CustomLinkedList cll = new CustomLinkedList();
                cll.AddFirst(10);
                cll.AddFirst(20);
                cll.AddFirst(30);
                cll.AddLast(60);
                cll.AddFirst(40);
                cll.AddLast(50);
                cll.DeleteKNode(3);
                cll.printAllNodes();
                Console.WriteLine("\n");
                cll.DeleteBackHalf();
                cll.printAllNodes();


            }
        }
    }
}
