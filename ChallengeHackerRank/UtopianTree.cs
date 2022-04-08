using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class UtopianTree
    {
        /*
            * Complete the 'utopianTree' function below.
            * 
            * The function is expected to return an INTEGER.
            * The function accepts INTEGER n as parameter.
            * 
            * https://www.hackerrank.com/challenges/utopian-tree/problem?isFullScreen=true
  */

        public static int utopianTree(int n)
        {
            int subtract = 1 + (n % 2);
            int exponent = ((n + (n % 2)) / 2) + 1;
            return (int)Math.Pow(2, exponent) - subtract;
        }

        public static void Initial(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int result = utopianTree(n);

                Console.WriteLine(result);
            }

        }
    }
}
