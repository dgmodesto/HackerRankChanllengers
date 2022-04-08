using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class FizzBuzz
    {
        /*
     * Complete the 'fizzBuzz' function below.
     *


Input
15

Output
1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
     * The function accepts INTEGER n as parameter.
     */

        public static void fizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                var fizz = i % 3 == 0;
                var buzz = i % 5 == 0;

                if (fizz && buzz)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (fizz)
                {
                    Console.WriteLine("Fizz");
                }
                else if (buzz)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Initial(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            fizzBuzz(n);
        }
    }
}
