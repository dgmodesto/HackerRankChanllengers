using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class FirstNonRepeatingCharacter
    {
        public static int FirstNonRepeatingCharacter1(string str)
        {
            // Complexity O(N) | Space O(1)

            for (int i = 0; i < str.Length; i++)
            {
                var freq = CountFrequency(str[i], str);
                if (freq == 1)
                    return i;
            }

            return -1;
        }

        public static int FirstNonRepeatingCharacter2(string str)
        {
            // Complexity O(N-C) | Space O(N)

            var alreadyCounted = new HashSet<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (alreadyCounted.Contains(str[i]))
                    continue;

                var freq = CountFrequency(str[i], str);
                if (freq == 1)
                    return i;

                alreadyCounted.Add(str[i]);
            }

            return -1;
        }

        public static int FirstNonRepeatingCharacter3(string str)
        {
            // Complexity O(N) | Space O(1)

            for (int i = 0; i < str.Length; i++)
            {
                var strWithCharRemoved = str.Remove(i, 1);
                if (strWithCharRemoved.IndexOf(str[i]) == -1)
                    return str.IndexOf(str[i]);
            }

            return -1;
        }

        private static int CountFrequency(char character, string str)
        {
            int freq = 0;
            foreach (var c in str)
            {
                if (character == c)
                    freq++;
            }

            return freq;
        }

        public static void Initial(string [] args)
        {
            string input = "faadabcbbebdf";
            int output = FirstNonRepeatingCharacter1(input);

            Console.WriteLine("Expected: 6");
            Console.Write($"Actual: { output }");
        }
    }
}
