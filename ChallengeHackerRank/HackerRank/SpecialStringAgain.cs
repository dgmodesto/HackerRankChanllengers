using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class SpecialStringAgain
    {
        /*
         https://www.hackerrank.com/challenges/special-palindrome-again/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings

INPUT
5
asasd

OUTPUT
7
        
Explanation 0
    - The special palindromic substrings of S=asasd  are { a, s, a, s, d, asa, sas }
         */
        // Complete the substrCount function below.
        static long substrCount(int n, string s)
        {
            long retVal = s.Length;

            for (int i = 0; i < n; i++)
            {
                var startChar = s[i];
                int diffCharIdx = -1;
                for(int j = i + 1; j < n; j++)
                {
                    var currChar = s[j];
                    if(currChar == startChar)
                    {
                        if((diffCharIdx == -1)  ||  (j - diffCharIdx) == (diffCharIdx - i))
                        {
                            retVal++;
                        }
                    } else
                    {
                        if (diffCharIdx == -1)
                        {
                            diffCharIdx = j;
                        }
                        else
                            break;
                    }
                }
            }

            return retVal;
        }


        public static void Initial(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            long result = substrCount(n, s);

            Console.WriteLine(result);
        }
    }
}
