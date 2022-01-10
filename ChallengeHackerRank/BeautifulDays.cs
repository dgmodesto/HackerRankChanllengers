using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class BeautifulDays
    {
        /*
     * Complete the 'beautifulDays' function below.
     *
     *https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem?isFullScreen=true
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER i
     *  2. INTEGER j
     *  3. INTEGER k
     */

        public static int beautifulDays(int i, int j, int k)
        {
            int bd = 0;
            for(int x = i; x <= j; x++)
            {
                var inverseValue = new String(x.ToString().Reverse().ToArray());
                
                //Those 3 lines below is 10x quicker than line above in a big enter.
                var newString = x.ToString().ToCharArray();
                Array.Reverse(newString);
                var inverseValueQuicly = new String(newString);

                var value = x - Convert.ToInt64(inverseValueQuicly);
                
                if(value % k == 0)
                {
                    bd++;
                }
            }
            return bd;
        }

        public static void Initial(string[] args)
        {
            //input: 20 23 6
            //output: 2

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int i = Convert.ToInt32(firstMultipleInput[0]);

            int j = Convert.ToInt32(firstMultipleInput[1]);

            int k = Convert.ToInt32(firstMultipleInput[2]);

            int result = beautifulDays(i, j, k);

            Console.WriteLine(result);
        }
    }
}
