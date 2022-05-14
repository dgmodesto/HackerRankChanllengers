using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class GenerateParentheses
    {
        /*
         * Given an integer n, generate all the valid combinations of n pairs of parentheses
         Explanation:
            A combination that contains 1 type of parentheses is valid if everry opening parenthesis has its closing parenthesis, 
            and it doesn't have a closing parenthesis witout having an unused opening parenthesis before it.
         Exemple:
         Input: 
            n = 3
         Output
            ["((()))", "(()())", "(())()", "()(())", "()()()"]
         */

        // Function that print all combinations of
        // balanced parentheses
        // open store the count of opening parenthesis
        // close store the count of closing parenthesis
        static void _printParenthesis(char[] str, int pos, int n, int open, int close)
        {
            if (close == n)
            {
                // print the possible combinations
                for (int i = 0; i < str.Length; i++)
                    Console.Write(str[i]);

                Console.WriteLine();
                return;
            }
            else
            {
                if (open > close)
                {
                    str[pos] = ')';
                    _printParenthesis(str, pos + 1, n, open, close + 1);
                }
                if (open < n)
                {
                    str[pos] = '(';
                    _printParenthesis(str, pos + 1, n, open + 1, close);
                }
            }
        }

        // Wrapper over _printParenthesis()
        static void printParenthesis(char[] str, int n)
        {
            if (n > 0)
                _printParenthesis(str, 0, n, 0, 0);
            return;
        }


        public static void Initial(string [] args)
        {
            int n = 2;
            char[] str = new char[2 * n];

            printParenthesis(str, n);
        }
    }
}
