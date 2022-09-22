using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBinarySearchTree
{
    public class BinarySearchTreeAlgorithm
    {
        public class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Data { get; set; }
        }
        public static Node Insert(Node root,int value)
        {
            if (root == null)
            {
                root = new Node();
                root.Data = value;
            }
            else
            {
                if (value < root.Data)
                {
                    root.Left = Insert(root.Left, value);
                }
                else if (value > root.Data)
                {
                    root.Right = Insert(root.Right, value);
                }
            }
            return root;

        }
        public static void Main()
        {
            Node rootNode = new Node();
            rootNode.Data = 4;
            BinarySearchTreeAlgorithm.Insert(rootNode, 10);
            BinarySearchTreeAlgorithm.Insert(rootNode, 20);
            BinarySearchTreeAlgorithm.Insert(rootNode, 30);




        }
    }
}
