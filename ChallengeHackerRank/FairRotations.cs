using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class FairRotations
    {


        /*
         * Complete the 'fairRations' function below.
         *
         *https://www.hackerrank.com/challenges/fair-rations/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign&h_r=next-challenge&h_v=zen
         *
         * The function is expected to return a STRING.
         * The function accepts INTEGER_ARRAY B as parameter.
         * 
    STDIN       Function
-----       --------
5           B[] size N = 5
2 3 4 5 6   B = [2, 3, 4, 5, 6]
        
5
2 3 4 5 6

2
1 2
         */

        public static string fairRations(List<int> B)
        {
            int result = 0;

            for(int i = B.Count - 1; i >= 1; i--)
            {
                var current = B[i];

                if(current % 2 != 0)
                {
                    B[i]++;
                    B[i-1]++;
                    result += 2;
                }

            }
                
            var allEven = B.Where(x => x % 2 != 0).Count() ;

            return allEven == 0 ? result.ToString() : "NO" ;
        }

        public static void Initial(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> B = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

            string result = fairRations(B);

            Console.WriteLine(result);

        }
    }
}
