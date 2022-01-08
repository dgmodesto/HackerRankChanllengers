using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class MicrosoftCaseThree
    {

        public static int solution()
        {
            int[] A = new int[] { 3, 1, 4, 3 };
            int[] B = new int[] { 1, 3 };
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var count = 0;
            var alreadVerify = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (alreadVerify.Contains(A[i]))
                    continue;

                for (int j = 0; j < B.Length; j++)
                {

                    if (Array.Exists(B, x => x == A[i]))
                    {
                        count++;
                        alreadVerify.Add(A[i]);
                    }
                }
            }

            return count;
            //2
        }


        public static void Initial(string[] args)
        {

            solution();
        }


    }
}
