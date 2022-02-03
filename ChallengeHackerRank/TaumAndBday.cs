using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class TaumAndBday
    {

        /*
 * Complete the 'taumBday' function below.
 *
 * The function is expected to return a LONG_INTEGER.
 * The function accepts following parameters:
 *  1. INTEGER b
 *  2. INTEGER w
 *  3. INTEGER bc
 *  4. INTEGER wc
 *  5. INTEGER z
 *  
 *  
3 6     b = 3, w = 6
9 1 1   bc = 9, wc = 1, z = 1
1
3 6
9 1 1 

1
7 7
4 2 1

 
         */

        public static long taumBday(int b, int w, int bc, int wc, int z)
        {
            //return (long)(b * Math.Min(bc, wc + z)) + (long)(w * Math.Min(wc, bc + z));

            var wPrice = (long)w * (wc < bc + z ? wc : bc + z);
            var bPrice = (long)b * (bc < wc + z ? bc : wc + z);
            return wPrice + bPrice;
        }


        public static void Initial(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int b = Convert.ToInt32(firstMultipleInput[0]);

                int w = Convert.ToInt32(firstMultipleInput[1]);

                string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int bc = Convert.ToInt32(secondMultipleInput[0]);

                int wc = Convert.ToInt32(secondMultipleInput[1]);

                int z = Convert.ToInt32(secondMultipleInput[2]);

                long result = taumBday(b, w, bc, wc, z);

                Console.WriteLine(result);
            }
        }

    }
}
