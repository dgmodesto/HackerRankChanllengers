using System;

namespace ChallengeHackerRank.DataStructure
{
    /*
    PREORDER: explores roots before leaves
    POSTORDER: explores leaves before roots
    INORDER: explores data sequentially
    */
  public class TreeSample
    {
        class Node {
            public Node Left {get; set;}
            public Node Right {get; set;}
            public int Data {get; set;}
        }


        class BinarySearchTree {
            public static Node Insert(Node root, int value) {
                if(root == null ) {
                    root = new Node();
                    root.Data = value;
                    return root;
                } else {
                    if (value < root.Data) {
                        //insert in the left 
                        root.Left = Insert(root.Left, value);
                    } else if (value > root.Data) 
                    {
                        //insert int the right
                        root.Right = Insert(root.Right, value);
                    }
                }

                return root;
            }

            public static bool Contains(Node root, int value) {
                if (root == null) return false;

                Node current = root;

                if(root.Data == value)
                    return true;
                else if (value < root.Data)
                    return Contains(root.Left, value);
                else 
                    return Contains(root.Right, value);
            }

            public static void PreOrderTraversal(Node root) {
                if (root == null) return;

                Console.Write(root.Data + " ");
                PreOrderTraversal(root.Left);
                PreOrderTraversal(root.Right);
            }

            public static void InOrderTraversal(Node root) {
                if (root == null) return;

                InOrderTraversal(root.Left);
                Console.Write(root.Data + " ");
                InOrderTraversal(root.Right);

            }

            public static void PostOrderTraversal(Node root) {
                if (root == null) return;

                InOrderTraversal(root.Left);
                InOrderTraversal(root.Right);
                Console.Write(root.Data + " ");

            }

        }

        public static void Initial(string [] args){
            Node rootNode = new Node();
            rootNode.Data =  4;
            BinarySearchTree.Insert(rootNode, 2);
            BinarySearchTree.Insert(rootNode, 3);
            BinarySearchTree.Insert(rootNode, 5);
            BinarySearchTree.Insert(rootNode, 6);
            BinarySearchTree.Insert(rootNode, 4);

            Console.WriteLine(BinarySearchTree.Contains(rootNode, 4));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 7));

        //     Node nodeOne = new Node();
        //     nodeOne.Data = 1;
            
        //     Node nodeThree = new Node();
        //     nodeThree.Data = 3;

            
        //     Node nodeEight = new Node();
        //     nodeEight.Data = 8;

            
        //     Node nodeNine = new Node();
        //     nodeNine.Data = 9;


        //     Node nodeSix = new Node();
        //     nodeSix.Data = 6;

           
        //    nodeOne.Left = nodeEight;
        //    nodeOne.Right = nodeNine;
        //    nodeThree.Left = nodeSix;
        //    rootNode.Left = nodeOne;
        //    rootNode.Right = nodeThree;

        //     BinarySearchTree.PreOrderTraversal(rootNode);
        //     Console.WriteLine();
        //     BinarySearchTree.InOrderTraversal(rootNode);
        //     Console.WriteLine();
        //     BinarySearchTree.PostOrderTraversal(rootNode);
        }
    }
}