using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class NonDivisbleSubSet
    {
        /*
    * Complete the 'nonDivisibleSubset' function below.
    *
    *https://www.hackerrank.com/challenges/non-divisible-subset/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
    *
4 3
1 7 2 4
    * The function is expected to return an INTEGER.
    * The function accepts following parameters:
    *  1. INTEGER k
    *  2. INTEGER_ARRAY s
    */

        public static int nonDivisibleSubset(int k, List<int> s)
        {
            int result = 0;

            var remainderArr = new int[s.Count];


            for (int i = 0; i < s.Count; i++)
                remainderArr[s[i] % k]++;

            int zeroRemainder = remainderArr[0];

            result = zeroRemainder > 0 ? 1 : 0;

            for (int i = 1; i <= (k / 2); i++)
            {
                if (i != k - i)
                    result += Math.Max(remainderArr[i], remainderArr[k - i]);
                else
                    result++;
            }

            return result;
        }

        public static void Initial(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            int result = nonDivisibleSubset(k, s);

            Console.WriteLine(result);

        }
    }
}
