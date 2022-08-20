using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class StringCommonChild
    {
        /*
         * https://www.hackerrank.com/challenges/common-child/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
         * 
         * 
    * Complete the 'commonChild' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts following parameters:
    *  1. STRING s1
    *  2. STRING s2
    *  
INPUT
HARRY
SALLY

OUTPUT
2
        
    */

        public static int commonChild(string s1, string s2)
        {
            int countS1 = 0;
            int countS2 = 0;
            string subStr1 = string.Empty;
            string subStr2 = string.Empty;

            foreach (var c in s1)
            {
                subStr1 += c.ToString();
                if(s2.Contains(subStr1))
                {
                    countS1++;
                }

            }

            foreach (var c in s2)
            {
                subStr2 += c.ToString();
                if (s1.Contains(subStr2))
                {
                    countS2++;
                }

            }


            return countS1 > countS2 ? countS1  : countS2;
        }


        public static void Initial(string[] args)
        {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            int result = commonChild(s1, s2);

            Console.WriteLine(result);
        }

    }
}
