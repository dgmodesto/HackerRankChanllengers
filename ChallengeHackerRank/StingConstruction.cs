using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class StingConstruction
    {
        /*
https://www.hackerrank.com/challenges/string-construction/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign

INPUT
2
abcd
abab

OUTPUT
4
2
 */

        public static int stringConstruction(string s)
        {
            return s.ToCharArray().Distinct().Count();

        }


        public static void Initial(string [] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = stringConstruction(s);

                Console.WriteLine(result);
            }

        }

    }
}
