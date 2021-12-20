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
            int result = 0;



            return result;
        }

        public static void Main(string[] args)
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
