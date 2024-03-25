using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.LeetCode
{
    public static class IntegerToRoman
    {
        public static string IntToRoman(int num)
        {
            StringBuilder roman = new StringBuilder();
            Dictionary<int, string> dic = new Dictionary<int, string> {
            { 1, "I" },
            { 5, "V" },
            { 10, "X" },
            { 50, "L" },
            { 100, "C" },
            { 500, "D" },
            { 1000, "M" }
        };
            int calc = 0;

            if (num >= 1000)
            {
                calc = num / 1000;
                num -= 1000 * calc;
                for (int i = 0; i < calc; i++)
                {
                    roman.Append(dic[1000]);
                }
            }

            if (num >= 900 && num < 1000)
            {
                num -= 900;
                roman.Append(dic[100]);
                roman.Append(dic[1000]);
            }

            if (num >= 500)
            {
                num -= 500;
                roman.Append(dic[500]);
            }

            if (num >= 400)
            {
                num -= 400;
                roman.Append(dic[100]);
                roman.Append(dic[500]);
            }

            if (num >= 100)
            {
                calc = num / 100;
                num -= 100 * calc;
                for (int i = 0; i < calc; i++)
                {
                    roman.Append(dic[100]);
                }
            }

            if (num >= 90 && num < 100)
            {
                num -= 90;
                roman.Append(dic[10]);
                roman.Append(dic[100]);
            }


            if (num >= 50)
            {
                num -= 50;
                roman.Append(dic[50]);
            }

            if (num >= 40)
            {
                num -= 40;
                roman.Append(dic[10]);
                roman.Append(dic[50]);
            }

            if (num >= 10)
            {
                calc = num / 10;
                num -= 10 * calc;
                for (int i = 0; i < calc; i++)
                {
                    roman.Append(dic[10]);
                }
            }

            if (num >= 9 && num < 10)
            {
                num -= 9;
                roman.Append(dic[1]);
                roman.Append(dic[10]);
            }


            if (num >= 5)
            {
                num -= 5;
                roman.Append(dic[5]);
            }

            if (num == 4)
            {
                num -= 4;
                roman.Append(dic[1]);
                roman.Append(dic[5]);
            }

            if (num >= 1)
            {
                calc = num / 1;
                num -= 1 * calc;
                for (int i = 0; i < calc; i++)
                {
                    roman.Append(dic[1]);
                }
            }

            return roman.ToString();
        }

        public static void Initial(string[] args)
        {
            int input = 1994;
            string output = "MCMXCIV";

            var result = IntToRoman(input);

            Console.WriteLine("Expected : {0} ", output);
            Console.WriteLine("Result :{0} ", result);
        }
    }

}
