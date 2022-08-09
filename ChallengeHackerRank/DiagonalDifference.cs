using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class DiagonalDifference
    {
        /*
    * Complete the 'diagonalDifference' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts 2D_INTEGER_ARRAY arr as parameter.
INPUT
3
11 2 4
4 5 6
10 8 -12

OUTPUT
15
    */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int f = 0;
            int s = 0;
            int last = arr.Count() - 1;
            for (int i = 0; i < arr.Count(); i++)
            {
                f += arr[i][i];
                s += arr[i][last--];
            }
            return Math.Abs(f - s);
        }

        public static void Initial(string [] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<List<int>> arr = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
            int result = diagonalDifference(arr);
            Console.WriteLine(result);
        }
    }
}
