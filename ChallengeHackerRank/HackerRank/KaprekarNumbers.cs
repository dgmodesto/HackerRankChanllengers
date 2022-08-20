using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class KaprekarNumbers
    {
        /*
     * Complete the 'kaprekarNumbers' function below.
     *
     *https://www.hackerrank.com/challenges/kaprekar-numbers/problem?isFullScreen=true
     *
     * The function accepts following parameters:
     *  1. INTEGER p
     *  2. INTEGER q
     */

        public static void kaprekarNumbers(long p, long q)
        {
            bool found = false;
            for (long i = p; i <= q; i++)
            {
                String sqr = (i * i).ToString();

                int d = sqr.Length - i.ToString().Length;

                long r = 0, l = 0;

                if (d >= 0)
                    r = Convert.ToInt32(sqr.Substring(d));
                if (d > 0)
                    l = Convert.ToInt32(sqr.Substring(0, d));

                if ((r + l) == i)
                {
                    found = true;
                    Console.Write(i + " ");
                }
            }

            if (!found)
                Console.Write("INVALID RANGE");
        }


        public static void Initial(string[] args)
        {
            int p = Convert.ToInt32(Console.ReadLine().Trim());

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            kaprekarNumbers(p, q);
        }
    }
}
