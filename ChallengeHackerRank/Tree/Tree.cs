using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank.Tree
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }


        public Node(int data)
        {
            Data = data;
        }
    }
    
    public class BinaryTree 
    {
        public Node root { get; set; }
        public Node node { get; set; }

        public BinaryTree(int data, Node node = null) 
        {
            if(node != null)
                root = node;
            else if(data > 0)
            {
                node = new Node(data);
                root = node;
            } else
            {
                root = null;
            }
        }

        public void PostOrderTraversal(Node node = null)
        {
            if (node == null)
                node = root;

            if(node.Left != null)
                PostOrderTraversal(node.Left);

            if (node.Right!= null)
                PostOrderTraversal(node.Right);

            Console.WriteLine(node.Data);
        }

        public void InorderTraversal(Node node = null)
        {
            if (node == null)
                node = root;

            if(node.Left != null)
                InorderTraversal(node.Left);

            Console.Write($"{node.Data} ");

            if (node.Right != null)
                InorderTraversal(node.Right);



        }

        public int Height(Node node = null)
        {
            if(node == null)
                node=root;

            int hleft = 0;
            int hright = 0;

            if(node.Left != null)
                hleft = Height(node.Left);

            if (node.Right != null)
                hleft = Height(node.Right);

            if (hright > hleft)
                return hright + 1;

            return hleft + 1;
        }
    }

    public class BinarySearchTree : BinaryTree
    {
        public BinarySearchTree(int data=0, Node node=null) 
            : base(data, node)
        {
        }

        public void Insert(int data)
        {
            Node parent = null;
            var aux = base.root;

            while(aux != null)
            {
                parent = aux;
                if (data < aux.Data)
                    aux = aux.Left;
                else 
                    aux = aux.Right;
            }

            if(parent == null)
                base.root = new Node(data);
            else if (data < parent.Data)
                parent.Left = new Node(data);
            else 
                parent.Right = new Node(data);
        }

        public BinarySearchTree Search(int data)
        {
            return _Search(data, base.root);
        }

        public BinarySearchTree _Search(int data, Node node)
        {
            if (node == null)
                return null;
                
            if(node.Data == data)
                return new BinarySearchTree(0, node);

            if (data < node.Data)
                return _Search(data, node.Left);
            else
                return _Search(data, node.Right);
        }

        //public BinarySearchTree Search( int data, Node node=null)
        //{
        //    if(node == null)
        //        node = base.root;

        //    if (node.Left == null || node.Data == data)
        //        return new BinarySearchTree(0, node);

        //    if(data < node.Data)
        //        return Search(data, node.Left);
        //    else 
        //        return Search(data, node.Right);
        //}
    }

    public static class Tree
    {
        
        public static void Initial(string [] args)
        {

            //var values = Enumerable.Range(1, 10).Select(x => x * x).ToList();
            var randon = new Random(77);
            var bst = new BinarySearchTree();
            var list = new List<int>();
            for(int i = 1; i < 42; i++)
            {
                var value = randon.Next(0, 50);
                list.Add(value);
            }
            list = list.Distinct().ToList();
            
            foreach(var item in list)
            {
                bst.Insert(item);
            }

            bst.InorderTraversal();

            var items = new int[] { 11, 19, 31, 45, 49 };
            Console.WriteLine($"");
            Console.WriteLine($"------------------------------------------------------------------");

            foreach (var item in items)
            {
                var r = bst.Search(item);

                if(r == null)
                {
                    Console.WriteLine($"{item} não encontrado");
                } else
                    Console.WriteLine($"{r.root.Data} encontrado");

            }

            //BinaryTree tree = new BinaryTree(7);
            //tree.root.Left = new Node(18);
            //tree.root.Right = new Node(14);

            //Console.WriteLine(tree.root.Data);
            //Console.WriteLine(tree.root.Left.Data);
            //Console.WriteLine(tree.root.Right.Data);
        }

    }
}
