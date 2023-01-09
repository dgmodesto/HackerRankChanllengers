using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static  class ZeroSumSubarray
    {
        public static bool ZeroSumSubarray1(int[] nums)
        {
            // Complexity O(N) | Space O(N)

            var sums = new HashSet<int>();

            int currSum = 0;
            foreach (var num in nums)
            {
                currSum += num;
                if (sums.Contains(currSum) || currSum == 0)
                {
                    return true;
                }
                else
                {
                    sums.Add(currSum);
                }
            }

            return false;
        }

        public static void Initial(string[] args)
        {
            var input = new int[]{ -5, -5, 3, 2, -2 };

            var output = ZeroSumSubarray1(input);

            Console.WriteLine(@"Expected: True");

            Console.WriteLine($"Expected: {output} ");

        }
    }
}
