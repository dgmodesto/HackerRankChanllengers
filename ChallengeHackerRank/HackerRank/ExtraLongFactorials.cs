using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ChallengeHackerRank
{
    public static class ExtraLongFactorials
    {
        /*
     * Complete the 'extraLongFactorials' function below.
     * 
     * https://www.hackerrank.com/challenges/extra-long-factorials/problem?isFullScreen=true&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
     *
     * The function accepts INTEGER n as parameter.
     */

        public static BigInteger calculateFactorial(int n)
        {
            if (n == 1)
                return 1;

            var result = n * calculateFactorial(n - 1);
            return result;
        }

        public static void extraLongFactorials(int n)
        {
            var result = calculateFactorial(n);

            Console.WriteLine(result);
        }


        public static void Initial(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            extraLongFactorials(n);
        }
    }
}
