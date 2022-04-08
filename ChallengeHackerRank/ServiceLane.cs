using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class ServiceLane
    {
        /*
 * Complete the 'serviceLane' function below.
 *
 * The function is expected to return an INTEGER_ARRAY.
 * The function accepts following parameters:
 *  1. INTEGER n
 *  2. 2D_INTEGER_ARRAY cases
 *  
8 5
2 3 1 2 3 2 3 3
0 3
4 6
6 7
3 5
0 7
 */

        public static List<int> serviceLane(int n, List<List<int>> cases, List<int> width)
        {
            var result = new List<int>();

            for(int i =0; i < cases.Count; i++)
            {
                var currentCase = cases[i];

                
                int minNumber = int.MaxValue;
                for (int j = currentCase[0]; j <= currentCase[1]; j++)
                {
                    if (width[j] < minNumber)
                        minNumber = width[j];
                }
                result.Add(minNumber);
            }

            return result;
        }

        public static void Initial(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int t = Convert.ToInt32(firstMultipleInput[1]);

            List<int> width = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(widthTemp => Convert.ToInt32(widthTemp)).ToList();

            List<List<int>> cases = new List<List<int>>();

            for (int i = 0; i < t; i++)
            {
                cases.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(casesTemp => Convert.ToInt32(casesTemp)).ToList());
            }

            List<int> result = serviceLane(n, cases, width);

            Console.WriteLine(String.Join("\n", result));
        }
    }
}
