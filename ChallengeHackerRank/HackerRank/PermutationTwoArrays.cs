using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class PermutationTwoArrays
    {
        /*
    * Complete the 'twoArrays' function below.
    *
    * The function is expected to return a STRING.
    * The function accepts following parameters:
    *  1. INTEGER k
    *  2. INTEGER_ARRAY A
    *  3. INTEGER_ARRAY B
    */

        public static string TwoArrays(int k, List<int> A, List<int> B)
        {

            int n = A.Count;
            A.Sort();
            // B = B.OrderByDescending(x => x).ToList();
            B.Sort();
            B.Reverse();
            for (int i = 0; i < n; i++)
                if (A[i] + B[i] < k)
                    return "NO";

            return "YES";
        }

        public static void Initial(string [] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int k = Convert.ToInt32(firstMultipleInput[1]);

                List<int> A = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList();

                List<int> B = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

                string result = TwoArrays(k, A, B);

                Console.WriteLine(result);
            }

        }
    }
}
