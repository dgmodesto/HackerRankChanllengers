using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class SherlockValidString
    {
        /*
         * https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
         * 
         * 
 * Complete the 'isValid' function below.
 *
 * The function is expected to return a STRING.
 * The function accepts STRING s as parameter.
 */

        public static string isValid(string s)
        {

            var groups = s.GroupBy(c => c);
            var groupedCounts = groups.GroupBy(c => c.Count()).OrderByDescending(e => e.Count());
            if (groupedCounts.Count() == 2)
                return groupedCounts.ElementAt(1).Count() == 1 && 
                    (groupedCounts.ElementAt(1).Key == 1 || 
                     Math.Abs(groupedCounts.ElementAt(1).Key - groupedCounts.First().Key
                    ) <= 1) ? "YES" : "NO";
            else if (groupedCounts.Count() == 1)
                return "YES";
            return "NO";
        }


        public static void Initial(string[] args)
        {

            string s = Console.ReadLine();

            string result = isValid(s);

            Console.WriteLine(result);
        }
    }
}
