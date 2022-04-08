using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class AVeryBigSum
    {

        /*
  * Complete the 'aVeryBigSum' function below.
  *
  * The function is expected to return a LONG_INTEGER.
  * The function accepts LONG_INTEGER_ARRAY ar as parameter.
  * 
  * https://www.hackerrank.com/challenges/a-very-big-sum/problem?isFullScreen=true
  */

        public static long aVeryBigSum(List<long> ar)
        {
            long result = 0;


            result = ar.Sum();

            return result;
        }


        public static void Initial(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console
                .ReadLine()
                .TrimEnd()
                .Split(' ')
                .ToList()
                .Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = aVeryBigSum(ar);

            Console.WriteLine(result);

        }
    }
}
