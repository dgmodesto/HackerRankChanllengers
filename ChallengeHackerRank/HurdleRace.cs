using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class HurdleRace
    {
        /*
         https://www.hackerrank.com/challenges/the-hurdle-race/problem?isFullScreen=true
         */
        public static int hurdleRace(int k, List<int> height)
        {
            var result = 0;

            var maxNumber = height.Select((n) => (n)).Max();

            if(maxNumber > k)
            {
                result = Math.Abs(k - maxNumber);
            }

            return result;
        }

        public static void Initial(string[] args)
        {

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> height = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(heightTemp => Convert.ToInt32(heightTemp)).ToList();

            int result = hurdleRace(k, height);

            Console.WriteLine(result);

        }
    }
}
