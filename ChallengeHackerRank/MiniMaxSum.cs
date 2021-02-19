using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class MiniMaxSum
    {
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

        public static void Initial(string [] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            MinMaxSum(arr);

        }
    }
}
