using System;
using System.Collections.Generic;

namespace ChallengeHackerRank.LeetCode
{

    public static class ValidPairs
    {
        public static int GetValidPairs(int[] numbers, int k)
        {
            var hs = new HashSet<string>();
            int counter = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                int currA = numbers[i];
                for(int j = i+1; j < numbers.Length; j++)
                {
                    int currB = numbers[j];
                    string key = string.Empty;
                    if(currA > currB)
                    {
                        key = currA.ToString() + currB.ToString();
                    } else
                    {
                        key = currB.ToString() + currA.ToString();
                    }

                    if (currA + k == currB && !hs.Contains(key))
                    {
                        hs.Add(key);
                        counter++;
                        break;
                    }
                }
            }

            return counter;
        }

        public static void Initial(string[] args)
        {
            int[] input = new int[] { 1, 1, 2, 2, 3, 3 };
            int k = 1;
            int output = 2;

            var result = GetValidPairs(input, k);

            Console.WriteLine("Expected : {0} ", output);
            Console.WriteLine("Result :{0} ", result);
        }
    }
}
