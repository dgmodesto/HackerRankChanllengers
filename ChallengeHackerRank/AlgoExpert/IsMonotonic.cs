using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class IsMonotonic
    {
        public static bool IsMonotonic1(int[] array)
        {
            // Write your code here.
            // Complexity O(n) | Space O(1)

            bool decreasing = false;
            bool increasing = false;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int curr = array[i];
                int next = array[i + 1];

                if (curr > next)
                {
                    increasing = true;
                }
                else if (curr < next)
                {
                    decreasing = true;
                }

                if (increasing && decreasing) return false;
            }

            return true;
        }

        public static bool IsMonotonic2(int[] array)
        {
            // Write your code here.
            // Complexity O(n) | Space O(1)

            bool c = true;
            bool d = true;

            for (int i = 0; i < array.Length - 1; i++)
            {
                c = c && array[i] <= array[i + 1];
                d = d && array[i] >= array[i + 1];
            }

            return c || d;
        }

        public static void Initial(string [] args)
        {
            var array = new int[] { -1, -5, -10, -1100, -1100, -1101, -1102, -9001 };
            var expected = true;
            var actual = IsMonotonic1(array);

            Console.WriteLine("Expected: ", expected);
            Console.WriteLine("Actual: ", actual);
        }
    }
}
