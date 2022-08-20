using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class IntegerLonely
    {

        /*
         * https://www.hackerrank.com/challenges/one-week-preparation-kit-lonely-integer/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-two
         * 
         * 
    * Complete the 'lonelyinteger' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts INTEGER_ARRAY a as parameter.
    * 
    * 
INPUT
5
0 0 1 2 1

OUTPUT
2
    */

        public static int lonelyinteger(List<int> a)
        {
            var map = new Dictionary<int, int>();
            foreach (var item in a)
            {
                if (!map.ContainsKey(item))
                {
                    map.Add(item, 1);
                }
                else
                {
                    map[item] = map[item] + 1;
                }
            }
            int result = map.FirstOrDefault(x => x.Value == 1).Key;
            return result;
        }

        public static void Initial(string [] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = lonelyinteger(a);

            Console.WriteLine(result);
        }
    }
}
