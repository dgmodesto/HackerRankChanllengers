using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class ManasaAndStones
    {

        /*
     * Complete the 'stones' function below.
     *
     *https://www.hackerrank.com/challenges/manasa-and-stones/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER a
     *  3. INTEGER b
     *  
     *  Here is the gist: Compute the difference between a and b, start a while loop at lowest possible answer; a * n-1. 
     *  Then add difference to this value & string. Then iterate until value = maxium output of b * n-1.
     */

        public static List<int> stones(int n, int a, int b)
        {
            var result = new List<int>();

            var aMin = Math.Min(a, b);
            var bMax = Math.Max(a, b);
            var stones = n--;

            var current = aMin * stones;
            var max = bMax * stones;
            var difference = bMax - aMin;
            if (aMin == bMax)
            {
                result.Add(current);
            }
            else
            {
                while (current <= max)
                {
                    result.Add(current);
                    current += difference;
                }
            }
            return result;
        }


        public static void Initial(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine().Trim());

            for (int TItr = 0; TItr < T; TItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int a = Convert.ToInt32(Console.ReadLine().Trim());

                int b = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> result = stones(n, a, b);

                Console.WriteLine(String.Join(" ", result));
            }

        }

    }
}
