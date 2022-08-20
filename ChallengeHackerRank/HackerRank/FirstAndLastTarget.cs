using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class FirstAndLastTarget
    {
        /*
         * Given a sorted array of integers arr and an integer target,
         * find the idex of the first and last position of target in arr.
         *  In target cant'be found in arr, retun [-1, -1]
         * 
CASE 1
Input 
1 2 3 5 5 5 5 6 7 8
5

Output
first position: 3 - last position: 6

CASE 2
Input 
1 2 3 5 5 5 5 6 7 8
9

Output
first position: -1 - last position: -1


         */

        private static int[] FindFirstAndLast(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    int start = i;
                    while (i + 1 < arr.Length && arr[i + 1] == target)
                        i++;

                    return new int[] { start, i };
                }
            }

            return new int[2] { -1, -1 };
        }


        public static void Initial(string [] args)
        {
            var arr = Console.ReadLine().Split(' ').ToList().Select(x => Convert.ToInt32(x)).ToArray();
            var target = Convert.ToInt32(Console.ReadLine());


            var result = FindFirstAndLast(arr, target);

            Console.WriteLine($"first position: { result[0] } - last position: { result[1] }");
        }        
    }
}
