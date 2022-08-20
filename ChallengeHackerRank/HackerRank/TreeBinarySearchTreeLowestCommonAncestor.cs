using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class TreeBinarySearchTreeLowestCommonAncestor
    {
        /*
         A solução se baseia no seguinte fato, que o menor ancestral entre dois valores
         nunca será maior que os dois valores que este buscando
         por exemplo:
         arvore: 8 4 9 1 2 3 6 5
         busca: 2 5
         resultado: 4
         o Resultado nunca será maior que os dois valores informados na busca.
         
         */
        public class Node
        {
            public Node left;
            public Node right;
            public int data;

            public Node(int data)
            {
                this.data = data;
                left = null;
                right = null;
            }
        }
        static int slowest = 0;
        static Node Lca(Node root, int v1, int v2)
        {
            Node current;

            //smaller than both
            if (root.data < v1 && root.data < v2)
            {
               return Lca(root.right, v1, v2);
            } 
            
            //Bigger than both
            if (root.data > v1 && root.data > v2)
            {
                return Lca(root.left, v1, v2);
            }

            // else solution already found
            return root;
        }

        static Node Insert(Node root, int data)
        {
            if(root == null)
            {
                return new Node(data);
            }
            else
            {
                Node curr;
                if( data <= root.data)
                {
                    curr = Insert(root.left, data);
                    root.left = curr;
                } else
                {
                    curr = Insert(root.right, data);
                    root.right= curr;
                }

                return root;
            }
        }


        public static void Initial(string [] args)
        {
            /*
             input
6
4 2 3 1 7 6
1 7
 output
            
4
            ****
8
8 4 9 1 2 3 6 5
2 5 
             
             
             */
            int t = Convert.ToInt32(Console.ReadLine());

            List<int> arr = Console.ReadLine()
                .TrimEnd()
                .Split(' ').Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            var values = Console.ReadLine().Split(' ');
            int v1 = Convert.ToInt32(values[0]);
            int v2 = Convert.ToInt32(values[1]);
            Node root = null;

            arr.ForEach(data=>
            {
                root = Insert(root, data);
            });

            Node ans = Lca(root, v1, v2);

            Console.WriteLine(ans.data);
        }
    }
}
