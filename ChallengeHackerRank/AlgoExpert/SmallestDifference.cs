using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class SmallestDifference
    {

        public static int[] SmallestDifference1(int[] arrayOne, int[] arrayTwo)
        {
            // Write your code here.
            // Complexity O(n^2) | Space O(1)

            int diff = int.MaxValue;
            int[] result = new int[2];
            for (int i = 0; i < arrayOne.Length; i++)
            {
                for (int j = 0; j < arrayTwo.Length; j++)
                {
                    int diffCurr = Math.Abs(arrayOne[i] - arrayTwo[j]);
                    if (diffCurr <= diff)
                    {
                        diff = diffCurr;
                        result[0] = arrayOne[i];
                        result[1] = arrayTwo[j];
                    }
                }
            }

            return result;
        }

        public static int[] SmallestDifference2(int[] arrayOne, int[] arrayTwo)
        {
            // Write your code here.
            // Complexity O(nLogn + mLogm) | Space O(1)

            int diff = int.MaxValue;
            int[] result = new int[2];


            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            int idxOne = 0;
            int idxTwo = 0;

            while (idxOne < arrayOne.Length && idxTwo < arrayTwo.Length)
            {
                int one = arrayOne[idxOne];
                int two = arrayTwo[idxTwo];
                int diffCurr = Math.Abs(one - two);

                if (diffCurr == 0)
                {
                    result[0] = one;
                    result[1] = two;
                    break;
                }

                if (diffCurr <= diff)
                {
                    diff = diffCurr;
                    result[0] = one;
                    result[1] = two;
                }

                if (one > two)
                    idxTwo++;
                else
                    idxOne++;
            }

            return result;
        }


        public static int[] SmallestDifference3(int[] arrayOne, int[] arrayTwo)
        {
            // Write your code here.
            // Complexity O(nLogn + mLogm) | Space O(1)

            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            int idxOne = 0;
            int idxTwo = 0;

            int smallest = int.MaxValue;
            int current = int.MaxValue;
            int[] smallestPair = new int[2];

            while (idxOne < arrayOne.Length && idxTwo < arrayTwo.Length)
            {
                int one = arrayOne[idxOne];
                int two = arrayTwo[idxTwo];

                if (one < two)
                {
                    current = two - one;
                    idxOne++;
                }
                else if (two < one)
                {
                    current = one - two;
                    idxTwo++;
                }
                else
                {
                    return new int[] { one, two };
                }

                if (smallest > current)
                {
                    smallest = current;
                    smallestPair = new int[2] { one, two };
                }
            }

            return smallestPair;
        }
        public static void Initial(string[] args)
        {
            int[] expected = { 28, 26 };
            int[] actual = SmallestDifference1(new int[] { -1, 5, 10, 20, 28, 3 }, new int[] { 26, 134, 135, 15, 17 });

            Console.WriteLine("Expected");
            Array.ForEach(expected, Console.Write);

            Console.WriteLine("Actual");
            Array.ForEach(actual, Console.Write);

        }
    }
}
