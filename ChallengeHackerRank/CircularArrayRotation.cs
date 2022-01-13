using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class CircularArrayRotation
    {

        /*
     * Complete the 'circularArrayRotation' function below.
     *
     *https://www.hackerrank.com/challenges/circular-array-rotation/problem?isFullScreen=true&h_r=next-challenge&h_v=zen
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER k
     *  3. INTEGER_ARRAY queries
Input
3 2 3
1 2 3
0
1
2

Output
2
3
1
     */

        public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
        {
            var result = new List<int>();
            for (int i =0; i < k; i++)
            {
                int last = a[a.Count- 1];
                a.Insert(0, last);
                a.RemoveAt(a.Count - 1);
            }

            for(int i = 0; i < queries.Count; i++)
            {
                result.Add(a[queries[i]]);
            }

            return result;
        }

        public static void Initial(string[] args)
        {

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            int q = Convert.ToInt32(firstMultipleInput[2]);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> queries = new List<int>();

            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
                queries.Add(queriesItem);
            }

            List<int> result = circularArrayRotation(a, k, queries);

            Console.WriteLine(String.Join("\n", result));

        }

    }
}
