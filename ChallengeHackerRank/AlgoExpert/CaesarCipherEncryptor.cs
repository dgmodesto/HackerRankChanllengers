using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class CaesarCipherEncryptor
    {
        public static string CaesarCypherEncryptor1(string str, int key)
        {
            // Write your code here.
            int size = 26;
            var output = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                var encodedChar = (((str[i] - 97) + key) % size) + 97;
                output.Append((char)encodedChar);
            }

            return output.ToString();
        }

        public static string CaesarCypherEncryptor2(string str, int key)
        {
            // Write your code here.

            char[] letters = new char[str.Length];
            int aPos = 'a';
            for (int i = 0; i < str.Length; i++)
            {
                letters[i] += Convert.ToChar((str[i] + key - aPos) % 26 + aPos);
            }

            return new String(letters);
        }

        public static void Initial(string[] args)
        {
            int key = 5;
            string str = "xyz";

            var output = CaesarCypherEncryptor1(str, key);

            Console.WriteLine("Expected: cde");
            Console.Write($"Actual: { output }");
        }

    }
}
