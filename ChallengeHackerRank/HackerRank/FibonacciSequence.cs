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
        public static int Fibonacci(int n)
        {

            // Write your code here.
            int res = 0;
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;

            res = Fibonacci(n - 1) + Fibonacci(n - 2);
            return res;

        }

        public static void Initial(string [] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));    
        }
    }
}
