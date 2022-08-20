using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    /*
    - Binary Search Trees
    - A level-order trasversal, also known as a bredth-first search, visits each level of a tree's node from left to rigth, top to bottom.
    - You are given a pointer, root, pointing to the root of a binary search tree.
    - Complete the levelOrder fucntion privded in your editor so that it prints the level-order trversal of the binay serach tree.
    - Hint
        - You'll find a Queue helpful in completing this challenge.
    - INPUT
6
3
5
4
7
2
1
    - OUTPUT
3 2 5 1 4 7 
     */
    public class BSTLevelOrderTraversal
    {
        public class Node
        {
            public Node left, right;
            public int data;
            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        }

        static void levelOrder(Node root)
        {
            if (root == null)
                return;

            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                var node = q.Dequeue();
                Console.Write(node.data + " ");

                if (node.left != null)
                    q.Enqueue(node.left);

                if (node.right != null)
                    q.Enqueue(node.right);
            }

        }

        static Node insert(Node root, int data)
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
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        public static void Initial(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);

        }
    }
}
