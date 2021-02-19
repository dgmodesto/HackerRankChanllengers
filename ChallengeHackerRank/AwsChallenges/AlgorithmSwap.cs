using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AwsChallenges
{
    public class AlgorithmSwap
    {

        public static void Initial(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = new List<int>();

            for (int i = 0; i < arrCount; i++)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
                arr.Add(arrItem);
            }

            long result = HowManySwaps(arr);

            Console.WriteLine(result);

        }
        /*
3
7
1
2
         */
        static int swaps = 0;
        private static long HowManySwaps(List<int> arr)
        {
            QuickSort(arr, 0, arr.Count - 1);
            return swaps;
        }

        public static void QuickSort(List<int> arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                QuickSort(arr, left, pivot - 1);
                QuickSort(arr, pivot + 1, right);
            }
        }

        private static int Partition(List<int> arr, int left, int right)
        {
            int pivot = arr[right];

            int i = (left - 1); // Index of smaller than the pivot
            for(int j = left;j < right -1; j++)
            {
                // if current element is smaller than the pivot
                if(arr[j] < pivot)
                {
                    i++; // increment index of smaller element
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, right);
            return i + 1;
        }

        private static void Swap(List<int> arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            swaps++;
        }
    }
}
