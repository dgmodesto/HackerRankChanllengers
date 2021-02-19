using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public class CountingValleys
    {
        /*
            - An avid hiker keeps meticulous records of their hikes.
            - During the last hike that took exactly steps steps, for every step it was noted if it was an uphill.
            - U, or a downhill, D step.
            - Hikes always start and end at sea level, and each step up or down represents a 1 unit change in altitude. We define the following terms:
                - A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
                - A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
            - Given the sequence of up and down steps during a hike, find and print the number of valleys walked through.
            - Example
                - steps = 8 path = [UDDDUDUU]
                - The hiker first enters a valley 2 units deep.
                - Then they climb out and up onto a mountain 2 units high.
                - Finally, the hiker returns to sea level and ends the hike.
         */
        public static void Initial(string [] args)
        {
            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = CountingValley(steps, path);

            Console.WriteLine(result);

        }

        private static int CountingValley(int steps, string path)
        {
            int result = 0;
            int sum = 0;
            for(int i =0; i < steps; i++)
            {
                var step = path[i];

                if (step == 'D')
                    sum--;
                else
                    sum++;

                if (sum == 0 && step == 'U')
                    result++;
            }

            return result;
        }
    }
}
