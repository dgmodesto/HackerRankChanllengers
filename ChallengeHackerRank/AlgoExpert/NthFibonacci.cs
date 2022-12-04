using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class NthFibonacci
    {
        public static int GetNthFib1(int n)
        {
            // Write your code here.

            if (n == 0 || n == 1) return 0;
            if (n == 2) return 1;
            int fib = 1;
            int prev = 0;
            int i = 2;
            while (i < n)
            {
                int aux = fib;
                fib = fib + prev;
                prev = aux;
                i++;
            }

            return fib;
        }

        public static int GetNthFib2(int n)
        {
            // Write your code here.
            if (n == 0 || n == 1) return 0;
            if (n == 2) return 1;
            int fib = GetNthFib2(n - 1) + GetNthFib2(n - 2);
            return fib;
        }

        public static int GetNthFib3(int n)
        {
            // Solution using Cache 
            // Complexity O(n) | Space O(1)
            int fib = FibonacciAux(n, new int[n + 1]);
            return fib;
        }

        private static int FibonacciAux(int i, int[] memo)
        {
            if (i <= 2) return i - 1;
            if (memo[i] == 0)
            {
                memo[i] = FibonacciAux(i - 1, memo) + FibonacciAux(i - 2, memo);
            }
            return memo[i];
        }

        public static void Initial(string [] args)
        {
            int input = 6;
            int result = GetNthFib1(input);

            Console.WriteLine("Expected: 5");
            Console.WriteLine($"Actual: { result }");

        }
    }
}
