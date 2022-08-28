using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class ThreeNumbarSum
    {
        /*
INPUT
"array": [12, 3, 1, 2, -6, 5, -8, 6],
"targetSum": 0

OUTPUT
[
  [-8, 2, 6],
  [-8, 3, 5],
  [-6, 1, 5]
]
         */

        public static List<int[]> ThreeNumberSum1(int[] array, int targetSum)
        {
            // Write your code here.
            // Complexity O(n^3) | Space O(n)

            // current + next + nextofnext = 0
            var result = new List<int[]>();
            Array.Sort(array);
            for (int i = 0; i < array.Length - 2; i++)
            {
                int current = array[i];

                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    int next = array[j];

                    for (int k = j + 1; k < array.Length; k++)
                    {
                        int nextOfNext = array[k];

                        if (current + next + nextOfNext == targetSum)
                        {
                            result.Add(new int[] { current, next, nextOfNext });
                        }
                    }
                }
            }
            Console.WriteLine(result.Count);
            return result;
        }

        public static List<int[]> ThreeNumberSum2(int[] array, int targetSum)
        {
            // Write your code here.
            // complexity O(n^2) | space O(1)
            var result = new List<int[]>();
            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                int left = i + 1;
                int right = array.Length - 1;
                int current = array[i];

                while (left < right)
                {
                    int potencialTarget = current + array[left] + array[right];
                    if (potencialTarget == targetSum)
                    {
                        result.Add(new int[] { current, array[left], array[right] });
                        left++;
                        right--;
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
            }
            return result;
        }


        public static void Initial(string [] args)
        {
            List<int[]> output = ThreeNumberSum1(new int [] { 12, 3, 1, 2, -6, 5, -8, 6 }, 0);
            output.ForEach(x => Array.ForEach(x, Console.WriteLine));
        }
    }
}
