using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class SortingMarkAndToys
    {
        /*
         * https://www.hackerrank.com/challenges/mark-and-toys/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=sorting
    * Complete the 'maximumToys' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts following parameters:
    *  1. INTEGER_ARRAY prices
    *  2. INTEGER k
    */

        public static int maximumToys(List<int> prices, int k)
        {
            int maxToys = 0;
            int currentValeu = 0;

            prices.Sort();
            for(int i = 0; i < prices.Count; i++)
            {
                currentValeu += prices[i];
                if (currentValeu <= k)
                {
                    maxToys++;
                }
                else
                    break;
            }

            return maxToys;
        }


        public static void Initial(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> prices = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pricesTemp => Convert.ToInt32(pricesTemp)).ToList();

            int result = maximumToys(prices, k);

            Console.WriteLine(result);

        }
    }
}
