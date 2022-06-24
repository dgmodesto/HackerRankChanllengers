using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class MaxMinSub
    {
        /*
  * Complete the 'maxMin' function below.
  *
  *https://www.hackerrank.com/challenges/angry-children/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=greedy-algorithms&h_r=next-challenge&h_v=zen
  *
  * The function is expected to return an INTEGER.
  * The function accepts following parameters:
  *  1. INTEGER k
  *  2. INTEGER_ARRAY arr
  *  
Sample Input 1

10
4
1
2
3
4
10
20
30
40
100
200
Sample Output 1

3
  *  
  */

        public static int maxMin(int k, List<int> arr)
        {
            int unfairness = int.MaxValue;
            int n = arr.Count;
            arr.Sort();
            for (int i = 0; i < n - k + 1; i++)
            {
                int indexMax = i + k - 1;
                int max = arr[indexMax];
                int min = arr[i];

                if ( max - min < unfairness)
                {
                    unfairness = max - min;
                }
            }
            return unfairness;
        }


        public static void Initial(string [] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
                arr.Add(arrItem);
            }

            int result = maxMin(k, arr);

            Console.WriteLine(result);
        }
    }
}
