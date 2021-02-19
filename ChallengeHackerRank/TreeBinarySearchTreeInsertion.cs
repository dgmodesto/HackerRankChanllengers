using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public class TreeBinarySearchTreeInsertion
    {
        public class Node
        {
            public Node(int data)
            {
                this.data = data;
            }

            public Node left { get; set; }
            public Node right { get; set; }
            public int data { get; set; }
        }

        static Node Insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node current;
                if(data < root.data)
                {
                    current = Insert(root.left, data);
                    root.left = current;
                }
                else
                {
                    current = Insert(root.right, data);
                    root.right = current;
                }
                return root;
            }
        }

        public static void Initial(string [] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            Node root = null;

            var datas = Console.ReadLine().ToString().Split(' ');

            for (int i = 0; i < t; i++)
            {
                root = Insert(root, Convert.ToInt32(datas[i]));
            }
            Console.WriteLine("*************************************************** \n \n \n \n \n ");
        }
    }
}
