using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    /*
- The absolute difference between two integers a and b, is written as | a - b |. The maximum absolute difference between two integers in a set of positive integers, elements, is the largest absolute difference between any two integers in elements.
- The Difference class is started for you in the editor.
- It has a private integer array (elements) for storing N non-negative integers, and a public integer (maximumDifference) for storing the maximum absolute difference.
    */
    public class Scope
    {

        public static void Initial(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);
            d.ComputeDifference();

            Console.Write(d.MaximumDifference);
        }
    }

    internal class Difference
    {
        private int[] a;

        public Difference(int[] a)
        {
            this.a = a;
        }

        public int MaximumDifference { get; internal set; }

        public void ComputeDifference()
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    int diff = a[i] - a[j];
                    if (diff > MaximumDifference)
                    {
                        MaximumDifference = diff;
                    }
                }
            }
        }
    }
}
