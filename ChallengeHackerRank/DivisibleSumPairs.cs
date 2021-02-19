using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class DivisibleSumPairs
    {
        /*
         Given an array of integers and a positive integer , determine the number of  pairs where  and  +  is divisible by .

        Example



        Three pairs meet the criteria:  and .

        Function Description

        Complete the divisibleSumPairs function in the editor below.

        divisibleSumPairs has the following parameter(s):

        int n: the length of array 
        int ar[n]: an array of integers
        int k: the integer divisor
        Returns
        - int: the number of pairs

        Input Format

        The first line contains  space-separated integers,  and .
        The second line contains  space-separated integers, each a value of .

        Constraints

        Sample Input

        STDIN           Function
        -----           --------
        6 3             n = 6, k = 3
        1 3 2 6 1 2     ar = [1, 3, 2, 6, 1, 2]
        Sample Output

         5
         */


        // Complete the divisibleSumPairs function below.
        static int divisibleSumPairs(int n, int k, int[] ar)
        {

            int total = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    var result = ar[i] + ar[j];
                    if (result % k == 0)
                        total++;
                }
            }

            return total;
        }

        public static void Initial(string[] args)
        {

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = divisibleSumPairs(n, k, ar);

            Console.WriteLine(result);

        }
    }
}
