using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class JumpingCloudRevisited
    {

        // Complete the jumpingOnClouds function below.
        // https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited/problem?isFullScreen=true
        /*
8 2
0 0 1 0 0 1 1 0
         */

        static int jumpingOnClouds(int[] c, int k)
        {
            int e = 100;
            int i = 0;
            var idx = (i + k) % c.Length;
            while (idx != 0)
            {
                if (c[idx] == 1)
                {
                    e -= 2;
                }

                e--;
                i += k;
                
                if (i >= c.Length) i = i - c.Length;
                idx = (i + k) % c.Length;
            }

            if (c[idx] == 1)
            {
                e -= 2;
            }

            e--;

            return e;

        }


        public static void Initial(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = jumpingOnClouds(c, k);

            Console.WriteLine(result);

        }

    }
}
