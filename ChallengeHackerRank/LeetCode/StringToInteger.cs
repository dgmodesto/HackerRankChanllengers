using System;

namespace ChallengeHackerRank.LeetCode
{
    public static class StringToInteger
    {
        public static int MyAtoi(string s)
        {

            if (string.IsNullOrEmpty(s)) return 0;

            s = s.Trim();
            string res = "";
            bool isNegative = false;
            string op = "";
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (!"1234567890-+.".Contains(c.ToString()))
                {
                    if (string.IsNullOrEmpty(res))
                        return 0;
                    if (!string.IsNullOrEmpty(res))
                        break;
                    continue;
                }
                else if (".".Contains(c.ToString()))
                {
                    if (string.IsNullOrEmpty(res))
                        return 0;
                    break;
                }
                else if ("-".Contains(c.ToString()))
                {
                    if (i < s.Length - 2 && "-+".Contains(s[i + 1].ToString())) return 0;

                    if (op.Contains("-") || !string.IsNullOrEmpty(res)) break;
                    isNegative = true;
                    op += c.ToString();
                }
                else if ("+".Contains(c.ToString()))
                {
                    if (i < s.Length - 2 && "-+".Contains(s[i + 1].ToString())) return 0;
                    if (op.Contains("+") || !string.IsNullOrEmpty(res)) break;
                    isNegative = false;
                    op += c.ToString();
                }
                else
                {
                    res += c.ToString();
                }
            }
            if (string.IsNullOrEmpty(res)) return 0;

            var isIntNumeric = int.TryParse(res, out int resInt);

            if (!isIntNumeric)
            {
                return isNegative ? int.MinValue : int.MaxValue;
            }

            return isNegative ? resInt * -1 : resInt;
        }

        public static void Initial(string[] args)
        {
            string input = "4193 with words";
            string output = "4193";

            var result = MyAtoi(input);
            Console.WriteLine("Expected : ", output);
            Console.WriteLine("Result : ", result);
        }
    }
}
