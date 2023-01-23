using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class BinarySearchTree
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

            public BST Insert(int value)
            {

                if (this == null) return new BST(value);

                if (value < this.value)
                {
                    if (this.left != null)
                        this.left = this.left.Insert(value);
                    else
                        this.left = new BST(value);
                } else
                {
                    if (this.right != null)
                        this.right = this.right.Insert(value);
                    else
                        this.right = new BST(value);
                }

                return this;
            }

            public bool Contains(int value)
            {
                if (this == null) return false;

                if (value == this.value) return true;
                else if (value < this.value)
                {
                    if (this.left == null) return false;
                    else return this.left.Contains(value);
                } else
                {
                    if (this.right == null) return false;
                    else return this.right.Contains(value);
                }

            }

            public BST Remove(int value)
            {
                if (this == null) return this;

                if (value < this.value)
                {
                    if (this.left != null)
                        this.left = this.left.Remove(value);
                } else if (value > this.value)
                {
                    if (this.right != null)
                        this.right = this.right.Remove(value);
                } else
                {
                    if (this.left == null && this.right != null)
                        return null;
                    else if (this.left != null)
                    {
                        this.value = this.right.value;
                        this.right = this.right.right;
                        this.left = this.right.left;
                    } else if (this.right != null)
                    {
                        this.value = this.left.value;
                        this.right = this.left.right;
                        this.left = this.left.left;
                    } else
                    {
                        var sucessor = FindInOderSucessor(this.right);
                        this.value = sucessor.value;
                        this.right = this.right.Remove(sucessor.value);
                    }
                }


                return this;
            }

            public bool ValidateBst()
            {
                return ValidateBstHelper(this, int.MinValue, int.MaxValue);
            }



            private bool ValidateBstHelper(BST tree, int minValue, int maxValue)
            {
                if (tree == null) return true;
                if (tree.value < minValue || tree.value >= maxValue) return false;

                var leftResult = ValidateBstHelper(tree.left, minValue, tree.value);
                var rightResult = ValidateBstHelper(tree.right, tree.value, maxValue);

                return leftResult && rightResult;
            }

            private BST FindInOderSucessor(BST node)
            {
                var current = node;

                while (current.left != null)
                {
                    current = current.left;
                }

                return current;
            }
        }

        public static class BSTOrders {
            public static List<int> InOrderTraverseRecursive(BST tree, List<int> array)
            {
                // Complexity O(N) | Space O(N) where N is the number of nodes in the BST
                if (tree == null) return new List<int>();

                var listResult = new List<int>();

                var listLeft = InOrderTraverseRecursive(tree.left, array);
                var current = tree.value;
                var listRight = InOrderTraverseRecursive(tree.right, array);

                listResult.AddRange(listLeft);
                listResult.Add(current);
                listResult.AddRange(listRight);

                return listResult;
            }
            public static List<int> PostOrderTraverseRecursive(BST tree, List<int> array)
            {
                // Complexity O(N) | Space O(N) where N is the number of nodes in the BST
                if (tree == null) return new List<int>();

                var listResult = new List<int>();

                var listLeft = PostOrderTraverseRecursive(tree.left, array);
                var listRight = PostOrderTraverseRecursive(tree.right, array);
                var current = tree.value;

                listResult.AddRange(listLeft);
                listResult.AddRange(listRight);
                listResult.Add(current);

                return listResult;
            }
            public static List<int> PreOrderTraverseRecursive(BST tree, List<int> array)
            {
                // Complexity O(N) | Space O(N) where N is the number of nodes in the BST
                if (tree == null) return new List<int>();
                var listResult = new List<int>();

                var listLeft = PreOrderTraverseRecursive(tree.left, array);
                var listRight = PreOrderTraverseRecursive(tree.right, array);
                var current = tree.value;

                listResult.Add(current);
                listResult.AddRange(listLeft);
                listResult.AddRange(listRight);


                return listResult;
            }


            public static List<int> InOrderTraverseInterative(BST tree, List<int> array)
            {
                // Write your code here.

                var stack = new Stack<BST>();
                BST curr = null;
                if (tree != null)
                    curr = tree;

                while (stack.Count > 0 || curr != null)
                {
                    while (curr != null)
                    {
                        stack.Push(curr);
                        curr = curr.left;
                    }

                    curr = stack.Pop();
                    array.Add(curr.value);
                    curr = curr.right;
                }

                return array;
            }
            public static List<int> PreOrderTraverseInterative(BST tree, List<int> array)
            {
                // Write your code here.
                var stack = new Stack<BST>();
                if (tree != null)
                    stack.Push(tree);

                while (stack.Count > 0)
                {

                    var curr = stack.Pop();
                    array.Add(curr.value);
                    if (curr.right != null)
                        stack.Push(curr.right);
                    if (curr.left != null)
                        stack.Push(curr.left);
                }


                return array;
            }
            public static List<int> PostOrderTraverseInterative(BST tree, List<int> array)
            {
                // Write your code here.
                var stack = new Stack<BST>();
                if (tree != null)
                    stack.Push(tree);

                while (stack.Count > 0)
                {
                    var curr = stack.Pop();
                    array.Add(curr.value);
                    if (curr.left != null)
                    {
                        stack.Push(curr.left);
                    }
                    if (curr.right != null)
                    {
                        stack.Push(curr.right);
                    }
                }

                array.Reverse();
                return array;
            }
        }


        public static void Initial(string [] args)
        {
            var root = new BST(10);
            root.left = new BST(5);
            root.left.left = new BST(2);
            root.left.left.left = new BST(1);
            root.left.right = new BST(5);
            root.right = new BST(15);
            root.right.left = new BST(13);
            root.right.left.right = new BST(14);
            root.right.right = new BST(22);


            Console.WriteLine($"InOrderTraverse");
            Console.WriteLine($"Expected: 12551013141522");
            Console.Write($"Result  : ");
            Array.ForEach(BSTOrders.InOrderTraverseRecursive(root, new List<int>()).ToArray(), Console.Write);
            Console.WriteLine();
            Console.WriteLine($"-------------------------------------------");

            Console.WriteLine($"PostOrderTraverse");
            Console.WriteLine($"Expected: 12551413221510");
            Console.Write($"Result  : ");
            Array.ForEach(BSTOrders.PostOrderTraverseRecursive(root, new List<int>()).ToArray(), Console.Write);
            Console.WriteLine();
            Console.WriteLine($"-------------------------------------------");

            Console.WriteLine($"PreOrderTraverse");
            Console.WriteLine($"Expected: 10521515131422");
            Console.Write($"Result  : ");
            Array.ForEach(BSTOrders.PreOrderTraverseRecursive(root, new List<int>()).ToArray(), Console.Write);
            Console.WriteLine();
            Console.WriteLine($"-------------------------------------------");


            root.Insert(12);
            Console.WriteLine($"Expected: True");
            Console.WriteLine($"Result: { root.right.left.left.value == 12 }");
            Console.WriteLine($"-------------------------------------------");

            root.Remove(10);
            Console.WriteLine($"Expected: True");
            Console.WriteLine($"Result: { root.Contains(10) == false}");
            Console.WriteLine($"-------------------------------------------");

            Console.WriteLine($"Expected: False");
            Console.WriteLine($"Result: { root.value == 12}");
            Console.WriteLine($"-------------------------------------------");


            Console.WriteLine($"Expected: True");
            Console.WriteLine($"Result: { root.Contains(15)}");
            Console.WriteLine($"-------------------------------------------");

            Console.WriteLine($"Expected: True");
            Console.WriteLine($"Result: { root.ValidateBst()}");
            Console.WriteLine($"-------------------------------------------");




        }
    }
}
