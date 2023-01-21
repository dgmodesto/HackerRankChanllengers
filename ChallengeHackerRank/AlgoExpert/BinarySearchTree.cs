﻿using System;
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

                if(this == null) return new BST(value);

                if(value < this.value)
                {
                    if (this.left != null)
                        this.left = this.left.Insert(value);
                    else
                        this.left = new BST(value);
                } else
                {
                    if(this.right != null) 
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
                    if(this.left == null) return false;
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

                if(value < this.value)
                {
                    if (this.left != null)
                        this.left = this.left.Remove(value);
                } else if(value > this.value)
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
                if( tree.value < minValue || tree.value >= maxValue) return false;

                var leftResult = ValidateBstHelper(tree.left, minValue, tree.value);
                var rightResult = ValidateBstHelper(tree.right, tree.value, maxValue);

                return leftResult && rightResult;
            }

            private BST FindInOderSucessor(BST node)
            {
                var current = node;

                while(current.left != null)
                {
                    current = current.left;
                }

                return current;
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
