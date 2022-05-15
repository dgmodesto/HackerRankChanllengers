using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static  class GreedyAlgorithms
    {
        /*
         * https://www.hackerrank.com/challenges/luck-balance/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=greedy-algorithms&h_r=next-challenge&h_v=zen
         * 
         * 
         * Complete the 'luckBalance' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. 2D_INTEGER_ARRAY contests
         *  
INPUT
6 3
5 1
2 1
1 1
8 1
10 0
5 0

OUTPUT
29
        */

        public static int luckBalance(int k, List<List<int>> contests)
        {
            int totalLuckBalance = 0;
            int impContestCount = 0;
            List<int> tempList = new List<int>();

            for (int i = 0; i < contests.Count; i++)
            {
                if (contests[i][1] == 1)
                {
                    impContestCount++;
                    tempList.Add(contests[i][0]);
                }
                totalLuckBalance += contests[i][0];
            }

            if (impContestCount > k)
            {
                tempList.Sort();
                int n = impContestCount - k;
                for (int j = 0; j < n; j++)
                {
                    totalLuckBalance -= 2 * tempList[j];
                }
            }

            return totalLuckBalance;
        }

        public static void Initial(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> contests = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                contests.Add(Console.ReadLine()
                            .TrimEnd()
                            .Split(' ')
                            .ToList()
                            .Select(contestsTemp => Convert.ToInt32(contestsTemp))
                            .ToList());
            }

            int result = luckBalance(k, contests);

            Console.WriteLine(result);

        }
    }
}
