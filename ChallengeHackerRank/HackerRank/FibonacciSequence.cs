using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class FibonacciSequence
    {
        /*
         * https://www.hackerrank.com/challenges/ctci-fibonacci-numbers/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=recursion-backtracking
         

Sample Input
6

Sample Output
8
         */
        public static int Fibonacci1(int n)
        {

            // Write your code here.
            int res = 0;
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;

            res = Fibonacci1(n - 1) + Fibonacci1(n - 2);
            return res;

        }

        public static int Fibonacci2(int n)
        {
            if (n == 0) return 0;
            else if (n == 10) return 1;

            int[] memo = new int[n];
            memo[0] = 0;
            memo[1] = 1;

            for (int i = 2; i < n; i++)
            {
                memo[i] = memo[i - 1] + memo[i - 2];
            }
            return memo[n - 1] + memo[n - 2];
        }


        public static int Fibonacci3(int n)
        {
            if(n==0) return 0;
            int a = 0;
            int b = 1;
            for(int i = 2; i < n; i++)
            {
                int c = a + b;
                a = b;
                b = c;
            }

            return a + b;
        }

        public static int Fibonacci4(int n)
        {
            return FibonacciAux(n, new int[n + 1]);
        }

        private static int FibonacciAux(int i, int[] memo)
        {
            if (i == 0 || i == 1) return i;

            if (memo[i] == 0)
            {
                memo[i] = FibonacciAux(i - 1, memo) + FibonacciAux(i - 2, memo);
            }

            return memo[i];
        }

        public static void Initial(string[] args)
        {
            int result = Fibonacci1(6);

            Console.WriteLine("Expected: 8");
            Console.WriteLine($"Actual: { result }");

        }
    }
}
