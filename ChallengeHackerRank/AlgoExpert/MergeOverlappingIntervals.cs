using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
     public static class MergeOverlappingIntervals
    {
        public static int[][] MergeOverlappingIntervals1(int[][] intervals)
        {
            // Write your code here.
            var output = new List<int[]>();
            Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

            int i = 1;
            var prev = intervals[0];
            output.Add(prev);
            while (i < intervals.Length)
            {
                var current = intervals[i];

                if (prev[1] >= current[0])
                {
                    prev[1] = Math.Max(current[1], prev[1]);
                }
                else
                {
                    prev = current;
                    output.Add(prev);
                }
                i++;
            }
            return output.ToArray();
        }

        public static void Initial(string[] args)
        {
            var input = new int[][] {
                new int[] {1, 2},
                new int[] {3, 5},
                new int[] {4, 7},
                new int[] {6, 8},
                new int[] {9, 10 }};

            var output = MergeOverlappingIntervals1(input);

            Console.WriteLine(@"Expected: [ [1, 2], [3, 8],[9, 10] ]");

            Console.Write(@"Expected:  ");


            Array.ForEach(output, item =>
            {
                Console.Write("[ ");
                Array.ForEach(item, i =>
                {
                    Console.Write(i);

                    Console.Write(", ");

                });
                Console.Write("] , ");

            });
        }
    }
}
