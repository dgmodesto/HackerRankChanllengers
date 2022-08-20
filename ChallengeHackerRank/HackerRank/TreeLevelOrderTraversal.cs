using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class TreeLevelOrderTraversal
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

        public static void levelOrder(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while(q.Count > 0)
            {
                Node temp = q.Dequeue();
                Console.Write(temp.data + " ");

                if (temp.left != null) q.Enqueue(temp.left);
                if (temp.right != null) q.Enqueue(temp.right);
            }

        }
        
        public static Node Insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = Insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = Insert(root.right, data);
                    root.right = cur;
                }

                return root;
            }
        }

        public static void Initial(string[] args)
        {
            /*
             input
6
1 2 5 3 6 4
            output

1 2 5 3 6 4


             */

            var t = Convert.ToInt32(Console.ReadLine());

            Node root = null;

            var datas = Console.ReadLine().ToString().Split(' ');

            for(int i=0; i < t; i++)
            {
                root = Insert(root, Convert.ToInt32(datas[i]));
            }
            Console.WriteLine("*************************************************** \n \n \n \n \n ");
            levelOrder(root);
        }
    }
}
