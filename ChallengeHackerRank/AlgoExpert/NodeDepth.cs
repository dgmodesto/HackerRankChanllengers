using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class NodeDepth
    {
        public static int NodeDepths1(BinaryTree root, int level = 0)
        {
            // Write your code here.
            // Complexity O(n) | Space O(h)
            int valLeft = 0;
            int valRight = 0;
            if (root.left != null)
                valLeft = NodeDepths1(root.left, level + 1);

            if (root.right != null)
                valRight = NodeDepths1(root.right, level + 1);

            return valLeft + valRight + level;
        }

        public static int NodeDepths2(BinaryTree root, int level = 0)
        {
            // Write your code here
            return root == null ? 
                0 : 
                (level + NodeDepths2(root.left, level + 1) + NodeDepths2(root.right, level + 1));
        }

        public class BinaryTree
        {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value)
            {
                this.value = value;
                left = null;
                right = null;
            }
        }

        public static void Initial(string [] args)
        {
            var root = new BinaryTree(1);
            root.left = new BinaryTree(2);
            root.left.left = new BinaryTree(4);
            root.left.left.left = new BinaryTree(8);
            root.left.left.right = new BinaryTree(9);
            root.left.right = new BinaryTree(5);
            root.right = new BinaryTree(3);
            root.right.left = new BinaryTree(6);
            root.right.right = new BinaryTree(7);

            int actual = NodeDepths2(root);
            int expected = 16;

            Console.Write("Expected: ");
            Console.WriteLine(expected);

            Console.Write("Actual: ");
            Console.WriteLine(actual);
        }

    }
}
