using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class ValidateSubSequence
    {
        /*
         https://www.algoexpert.io/questions/validate-subsequence
         
          INPUT 
            array = [5, 1, 22, 25, 6, -1, 8, 10]
            sequence =  [1, 6, -1, 10 ]
          OUTPUT
            true

         */

        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            // Write your code here.
            foreach (var item in array)
            {
                if (sequence.Contains(item))
                {
                    var idx = sequence.IndexOf(item);
                    if (idx != 0) return false;
                    sequence.RemoveAt(idx);
                }
            }
            return !sequence.Any();
        }

        public static void Initial(string [] args)
        {
            var arr = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            var sequence = new List<int> { 1, 6, -1, 10 };

            var res = IsValidSubsequence(arr, sequence);

            Console.WriteLine(res);
        }

    }
}
