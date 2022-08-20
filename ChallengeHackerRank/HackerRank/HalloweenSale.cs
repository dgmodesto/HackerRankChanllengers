using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class HalloweenSale
    {

        /*
         * https://www.hackerrank.com/challenges/halloween-sale/problem?isFullScreen=true
   * Complete the 'howManyGames' function below.
   *
   * The function is expected to return an INTEGER.
   * The function accepts following parameters:
   *  1. INTEGER p
   *  2. INTEGER d
   *  3. INTEGER m
   *  4. INTEGER s
   *  
INPUT 
20 3 6 85
        
OUTPUT
7
   */

        public static int howManyGamesOptmized(int p, int d, int m, int s)
        {
            var res = 0;

            while (s >= p)
            {
                res++;
                s -= p;
                p = Math.Max(p - d, m);
            }

            return res;
        }

        public static int howManyGames(int p, int d, int m, int s)
        {
            // Return the number of games you can buy
            int count = 0;
            int paid = 0;
            while ((s - paid) >= p)
            {
                paid += p;
                count++;

                if (p > m && p-d > m)
                    p -= d;
                else
                    p = m;
            }

            return count;
        }



        public static void Initial(string [] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int p = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            int m = Convert.ToInt32(firstMultipleInput[2]);

            int s = Convert.ToInt32(firstMultipleInput[3]);

            int answer = howManyGames(p, d, m, s);

            Console.WriteLine(answer);
        }
    }
}
