using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class FlatnandSpaceStations
    {



        // Complete the flatlandSpaceStations function below.
        /*
         https://www.hackerrank.com/challenges/flatland-space-stations/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign

5 2     n = 5, c[] size m = 2
0 4     c = [0, 4]
5 2
0 4

        Explanation: 
            Sort the array in incresing order. 
            1.  Take the maximum distance from the starting city (0) and 
                from the last city from the nearest station. Also eliminate the case of only 1 staion. 
            2. Now take the maximum distance from the given station to any city 
               using formula (a[i+1]-a[i])/2. Just draw the diagrams and you will get the formula. 
            3. The maximum value of distance is the answer.
         */

        static int flatlandSpaceStations(int n, int[] c)
        {
            Array.Sort(c);

            int maxD = Math.Max(c[0], (n - 1 - c[c.Length - 1]));

            for (int i = 0; i < c.Length - 1; i++) {
                int candidateMaxD = (c[i + 1]- c[i]) / 2;
                maxD = Math.Max(candidateMaxD, maxD);
            }

            return maxD;
        }

        public static void Initial(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = flatlandSpaceStations(n, c);

            Console.WriteLine(result);
        }

    }
}
