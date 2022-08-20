using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class ChocolateFeast
    {

        /*
 * Complete the 'chocolateFeast' function below.
 *
 *https://www.hackerrank.com/challenges/chocolate-feast/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign
 *
 * The function is expected to return an INTEGER.
 * The function accepts following parameters:
 *  1. INTEGER n
 *  2. INTEGER c
 *  3. INTEGER m
 */

        public static int chocolateFeast(int n, int c, int m)
        {

            var qty = n / c;
            int result = qty;

            while(qty >= m)
            {
                result++;
                qty = (qty - m)+1;
            }
            return result;
        }

        public static void Initial(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int c = Convert.ToInt32(firstMultipleInput[1]);

                int m = Convert.ToInt32(firstMultipleInput[2]);

                int result = chocolateFeast(n, c, m);

                Console.WriteLine(result);
            }

        }
    }
}
