using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class SharlockAndSquares
    {

        /*
   * Complete the 'squares' function below.
   *
   *https://www.hackerrank.com/challenges/sherlock-and-squares/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign
   *
   * The function is expected to return an INTEGER.
   * The function accepts following parameters:
   *  1. INTEGER a
   *  2. INTEGER b
   */

        public static int squares(int a, int b)
        {
            int result = 0;




            for(int i =0; i <= b; i++)
            {
                var square = Math.Pow(i, 2);

                if(square >= a && square <= b)
                {
                    result++;
                }

                if (square >= b)
                    break;
            }

            return result;
        }

        public static void Initial(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int a = Convert.ToInt32(firstMultipleInput[0]);

                int b = Convert.ToInt32(firstMultipleInput[1]);

                int result = squares(a, b);

                Console.WriteLine(result);
            }

        }
    }
}
