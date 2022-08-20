using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class StringAlternatingCharacters
    {
        /*
         * https://www.hackerrank.com/challenges/alternating-characters/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings&h_r=next-challenge&h_v=zen
         * 
         * 
 * Complete the 'alternatingCharacters' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts STRING s as parameter.
 */

        public static int alternatingCharacters(string s)
        {
            char prevC = ' ';
            int count = 0;
            foreach (char item in s)
            {
                if (prevC == ' ')
                {
                    prevC = item;
                    continue;
                }

                if (prevC == item)
                {
                    count++;
                }
                else
                {
                    prevC = item;
                }
            }
            return count;
        }


        public static void Initial (string [] args)
        {

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = alternatingCharacters(s);

                Console.WriteLine(result);
            }

        }
    }
}
