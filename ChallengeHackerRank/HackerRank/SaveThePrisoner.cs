using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class SaveThePrisoner
    {

        /*
     * Complete the 'saveThePrisoner' function below.     *
     *
     *https://www.hackerrank.com/challenges/save-the-prisoner/problem?isFullScreen=true
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER m
     *  3. INTEGER s
     */

        public static int saveThePrisoner(int n, int m, int s)
        {
            /*Input: 
          
1
4 6 2
            */
            //n = 4; m = 6; s = 2;
            //Output: 3

            // ( ( (6 - 1) + (2 - 1) % 4 ) + 1 )
            // ( ( 5 + 1 ) % 4 )+ 1
            // (6 % 4) + 1
            // 2 + 1
            // 3
            var result =  ((m - 1) + (s - 1)) % n + 1;

            return result;

        }


        public static void Initial(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int m = Convert.ToInt32(firstMultipleInput[1]);

                int s = Convert.ToInt32(firstMultipleInput[2]);

                int result = saveThePrisoner(n, m, s);

                Console.WriteLine(result);
            }

        }

    }
}
