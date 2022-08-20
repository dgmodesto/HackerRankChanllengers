using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class KthLargestElement
    {
        /*
         * Given an array of integers arr and an integer k, 
         * find the kth largest element
         
        input: 
        4 2 9 7 5 6 7 1 3 
        k = 4

        output: 6

        1st largest element is 9;
        2nd largest element is 7
        3rd largest element is 7
        4th largest element is 6

        
         */




        public static void Initial(string [] args)
        {
            int[] arr = Console.ReadLine().Split(' ').ToList().Select(x => Convert.ToInt32(x)).ToArray();
            int k = Convert.ToInt32(Console.ReadLine());

            int result = FindPositionLargestElement(arr, k);

            Console.WriteLine(result);
        }

        private static int FindPositionLargestElement(int[] arr, int k)
        {
            for (int i = 1; i < k - 1; i++)
                arr = arr.Where(x => x != arr.Max()).ToArray();
            
            return arr.Max();
            
        }
    }
}
