using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class LongestPeak
    {
        public static int LongestPeak1(int[] array)
        {
            // Complexity O(n^2) | Space O(1)

            bool up, down;
            int lp = 0;
            int lpAux = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                up = false;
                down = false;
                lpAux = 0;

                for (int j = i; j < array.Length - 1; j++)
                {
                    int curr = array[j];
                    int next = array[j + 1];

                    if (next > curr && !up) up = true;
                    else if (next > curr && down) up = false;
                    else if (curr > next) down = true;
                    else if (curr == next)
                    {
                        break;
                    }

                    if (up && down)
                        lpAux++;
                    else if (up)
                    {
                        lpAux++;
                        if (i == j) lpAux++;
                    }
                    else if (down && !up)
                    {
                        break;
                    }
                }

                if (down && lpAux > lp) lp = lpAux;
            }

            return lp;
        }


        public static int LongestPeak2(int[] array)
        {
            // Complexity O(n) | Space O(1)

            if (array.Length < 3) return 0;

            int lp = 0;
            int lpAux = 0;

            for (int i = 1; i < array.Length - 1; i++)
            {
                int prev = array[i - 1];
                int curr = array[i];
                int next = array[i + 1];
                lpAux = 1;
                if (curr > prev && curr > next)
                    lpAux += GetSizePeak(array, i);
                else
                    continue;

                if (lpAux > lp) lp = lpAux;

            }


            return lp;
        }

        private static int GetSizePeak(int[] array, int peakIdx)
        {
            int left = 0;
            int right = 0;

            for (int i = peakIdx; i < array.Length - 1; i++)
            {
                int curr = array[i];
                int next = array[i + 1];
                if (curr > next) right++;
                else break;
            }

            for (int i = peakIdx; i > 0; i--)
            {
                int prev = array[i - 1];
                int curr = array[i];
                if (curr > prev) left++;
                else break;
            }

            return left + right;
        }

        public static void Initial(string [] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 1 };
            int result = LongestPeak1(arr);

            Console.WriteLine("Expected: 6");
            Console.WriteLine($"Actual: { result }");

        }

    }
}
