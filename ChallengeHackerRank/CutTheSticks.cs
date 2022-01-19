using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class CutTheSticks
    {
        /*
     * Complete the 'cutTheSticks' function below.
     * 
     * https://www.hackerrank.com/challenges/cut-the-sticks/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

        public static List<int> cutTheSticks(List<int> arr)
        {
            var result = new List<int>();
            int totalSticks = arr.Count;
            result.Add(totalSticks);

            for (int i = 0; i < arr.Count; i++)
            {
                var min = arr.Min();
                var baseCase = arr.Where(x => x > min).Count();

                if (baseCase == 0)
                    break;

                for(int j = 0; j < arr.Count; j++)
                {
                    arr[j] -= min;
                    if (arr[j] <= 0)
                    {
                        arr.RemoveAt(j);
                        j--;
                    }
                }
                totalSticks = arr.Count;
                result.Add(totalSticks);
                i = 0;
            }


            return result;
        }

        public static void Initial(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = cutTheSticks(arr);

            Console.WriteLine(String.Join("\n", result));

        }
    }
}
