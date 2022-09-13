using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class FindThreeLargestNumbers
    {

        public static int[] FindThreeLargestNumbers1(int[] array)
        {
            // Write your code here.
            // Complexity O(n) | Space O(1)

            int num1 = int.MinValue;
            int num2 = int.MinValue;
            int num3 = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > num3)
                {
                    num1 = num2;
                    num2 = num3;
                    num3 = array[i];
                }
                else if (array[i] > num2)
                {
                    num1 = num2;
                    num2 = array[i];
                }
                else if (array[i] > num1)
                {
                    num1 = array[i];
                }
            }


            return new int[] { num1, num2, num3 };
        }



        public static void Initial(string [] args)
        {
            int[] expected = { 18, 141, 541 };
            int[] input = new int[] {141, 1, 17, -7,-17, -27, 18, 541, 8, 7, 7};

            var result = FindThreeLargestNumbers1(input);

            Console.WriteLine("Expected ");
            Array.ForEach(expected, Console.Write);


            Console.WriteLine("Actual ");
            Array.ForEach(result, Console.Write);
        }
    }
}
