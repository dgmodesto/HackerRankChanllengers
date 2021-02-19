using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class BalancedBrackets
    {
        // Complete the isBalanced function below.
        static string isBalanced(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s.ToCharArray())
            {
                if (c == '{' || c == '('|| c == '[')
                    stack.Push(c);

                if (c == '}' || c == ')'|| c == ']')
                {

                    // If we see an ending bracket without 
                    //   a pair then return false 
                    if (stack.Count == 0)
                    {
                        return "NO";
                    }

                    // Pop the top element from stack, if 
                    // it is not a pair brackets of 
                    // character then there is a mismatch. This 
                    // happens for expressions like {(}) 
                    else if (!isMatchingPair(stack.Pop(), c))
                    {
                        return "NO";
                    }
                }

            }

            if (stack .Count == 0)
                return "YES";
            else
            {
                return "NO";
            }

        }

        static Boolean isMatchingPair(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')')
                return true;
            else if (character1 == '{' && character2 == '}')
                return true;
            else if (character1 == '[' && character2 == ']')
                return true;
            else
                return false;
        }

        public static void Initial(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string s = Console.ReadLine();

                string result = isBalanced(s);

                Console.WriteLine(result);
            }

        }
    }
}
