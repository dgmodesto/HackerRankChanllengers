using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class Palindrome
    {

        public static bool IsPalindrome1(string str)
        {
            // Write your code here.

            string p = "";
            for (int i = str.Length - 1; i >= 0; i--)
                p += str[i].ToString();

            return p == str;
        }

        public static void Initial(string [] args)
        {
            string input = "abcdcba";
            var output = IsPalindrome1(input);

            Console.WriteLine("Expected: true");
            Console.Write($"Actual: { output }");
        }
    }
}
