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

        private static int MinimumWaitingTimeMethod2(int[] queries)
        {
            /*
               Array.Lenght = al = 5
               index = idx = 0
              val  al   idx  formula
               1    5    0   ((5 - 1 - 0) * 1) + 00 = 4
               2    5    1   ((5 - 1 - 1) * 2) + 04 = 10
               2    5    2   ((5 - 1 - 2) * 2) + 10 = 14
               3    5    3   ((5 - 1 - 3) * 3) + 14 = 17
               6    5    4   - don't execute the last line   
            */

            Array.Sort(queries);
            int amount = 0;

            for (int i = 0; i <= queries.Length - 1; i++)
            {
                amount += (queries.Length - 1 - i) * queries[i];
            }
            return amount;
        }

        public static void Initial(string [] args)
        {
            int[] input = new int[] { 3, 2, 1, 2, 6 };
            Console.WriteLine($"Expected: 7");
            Console.WriteLine($"Result: { MinimumWaitingTimeMethod(input) }");
        }
    }
}
