using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class SortedSquarArray
    {

        public static int[] SortedSquaredArray1(int[] array)
        {
            // Write your code here.
            //Complexity O(n) | Space O(1)
            return array.ToList().Select(i => i * i).OrderBy(i => i).ToArray();
        }


        public static int[] SortedSquaredArray2(int[] array)
        {
            // Write your code here.
            // Complexity O(n)  | Space O(1)
            for (int i = 0; i < array.Length; i++)
                array[i] = array[i] * array[i];

            Array.Sort(array);
            return array;
        }

        public static int[] SortedSquaredArray3(int[] array)
        {
            // Write your code here.
            // Complexity O(n log(n))  | Space O(1)
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                array[left] = array[left] * array[left];
                if (left == right) break;

                array[right] = array[right] * array[right];
                left++;
                right--;
            }

            Array.Sort(array);
            return array;
        }

        public static void Initial(string [] args )
        {
            var input = new int[] { 1, 2, 3, 5, 6, 8, 9 };
            var expected = new int[] { 1, 4, 9, 25, 36, 64, 81 };
            var actual =  SortedSquaredArray1(input);

            Console.Write("Expected: ");
            Array.ForEach(expected, Console.Write);
            Console.WriteLine();
            Console.Write("Actual: ");
            Array.ForEach(actual, Console.Write);
        }
    }
}
