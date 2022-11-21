using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class MinimumWaitingTime
    {
        private static int MinimumWaitingTimeMethod(int[] queries)
        {
            // Write your code here.
            Array.Sort(queries);

            int amount = 0;
            int prevTime = 0;

            for (int i = 0; i < queries.Length; i++)
            {
                amount += prevTime;
                prevTime += queries[i];
            }
            /*
            prev, amount = 0
                     1  2  2  3  6
            amot   0 0  1  4  9  17
            prev   0 1  3  5  8  14
            */
            return amount;
        }

        public static void Initial(string [] args)
        {
            int[] input = new int[] { 3, 2, 1, 2, 6 };
            Console.WriteLine(MinimumWaitingTimeMethod(input));
        }
    }
}
