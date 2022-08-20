using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class PlusMinus
    {
        /*
         * 
         * https://www.hackerrank.com/challenges/one-week-preparation-kit-plus-minus/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-one
         * 
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         * 
         * INPUT
           6
           -4 3 -9 0 4 1
         * 
         * OUTPUT 
            0.500000
            0.333333
            0.166667
         
         */

        public static void plusMinus(List<int> arr)
        {
            int neg = 0;
            int pos = 0;
            int zer = 0;
            foreach (float value in arr)
            {
                if (value < 0)
                    neg++;
                else if (value > 0)
                    pos++;
                else
                    zer++;
            }

            int count = arr.Count();

            float resPos = (float)pos / count;
            float resNeg = (float)neg / count;
            float resZer = (float)zer / count;

            Console.WriteLine(resPos.ToString("N6"));
            Console.WriteLine(resNeg.ToString("N6"));
            Console.WriteLine(resZer.ToString("N6"));


        }



        public static void Initial(string [] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            plusMinus(arr);

        }
    }
}
