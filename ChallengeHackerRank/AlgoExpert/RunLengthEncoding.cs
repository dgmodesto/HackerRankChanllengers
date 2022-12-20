using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class RunLengthEncoding
    {

        public static string RunLengthEncoding1(string str)
        {
            // Write your code here.
            string output = "";
            int count = 0;
            int idx = 0;
            while (idx < str.Length)
            {
                var bef = str[idx];
                for (int j = idx; j < str.Length; j++)
                {
                    var curr = str[j];
                    if (curr == bef)
                        count++;
                    else
                        break;

                    idx++;
                    if (count == 9)
                    {
                        break;
                    }

                }
                output += count.ToString() + bef.ToString();
                count = 0;
            }

            return output;
        }

        public static void Initial(string [] args)
        {
            string input = "AAAAAAAAAAAAABBCCCCDD";

            string output = RunLengthEncoding1(input);


            Console.WriteLine("Expected: 9A4A2B4C2D");
            Console.Write($"Actual: { output }");
        }
    }
}
