using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class LibraryFine
    {
        /*
    * Complete the 'libraryFine' function below.
    *
    *https://www.hackerrank.com/challenges/library-fine/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign&h_r=next-challenge&h_v=zen
    *
    * The function is expected to return an INTEGER.
    * The function accepts following parameters:
    *  1. INTEGER d1
    *  2. INTEGER m1
    *  3. INTEGER y1
    *  4. INTEGER d2
    *  5. INTEGER m2
    *  6. INTEGER y2
    */

        public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            int fine = 0;

            var date1 = new DateTime(y1, m1, d1);
            var date2 = new DateTime(y2, m2, d2);

            if (y1 > y2)
            {
                fine = 10000;
            }
            else if (y1 >= y2 && m1 > m2)
            {
                int diffMonth = m1 -  m2;
                fine = diffMonth * 500;
            }
            else if (y1 >= y2 && m1 >= m2 && d1 > d2)
            {
                int diffDays = d1 - d2
                fine = diffDays * 15;
            }

            return fine;
        }

        public static void Initial(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d1 = Convert.ToInt32(firstMultipleInput[0]);

            int m1 = Convert.ToInt32(firstMultipleInput[1]);

            int y1 = Convert.ToInt32(firstMultipleInput[2]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d2 = Convert.ToInt32(secondMultipleInput[0]);

            int m2 = Convert.ToInt32(secondMultipleInput[1]);

            int y2 = Convert.ToInt32(secondMultipleInput[2]);

            int result = libraryFine(d1, m1, y1, d2, m2, y2);

            Console.WriteLine(result);

        }
    }
}
