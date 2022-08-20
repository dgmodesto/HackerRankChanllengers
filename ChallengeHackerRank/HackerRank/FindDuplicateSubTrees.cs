using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class FindDuplicateSubTrees
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }


        private static string ShowHelloWorld(int number)
        {
            if (number == 0) 
                return "Hello World";
            Console.WriteLine($" {ShowHelloWorld(number-1)} - { number }");
            return "Hello World";
        }

        public static void Initial(string[] args)
        {
            int number = 50;
            ShowHelloWorld(50);


        }
    }
}
