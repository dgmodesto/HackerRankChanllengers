using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class DynamicArray
    {
        /*
         
        - Create a 2-dimensional array, arr, of n empty arrays. All arrays are zero indexed.
        - Create an integer, lastAnswer, and initialize it to 0;
        - There are 2 Types of queries
            1. Query 1 x y
                1. Find the list within arr at index idx = ((x ^ lastAnswer) % n).
                2. Append the integer y to the arr[idx].
            2. Query 2 x y
                1. Find the list within arr at index idx = ((x ^ lastAnswer) % n).
                2. Find the value of element y % size(arr[idx]) where size is the number of elements in arr[idx].AssingTheValueToLastAnswere.
                3. Print the new value of lastAnswere on a new line.
         - Input
2 5
1 0 5
1 1 7
1 0 3
2 1 0
2 1 1

        - Output
7
3
         */

        private static List<int> DynamicsArray(int n, List<List<int>> queries)
        {
            int x, y, type, lastAnswer = 0;

            List<int> result = new List<int>();
            var seqList = new List<List<int>>();
            for (int i = 0; i < n; i++)
                seqList.Add(new List<int>());


            foreach(var q in queries)
            {
                type = q[0];
                x = q[1];
                y = q[2];

                int temp = (x ^ lastAnswer) % n;
                if (type == 1)
                {
                    seqList[temp].Add(y);
                }
                else
                {
                    lastAnswer = seqList[temp][y % (seqList[temp].Count)];
                    result.Add(lastAnswer);
                }
            }

            return result;
        }

        public static void Initial(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int q = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            List<int> result = DynamicsArray(n, queries);
            Console.WriteLine(String.Join("\n", result));
        }

    }
}
