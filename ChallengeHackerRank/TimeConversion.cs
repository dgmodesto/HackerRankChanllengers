using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class TimeConversion
    {
        /*
         * https://www.hackerrank.com/challenges/one-week-preparation-kit-time-conversion/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-one&h_r=next-challenge&h_v=zen
         * 
         * INPUT
         * 07:05:45PM
         * 
         * OUTPUT
         * 19:05:45
 */

        public static string timeConversion(string s)
        {
            return DateTime.Parse(s).ToString("HH:mm:ss");
        }


        public static void Initial(string [] args)
        {
            string s = Console.ReadLine();

            string result = timeConversion(s);

            Console.WriteLine(result);
        }
    }
}
