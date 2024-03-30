using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHackerRank.LeetCode
{
    public static class ThreeSum
    {

        public static IList<IList<int>> ThreeSumNumbers(int[] nums)
        {
            var result = new List<IList<int>>();
            int size = nums.Length;
            Array.Sort(nums);

            for (int i = 0; i < size - 2; i++)
            {
                for (int j = i + 1; j < size - 1; j++)
                {
                    for (int k = j + 1; k < size; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            var value = new int[] { nums[i], nums[j], nums[k] };
                            var valueList = value.ToList();
                            if (!result.Any(list => Enumerable.SequenceEqual(list, valueList)))
                            {
                                result.Add(valueList);
                                break;
                            }
                        }
                    }
                }
            }
            return result;
        }

        public static void Initial(string[] args)
        {
            int[] input = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> output = new List<IList<int>>();
            output.Add(new List<int>() { -1, -1, 2 } );
            output.Add(new List<int>() { -1, 0, 1 } );

            var result = ThreeSumNumbers(input);

            Console.WriteLine("Expected : {0} ", output);
            Console.WriteLine("Result :{0} ", result);
        }
    }
}
