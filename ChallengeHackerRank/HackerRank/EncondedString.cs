using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public class EncondedString
    {

        static string encode(string input)
        {

            var sb = new StringBuilder();

            if (string.IsNullOrEmpty(input))
                return string.Empty;

            var inputChar = input.ToCharArray();

            char prevChar = '0';
            int counter = 0;

            foreach (var c in inputChar)
            {
                if (c == prevChar)
                    counter++;
                else
                {
                    if (prevChar != '0')
                        sb.Append(counter).Append(prevChar);

                    prevChar = c;
                    counter = 1;
                }
            }

            sb.Append(counter).Append(prevChar);
            return sb.ToString();
        }

        public static void Initial(string[] args)
        {
            var input = Console.ReadLine();

            var result = encode(input);

            Console.WriteLine(result);
        }
    }
}
