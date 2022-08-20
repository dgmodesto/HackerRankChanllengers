using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public class TwoStrings
    {
        /*
            - Given two strings, determine if they share a common substring.
            - A substring may be as small as one character
            - Example
                - s1 = 'and'
                - s2 = 'art
                    - These share the commom substring 'a';
                - s1 = 'be'
                - s2 = 'cat'
                    - These don't share a substring.
            - Input
2
hello
world
hi
world
            - Output
YES
NO
         */

        public static void Initial(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();

                string result = TwoString(s1, s2);

                Console.WriteLine(result);
            }
        }

        private static string TwoString(string s1, string s2)
        {

            var distS1 = s1.Distinct();
            var distS2 = s2.Distinct();

            if (distS1.Intersect(distS2).Any())
            {
                return "YES";
            }
            else
            {
                return "NO";
            }


        }
    }
}
