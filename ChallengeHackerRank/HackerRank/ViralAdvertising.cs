using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class ViralAdvertising
    {
        /*
     * Complete the 'viralAdvertising' function below.
     *
     *https://www.hackerrank.com/challenges/strange-advertising/problem?isFullScreen=true&h_r=next-challenge&h_v=zen
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     * 2017789501
     * 2068789129

     */

        public static int viralAdvertising(int n)
        {
            int cum = 0;
            int people = 5;

            for (int i = 0; i < n; i++)
            {
                people = (int)Math.Floor((double)(people / 2));
                cum += people;
                people *= 3;
            }

            return cum;
        }

        public static void Initial(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = viralAdvertising(n);

            Console.WriteLine(result);
        }

    }
}
