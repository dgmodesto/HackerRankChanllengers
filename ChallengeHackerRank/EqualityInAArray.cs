using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class EqualityInAArray
    {
        /*
    * Complete the 'equalizeArray' function below.
    *
    *https://www.hackerrank.com/challenges/equality-in-a-array/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
    *
5
3 3 2 1 3
    * The function is expected to return an INTEGER.
    * The function accepts INTEGER_ARRAY arr as parameter.
    */

        public static int equalizeArray(List<int> arr)
        {
                int result = 0;

                int max = 0;

                for(int i =0; i < arr.Count; i++)
                {
                    var count = arr.Where(item => item == arr[i]).Count();

                    if (count > max)
                        max = count;
                }

                result = arr.Count - max;

                return result;
        }


        public static void Initial(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = equalizeArray(arr);

            Console.WriteLine(result);

        }
    }
}
