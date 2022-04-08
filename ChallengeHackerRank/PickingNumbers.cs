using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class PickingNumbers
    {

        /*
         * https://www.hackerrank.com/challenges/picking-numbers/problem?isFullScreen=true
         * 
         * 
        Given an array of integers, 
        find the longest subarray where the absolute difference between any 
        two elements is less than or equal to 1.
        
        Example
            a = [1,1,2,2,4,4,5,5,5]

            There are two subarrays meeting the criterion:  [1,1,2,2] and [4,4,5,5,5]. 
            The maximum length subarray has 5 elements.

        Function Description

        Complete the pickingNumbers function in the editor below.

        pickingNumbers has the following parameter(s):

        int a[n]: an array of integers

        Returns

        int: the length of the longest subarray that meets the criterion

        Input Format

        The first line contains a single integer n , the size of the array a.
        The second line contains  space-separated integers, each an a[i].
INPUT

6
4 6 5 3 3 1

OUTPUT
3
         */


        public static int pickingNumbers(List<int> a)
        {
            int [] frequency = new int[101];
            int result = int.MinValue;

            for (int i = 0; i < a.Count(); i++)
            {
                int index = a[i];
                frequency[index]++; //frequency[index]=frequency[index]+1
            }

            for (int i = 1; i <= 100; i++)
            {
                result = Math.Max(result, frequency[i] + frequency[i - 1]);
            }
            return result;
        }


        public static void Initial(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine()
                .TrimEnd()
                .Split(' ')
                .ToList()
                .Select(aTemp => Convert.ToInt32(aTemp))
                .ToList();

            int result = pickingNumbers(a);

            Console.WriteLine(result);
        }

    }
}
