using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class BynarySearch
    {

        public static int BinarySearch1(int[] array, int target)
        {
            // Complexity O(log n) | Space O(1).
            int result = Array.BinarySearch(array, target);
            return result < 0 ? -1 : Array.BinarySearch(array, target);
        }

        public static int BinarySearch2(int[] array, int target)
        {
            // Complexity O(log n) | Space O(1).
            int min = 0;
            int max = array.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (array[mid] == target)
                {
                    return mid;
                }
                else if (target > array[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            return -1;
        }

        public static int BinarySearch(int[] array, int target)
        {
            // Complexity O(log n) | Space O(1).
            return BinarySearchAux(array, 0, array.Length - 1, target);
        }

        private static int BinarySearchAux(int[] array, int start, int end, int target)
        {

            int mid = (start + end) / 2;

            if (start > end) return -1;
            else
            {
                if (target == array[mid])
                {
                    return mid;
                }
                else if (target > array[mid])
                {
                    return BinarySearchAux(array, mid + 1, end, target);
                }
                else if (target < array[mid])
                {
                    return BinarySearchAux(array, 0, mid - 1, target);
                }
            }

            return -1;
        }

        public static void Initial(string [] args)
        {
            int [] array = new int[] { 1, 5, 23, 111 };
            int target = 111;
            int result = BinarySearch1(array, target);


            Console.WriteLine("Expected: 3");
            Console.WriteLine($"Actual: { result }");

        }
    }
}
