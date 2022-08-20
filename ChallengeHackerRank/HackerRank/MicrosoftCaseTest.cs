using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class MicrosoftCaseTest
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var result = 1;
            for (int i = 1; i <= 100000; i++)
            {
                if (!Array.Exists(A, e => e == i))
                {
                    result = i;
                    break;
                }
            }
            //Array.Sort(A);
            //var hasSwapp = false;
            //int before = A[0];
            //for(int i = 1; i < A.Length; i++)
            //{
            //    var current = A[i];
            //    hasSwapp = (current - before) > 1 && current > 0;
            //    if(hasSwapp)
            //    {
            //        result = before + 1;
            //        break;
            //    }

            //    before = current;
            //}

            //if (!hasSwapp && before > 0)
            //    result = A[A.Length - 1] + 1;

            return result;

        }


        public static void Initial(string[] args)
        {

            //int[] A = new int[] { 1, 3, 6, 4, 1, 2 }; // 5
            //int[] A = new int[] { 1, 2, 3 }; // 4
            int[] A = new int[] { -1, -3 }; // 1

            solution(A);
        }

    }
}
