using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class GreedyFlorist
    {
        /*
         * https://www.hackerrank.com/challenges/greedy-florist/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=greedy-algorithms
CASE 1  
INPUT
3 3
2 5 6

OUTPUT
13

CASE 2
INPUT
5 3
1 3 5 7 9

OUTPUT
29

CASE 
INPUT
4 3
1 2 3 4

OUTPUT
29
         */


        static int getMinimumCost(int k, int[] c)
        {

            int n = c.Length;
            int minCost = 0;
            int tempCount = 0;
            int previousPurchases = 0;

            Array.Sort(c);

            if (k >= n)
            {
                for (int i = 0; i < n; i++)
                    minCost += c[i];
            }
            else
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    if (tempCount == k)
                    {
                        tempCount = 0;
                        previousPurchases++;
                    }
                    minCost += (previousPurchases + 1) * c[i];
                    tempCount++;
                }
            }

            return minCost;
        }

        public static void Initial(string[] args)
        {

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int minimumCost = getMinimumCost(k, c);

            Console.WriteLine(minimumCost);

        }
    }
}
