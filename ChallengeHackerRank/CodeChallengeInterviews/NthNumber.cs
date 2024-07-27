using System;

namespace ChallengeHackerRank.CodeChallengeInterviews
{
    public static class NthNumber
    {
        /*
         //1, 5
         // 3 4 7 11 18 29 47

         */
        public static int GetNthNumber(int a, int b, int n)
        {
            int res = 0;
            if (n == 0) return 0;
            if (n == 1)
                return a;
            else if (n == 2)
                return b;

            for (int i = n-2; i > 0; i--)
            { 
                res = a + b;
                a = b;
                b = res;
            }

            return res;
        }

        public static void Initial(string[] args)
        {
            // getNth(3, 4, 0) === 0
            // getNth(3, 4, 1) === 3
            // getNth(3, 4, 2) === 4

            // getNth(3, 4, 3) === 7
            // getNth(3, 4, 6) === 29
            Console.WriteLine(GetNthNumber(3, 4, 0)); // 0
            Console.WriteLine(GetNthNumber(3, 4, 1)); // 3
            Console.WriteLine(GetNthNumber(3, 4, 2)); // 4
            Console.WriteLine(GetNthNumber(3, 4, 3)); // 7
            Console.WriteLine(GetNthNumber(3, 4, 4)); // 11
            Console.WriteLine(GetNthNumber(3, 4, 5)); // 18
            Console.WriteLine(GetNthNumber(3, 4, 6)); // 29
            Console.WriteLine(GetNthNumber(3, 4, 7)); // 47
        }


    }
}
