using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class MinimumAbsoluteDifference
    {

        /*
         https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=greedy-algorithms


        INPUT
        10
-59 -36 -13 1 -53 -92 -2 -96 -54 75

        OUTPUT
        1

         */

        public static int minimumAbsoluteDifference(List<int> arr)
        {
            var minValue = int.MaxValue;

            for (int i = 0; i < arr.Count - 1; i++)
            {
                for (int j = i + 1; j < arr.Count; j++)
                {
                    var value = Math.Abs(arr[i] - arr[j]);
                    if (value < minValue)
                        minValue = value;
                }
            }

            return minValue;
        }

        public static int minimumAbsoluteDifferenceOptimized(List<int> arr)
        {
            var minValue = int.MaxValue;
            arr.Sort();
            for (int i = 0; i < arr.Count - 1; i++)
            {
                var value = Math.Abs(arr[i] - arr[i + 1]);
                if (value < minValue)
                    minValue = value;
            }

            return minValue;
        }


        public static void Initial(string [] args)
        {
            var arr = new int[] { -59,  36, 13, 1, 53, 92, 2, 96, 54, 75 };

            Console.WriteLine(minimumAbsoluteDifferenceOptimized(arr.ToList()));
        }
    }
}
