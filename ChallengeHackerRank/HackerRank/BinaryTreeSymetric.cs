using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class BinaryTreeSymetric
    {
        /*
         * Given a binary tree root, check if it's symmetric around its center (a mirror of itself)
         Example:
         Input:

                            (4)
                          /     \
                        (5)     (5)
                       /  \     /  \
                     (2)  (7)  (7) (2)


        Output: true
        
        T(n) = O(n)
        S(n) = O(logn)
         */

        public class Node
        {
            public Node(int value)
            {
                this.Data = value;
            }

            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }


        public static int TreeSum(Node root)
        {
            if (root == null) return 0;
            else
            {
                int left = TreeSum(root.Left);
                int right = TreeSum(root.Right);
                return root.Data + left + right;
            }
        }

        public static bool AreSymetric(Node root1, Node root2)
        {
            if (root1 == null || root2 == null) return true;
            else if (( (root1 == null) != (root2 == null)) || root1.Data != root2.Data) return false;
            else
            {
                return AreSymetric(root1.Left, root2.Right) 
                    && AreSymetric(root1.Right, root2.Left);
            }
        }

        public static bool IsSymetric(Node root)
        {
            if( root is null) return true;

            return AreSymetric(root.Left, root.Right);
        }

        public static void Initial(string [] args )
        {

            var root = new Node(4);
            var l1 = new Node(5);
            var l2 = new Node(2);
            var l3 = new Node(7);

            var r1 = new Node(5);
            var r2 = new Node(2);
            var r3 = new Node(7);


            l1.Right = l3;
            l1.Left = l2;

            r1.Right = r2;
            r1.Left = r3;

            root.Left = l1;
            root.Right = r1;

            Console.WriteLine("Is symetric tree : " +  IsSymetric(root));
            Console.WriteLine("Sum : " + TreeSum(root));
        }

    }
}
