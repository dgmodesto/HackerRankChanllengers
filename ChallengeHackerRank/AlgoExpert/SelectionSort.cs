using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class SelectionSort
    {

        public static int[] SelectionSort1(int[] array)
        {
            // Write your code here.

            int i = 0;
            int size = array.Length - 1;
            while (i <= size)
            {
                int j = i;
                while (j <= size)
                {
                    if (array[j] < array[i])
                    {
                        int swap = array[j];
                        array[j] = array[i];
                        array[i] = swap;
                    }
                    j++;
                }
                i++;
            }

            return array;
        }

        public static void Initial(string [] args)
        {
            var input = new int[] { 2, 3, 5, 5, 6, 8, 9 };

            var result = SelectionSort1(input);

            Console.WriteLine("Expected: [2, 3, 5, 5, 6, 8, 9]");
            Console.Write($"Actual: ");
            Array.ForEach(result, Console.Write);
        }

    }
}
