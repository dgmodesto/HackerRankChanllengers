using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class TwoNumbarSum
    {
        public static int[] TwoNumberSum1(int[] array, int targetSum)
        {
            // Write your code here.
            // complexity O(n^2) | space O(1)

            int firstN = 0;
            int secondN = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == targetSum)
                    {
                        firstN = array[i];
                        secondN = array[j];
                        return new int[] { firstN, secondN };
                    }
                }
            }

            return new int[0];
        }

        public static int[] TwoNumberSum2(int[] array, int targetSum)
        {
            // Write your code here.
            // complexity O(n) | space O(n)

            var hash = new HashSet<int>();

            foreach (var i in array)
            {
                int potencialTarget = targetSum - i;
                if (hash.Contains(potencialTarget))
                    return new int[] { i, potencialTarget };
                else
                    hash.Add(i);

            }

            return new int[0];
        }

        public static int[] TwoNumberSum3(int[] array, int targetSum)
        {
            // Write your code here.
            // complexity O(n log(n)) | space O(1)

            int left = 0;
            int right = array.Length - 1;
            Array.Sort(array);
            while (left < right)
            {
                int potencialTarget = array[left] + array[right];
                if (potencialTarget == targetSum)
                {
                    return new int[] { array[left], array[right] };
                }
                else if (potencialTarget < targetSum)
                {
                    left++;
                }
                else if (potencialTarget > targetSum)
                {
                    right--;
                }
            }
            return new int[0];
        }


        public static void Initial(string [] args)
        {
            int[] output = TwoNumberSum1(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10);
            Array.ForEach(output, Console.WriteLine);
        }
    }
}
