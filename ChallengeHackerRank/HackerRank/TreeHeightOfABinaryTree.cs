using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class TreeHeightOfABinaryTree
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

        public static int quantity = 0;
        public static int Height(Node root)
        {

            int leftHeight = 0;
            int rightHeight = 0;

            if (root.left != null)
            {
                leftHeight = 1 + Height(root.left);
            }

            if (root.right != null)
            {
                rightHeight = 1 + Height(root.right);
            }

            return leftHeight > rightHeight ? leftHeight : rightHeight;
        }

        public static Node Insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            } else
            {
                Node cur;
                if(data <= root.data)
                {
                    cur = Insert(root.left, data);
                    root.left = cur;
                } else
                {
                    cur = Insert(root.right, data);
                    root.right = cur;
                }

                return root;
            }
        }

        public static void Initial(string [] args)
        {
            /*
             input
7
3 
2 
5 
1 
4 
6 
7

            output

3


             */

            var t = Convert.ToInt32(Console.ReadLine());

            Node root = null;

            while(t-- > 0)
            {
                var data = Convert.ToInt32(Console.ReadLine());
                root = Insert(root, data);
            }

            int height = Height(root);
            Console.WriteLine(height);
        }
    }
}
