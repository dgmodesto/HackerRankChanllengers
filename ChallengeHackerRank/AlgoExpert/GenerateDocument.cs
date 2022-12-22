using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class GenerateDocument
    {
        public static bool GenerateDocument1(string characters, string document)
        {
            // Complextiy O(N+M+NM) | Space O(2N)

            bool output = true;
            if (document == "") return true;
            if (document.Length > characters.Length) return false;

            var mapDoc = new Dictionary<char, int>();
            var mapChar = new Dictionary<char, int>();
            foreach (char ch in document)
            {
                if (!mapDoc.ContainsKey(ch))
                {
                    mapDoc.Add(ch, 1);
                }
                else
                {
                    mapDoc[ch] += 1;
                }
            }

            foreach (char ch in characters)
            {
                if (!mapChar.ContainsKey(ch))
                {
                    mapChar.Add(ch, 1);
                }
                else
                {
                    mapChar[ch] += 1;
                }
            }

            foreach (var itemDoc in mapDoc)
            {
                bool match = false;
                foreach (var itemChar in mapChar)
                {
                    if (itemChar.Key == itemDoc.Key)
                    {
                        match = true;
                        if (itemChar.Value < itemDoc.Value)
                            return false;
                    }
                }
                if (match == false)
                    return false;
            }


            return output;
        }

        public static bool GenerateDocument2(string characters, string document)
        {
            // Complextiy O(N+M) | Space O(1)
            // ASCII is a code of 7 bits with 128 characters (2^7)

            var mapChar = new int[128];

            foreach (var c in characters)
                mapChar[(int)c]++;

            foreach (var c in document)
            {
                mapChar[(int)c]--;
                if (mapChar[(int)c] < 0)
                    return false;
            }

            return true;
        }

        public static bool GenerateDocument3(string characters, string document)
        {
            // Complexity O(N) | Space O(1)

            foreach (char c in document)
            {
                if (characters.IndexOf(c) == -1)
                    return false;

                characters = characters.Remove(characters.IndexOf(c), 1);
            }

            return true;
        }

        public static void Initial(string [] args)
        {
            string characters = "Bste!hetsi ogEAxpelrt x ";
            string document = "AlgoExpert is the Best!";

            var output = GenerateDocument1(characters, document);

            Console.WriteLine("Expected: True");
            Console.Write($"Actual: { output }");
        }
    }
}
