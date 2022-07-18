using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class MiniMaxSum
    {
        /*
         https://www.hackerrank.com/challenges/one-week-preparation-kit-mini-max-sum/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-one&h_r=next-challenge&h_v=zen

        INPUT
        1 2 3 4 5

        OUTPUT
        10 14
         */


        static void MinMaxSum(int[] arr)
        {
            double min = 0;
            double max = 0;
            var arrLenght = arr.Count() - 1;
            for (var i = 0; i < arr.Count(); i++)
            {
                var auxArr = arr.ToList<int>();
                double value = 0;
                auxArr.RemoveAt(arrLenght--);

                for (int j = 0; j < auxArr.Count(); j++)
                {
                    value += auxArr[j];
                }

                if (i == 0)
                {
                    min = value;
                    max = value;
                    continue;
                }

                if (value < min)
                {
                    min = value;
                }
                else if (value > max)
                {
                    max = value;
                }
            }

            Console.WriteLine(min.ToString() + " " + max.ToString());
        }

        public static void miniMaxSumOptmized(List<int> arr)
        {
            var min = double.MaxValue;
            var max = double.MinValue;
            for (int i = 0; i < arr.Count(); i++)
            {
                var aux = new List<int>(arr);
                aux.RemoveAt(i);
                var value = aux.Sum();
                if (min > value)
                    min = value;
                if (value > max)
                    max = value;
            }
            Console.Write($"{min} {max}");
        }

        public static void Initial(string [] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            MinMaxSum(arr);

            List<int> arr2 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            miniMaxSumOptmized(arr2);

        }
    }
}
