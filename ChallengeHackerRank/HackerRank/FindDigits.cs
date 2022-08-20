using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class FindDigits
    {
        /*
     * Complete the 'findDigits' function below.
     *
     *https://www.hackerrank.com/challenges/find-digits/problem?isFullScreen=true&h_r=next-challenge&h_v=zen
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

        public static int findDigits(int n)
        {
            int result = 0;

            var digits = n.ToString().ToCharArray();

            for(int i = 0; i < digits.Length; i++)
            {
                var digit = Convert.ToInt64(digits[i].ToString());
                if ((digit > 0) && (n % digit == 0))
                {
                    result++;
                }
            }

            return result;
        }


        public static void Initial(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int result = findDigits(n);

                Console.WriteLine(result);
            }

        }
    }
}
