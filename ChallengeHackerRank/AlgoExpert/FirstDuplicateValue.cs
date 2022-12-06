using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class FirstDuplicateValue
    {
        public static int FirstDuplicateValue1(int[] array)
        {
            // Complexity O(N) | Space O(N)
            var hs = new HashSet<int>();
            int i = 0;
            int size = array.Length;
            while (i < size)
            {

                if (hs.Contains(array[i]))
                    return array[i];
                else
                    hs.Add(array[i]);
                i++;
            }
            return -1;
        }

        public static int FirstDuplicateValue2(int[] array)
        {
            // Complexity O(N) | Space O(M) - where M = 10000
            int i = 0;
            int size = array.Length;
            int[] cache = new int[10000];

            while (i < size)
            {
                if (cache[array[i]] != 0)
                {
                    return cache[array[i]];
                }
                else
                {
                    cache[array[i]] = array[i];
                }
                i++;
            }

            return -1;
        }

        public static int FirstDuplicateValue3(int[] array, HashSet<int> hs = null, int i = 0)
        {
            // Complixity O(N) | Space O(N)
            if (hs == null)
                hs = new HashSet<int>();

            if (i == array.Length) return -1;

            if (hs.Contains(array[i]))
                return array[i];

            hs.Add(array[i]);
            return FirstDuplicateValue3(array, hs, i + 1);
        }

        public static void Initial(string [] args)
        {
            int[] array = new int[] { 2, 1, 5, 2, 3, 3, 4 };

            int result = FirstDuplicateValue2(array);

            Console.WriteLine("Expected: 2");
            Console.WriteLine($"Actual: { result }");

        }
    }
}
