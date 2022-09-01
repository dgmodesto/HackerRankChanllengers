using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class BranchSums
    {

        // This is the class of the input root. Do not edit it.
        public class BinaryTree
        {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value)
            {
                this.value = value;
                this.left = null;
                this.right = null;
            }
        }

        public static List<int> BranchSums1(BinaryTree root)
        {
            // Write your code here.
            // Complexity O(n) | Space O(n)

            var list = TraversalTree(root, 0, new List<int>());
            return list;
        }

        public static List<int> TraversalTree(BinaryTree root, int sum, List<int> sums)
        {

            if (root.left != null)
                sums = TraversalTree(root.left, sum + root.value, sums);


            if (root.right != null)
                sums = TraversalTree(root.right, sum + root.value, sums);

            
            if (root.left == null && root.right == null)
                sums.Add(sum + root.value);

            return sums;
        }

        public static void Initial(string [] args)
        {

        }
    }
}
