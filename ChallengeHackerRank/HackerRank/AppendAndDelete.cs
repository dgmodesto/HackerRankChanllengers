using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class AppendAndDelete
    {

        /*
    * Complete the 'appendAndDelete' function below.
    *
    *https://www.hackerrank.com/challenges/append-and-delete/problem?isFullScreen=true
    *
    * The function is expected to return a STRING.
    * The function accepts following parameters:
    *  1. STRING s
    *  2. STRING t
    *  3. INTEGER k
    *  
hackerhappy
hackerrank
9


    */

        public static string appendAndDelete(string s, string t, int k)
        {
            /* Case 1 */
            if (s.Length + t.Length <= k)
            {
                return "Yes";
            }

            /* Case 2 */
            int i = 0; // represents index of 1st non-matching character
            for (; i < s.Length && i < t.Length; i++)
            {
                if (s[i] != t[i])
                {
                    break;
                }
            }
            int minOperations = (s.Length - i) + (t.Length - i);
            var result =  k >= minOperations && (k - minOperations) % 2 == 0;

            if (result)
                return "Yes";
            else
                return "No";
        }

        public static void Initial(string[] args)
        {
            string s = Console.ReadLine();

            string t = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string result = appendAndDelete(s, t, k);

            Console.WriteLine(result);
        }


    }
}
