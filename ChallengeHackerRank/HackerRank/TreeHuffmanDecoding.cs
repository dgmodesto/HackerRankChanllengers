using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    abstract class Node
    {
        public int frequency; // the frequency of this tree
        public char data;
        public Node left, right;
        public Node(int freq)
        {
            frequency = freq;
        }

        // compares on the frequency
        public int compareTo(Node tree)
        {
            return frequency - tree.frequency;
        }
    }

    class HuffmanLeaf : Node
    {
        public HuffmanLeaf(int freq, char val) :
            base(freq)
        {
            data = val;
        }
    }

    class HuffmanNode : Node
    {
        public HuffmanNode(Node l, Node r) :
            base(l.frequency + r.frequency)
        {
            left = l;
            right = r;
        }

    }


    public class TreeHuffmanDecoding
    {

        private List<Node> nodes = new List<Node>();
        public static Dictionary<char, string> mapA = new Dictionary<char, string>();

        //input is an array of frequencies, indexed by character code
        static Node BuildTree(int[] charFreqs)
        {
            Queue<Node> trees = new Queue<Node>();
            //Initially, we have a forest of leaves
            // one for each non-empty character
            for (int i = 0; i < charFreqs.Length; i++)
            {
                if (charFreqs[i] > 0)
                    trees.Enqueue(new HuffmanLeaf(charFreqs[i], (char)i));
            }

            while (trees.Count > 1)
            {
                //two trees with least frequency
                Node a = trees.Dequeue();
                Node b = trees.Dequeue();

                //put into new node and re-insert into queue
                trees.Enqueue(new HuffmanNode(a, b));
            }

            return trees.Dequeue();
        }

        static void printCodes(Node tree, StringBuilder prefix)
        {
            if (tree.GetType() == typeof(HuffmanLeaf))
            {
                HuffmanLeaf leaf = (HuffmanLeaf)tree;

                //print out character, frequency, and code fot this leaf (which is just the prefix)
                mapA.Add(leaf.data, prefix.ToString());
            }
            else if (tree.GetType() == typeof(HuffmanNode))
            {
                HuffmanNode node = (HuffmanNode)tree;

                //tranverse left
                prefix.Append('0');
                printCodes(node.left, prefix);
                prefix.Remove(prefix.Length - 1, 1);

                //transver right
                prefix.Append('1');
                printCodes(node.right, prefix);
                prefix.Remove(prefix.Length - 1, 1);
            }
        }

        static void Decode(string s, Node root)
        {

            StringBuilder sb = new StringBuilder();
            Node current = root;

            for (int i = 0; i < s.Length; i++)
            {
                current = s[i] == '1' ? current.right : current.left;
                if (current.left == null && current.right == null)
                {
                    sb.Append(current.data);
                    current = root;
                }
            }
            Console.WriteLine(sb);
        }

        public static void Initial(string[] args)
        {
            /*
             input
             ABACA

             output
             ABACA
             
             */



            string test = Console.ReadLine();

            // we will assume that all our characters will have
            // code less than 256, for simplicity
            int[] charFreqs = new int[256];

            //read each character and record the frequencies
            foreach (char c in test.ToCharArray())
                charFreqs[c]++;

            //build tree
            Node tree = BuildTree(charFreqs);

            //print out results
            printCodes(tree, new StringBuilder());
            StringBuilder s = new StringBuilder();

            for (int i = 0; i < test.Length; i++)
            {
                char c = test[i];
                s.Append(mapA.GetValueOrDefault(c));
            }

            //Print
            Decode(s.ToString(), tree);
        }


    }
}
