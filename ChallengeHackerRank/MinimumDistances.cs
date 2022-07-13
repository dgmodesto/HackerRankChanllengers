using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public class MinimumDistances
    {
        /*
         * https://www.hackerrank.com/challenges/minimum-distances/problem?isFullScreen=true
         * 
    * Complete the 'minimumDistances' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts INTEGER_ARRAY a as parameter.
    * 
Input (stdin)
6
7 1 3 4 1 7

Expected Output
3
    */

        public static int minimumDistances(List<int> a)
        {
            int minDist = int.MaxValue;

            for (int i = 0; i < a.Count() - 1; i++)
            {
                var currentValue = a[i];
                for (int j = i + 1; j < a.Count(); j++)
                {
                    if (a[i] == a[j])
                    {
                        int dist = Math.Abs(i - j);
                        if (dist < minDist)
                        {
                            minDist = dist;
                        }
                    }
                }
            }

            return minDist == int.MaxValue ? -1 : minDist;
        }


        public static void Initial(string [] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = minimumDistances(a);

            Console.WriteLine(result);
        }

    }
}
