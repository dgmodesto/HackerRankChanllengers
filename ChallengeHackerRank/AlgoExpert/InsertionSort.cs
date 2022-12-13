using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class InsertionSort
    {
        public static int[] InsertionSort1(int[] array)
        {
            // Complexity O(N²) | Space O(1)

            if (array.Length == 0)
                return new int[] { };

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        var swap = array[j];
                        array[j] = array[i];
                        array[i] = swap;
                    }

                }
            }

            return array;
        }

        public static int[] InsertionSort2(int[] array)
        {
            // Complexity O(N²) | Space O(1)

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (array[j] > array[j + 1])
                    {
                        int swap = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = swap;
                    }
                }
            }

            return array;
        }


        public static void Initial(string[] args)
        {
            var input = new int[] { 2, 3, 5, 5, 6, 8, 9 };

            var result = InsertionSort1(input);

            Console.WriteLine("Expected: [2, 3, 5, 5, 6, 8, 9]");
            Console.Write($"Actual: ");
            Array.ForEach(result, Console.Write);

        }
    }
}
