using System;
using System.Collections.Generic;
using System.Text;
using System.Linq

namespace ChallengeHackerRank.AlgoExpert
{
    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }
    }
    public static class FindClosestValueInBst
    {
        public static long FindClosestValueInBst1(BST tree, long target)
        {
            // Write your code here.
            // Complexity O(n) | Space O(n)

            if (tree == null) return int.MaxValue;

            long leftValue = FindClosestValueInBst1(tree.left, target);
            long rightValue = FindClosestValueInBst1(tree.right, target);

            long leftClosest = Math.Abs(leftValue - target);
            long rightClosest = Math.Abs(rightValue - target);
            long currentClosest = Math.Abs(tree.value - target);

            if (leftClosest < rightClosest)
            {
                return currentClosest < leftClosest ? tree.value : leftValue;
            }
            else
            {
                return currentClosest < rightClosest ? tree.value : rightValue;
            }
        }

        public static float FindClosestValueInBst2(BST tree, int target)
        {
            // Write your code here.
            // Complextiy O(n) | Space(1)
            float closest = int.MaxValue;
            var currentNode = tree;
            while (currentNode != null)
            {
                if (Math.Abs(target - closest) > Math.Abs(target - currentNode.value))
                    closest = currentNode.value;

                if (target < currentNode.value)
                    currentNode = currentNode.left;
                else if (target > currentNode.value)
                    currentNode = currentNode.right;
                else
                    break;
            }
            return closest;
        }

        public static float FindClosestValueInBst3(BST tree, int target)
        {
            // Write your code here.
            // Complextiy O(n) | Space(n)
            return FindClosestValueInBstHelper(tree, target);
        }

        private static float FindClosestValueInBstHelper(BST tree, int target, float closest = int.MaxValue)
        {
            if (tree == null) return closest;
            if (Math.Abs(target - closest) > Math.Abs(target - tree.value))
                closest = tree.value;

            if (target < tree.value)
                return FindClosestValueInBstHelper(tree.left, target, closest);
            else if (target > tree.value)
                return FindClosestValueInBstHelper(tree.right, target, closest);
            else
                return closest;
        }

        public static void Initial(string [] args)
        {

        }
    }
}
