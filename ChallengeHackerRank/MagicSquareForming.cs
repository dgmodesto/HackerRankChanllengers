using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class MagicSquareForming
    {

        /*
         https://www.hackerrank.com/challenges/magic-square-forming/problem?isFullScreen=true&h_r=next-challenge&h_v=zen
         */


        public static int formingMagicSquare(List<List<int>> s)
        {
            int[][] allMagics = new int[][]
            {
                new int[] { 8, 1, 6, 3, 5, 7, 4, 9, 2},
                new int[] { 6, 1, 8, 7, 5, 3, 2, 9, 4},
                new int[] { 4, 9, 2, 3, 5, 7, 8, 1, 6},
                new int[] { 2, 9, 4, 7, 5, 3, 6, 1, 8},
                new int[] { 8, 3, 4, 1, 5, 9, 6, 7, 2},
                new int[] { 4, 3, 8, 9, 5, 1, 2, 7, 6},
                new int[] { 6, 7, 2, 1, 5, 9, 8, 3, 4},
                new int[] { 2, 7, 6, 9, 5, 1, 4, 3, 8}
            };

            List<int> square = new List<int>();

            for (int s_i = 0; s_i < 3; s_i++)
            {
                foreach (int a in s[s_i])
                    square.Add(Convert.ToInt32(a));
            }

            var sums = from ar in allMagics
                       select ar.Zip(square, (a, b) => Math.Abs(a - b)).Sum();

            return (sums.Min());
        }

        public static void Initial(string[] args)
        {
            List<List<int>> s = new List<List<int>>();

            for (int i = 0; i < 3; i++)
            {
                s.Add(
                    Console.ReadLine()
                    .TrimEnd()
                    .Split(' ')
                    .ToList()
                    .Select(sTemp => Convert.ToInt32(sTemp))
                    .ToList());
            }

            int result = formingMagicSquare(s);

            Console.WriteLine(result);
        }
    }
}
