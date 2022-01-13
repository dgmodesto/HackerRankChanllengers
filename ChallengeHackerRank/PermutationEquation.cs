using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class PermutationEquation
    {
        /*
     * Complete the 'permutationEquation' function below.
     *
     *https://www.hackerrank.com/challenges/permutation-equation/problem?isFullScreen=true&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY p as parameter.
input
3 
2 3 1
output
2
3
1
     */

        public static List<int> permutationEquation(List<int> p)
        {
            var result = new List<int>();

            for(int i = 1; i <= p.Count; i++)
            {
                var idx = p.IndexOf(i);
                var idxY = p.IndexOf(idx+1)+1;

                result.Add(idxY);
            }

            return result;

        }


        public static void Initial(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> p = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pTemp => Convert.ToInt32(pTemp)).ToList();

            List<int> result = permutationEquation(p);

            Console.WriteLine(String.Join("\n", result));

        }
    }
}
