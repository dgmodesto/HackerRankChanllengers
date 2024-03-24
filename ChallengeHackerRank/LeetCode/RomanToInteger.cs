using System;

namespace ChallengeHackerRank.LeetCode
{
    public static class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            int value = 0;

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'M':
                        value += 1000;
                        break;
                    case 'D':
                        value += 500;
                        break;
                    case 'C':
                        if (i < s.Length - 1)
                        {
                            if (s[i + 1] == 'M')
                            {
                                value += 900;
                                i++;
                            }
                            else if (s[i + 1] == 'D')
                            {
                                value += 400;
                                i++;
                            }
                            else
                            {
                                value += 100;
                            }
                        }
                        else
                        {
                            value += 100;
                        }
                        break;
                    case 'L':
                        value += 50;
                        break;
                    case 'X':
                        if (i < s.Length - 1)
                        {
                            if (s[i + 1] == 'C')
                            {
                                value += 90;
                                i++;
                            }
                            else if (s[i + 1] == 'L')
                            {
                                value += 40;
                                i++;
                            }
                            else
                            {
                                value += 10;
                            }
                        }
                        else
                        {
                            value += 10;
                        }
                        break;
                    case 'V':
                        value += 5;
                        break;
                    case 'I':
                        if (i < s.Length - 1)
                        {
                            if (s[i + 1] == 'X')
                            {
                                value += 9;
                                i++;
                            }
                            else if (s[i + 1] == 'V')
                            {
                                value += 4;
                                i++;
                            }
                            else
                            {
                                value += 1;
                            }
                        }
                        else
                        {
                            value += 1;
                        }
                        break;
                }
            }
            return value;
        }


        public static void Initial(string[] args)
        {
            string input = "MCMXCIV";
            int output = 1994;

            var result = RomanToInt(input);

            Console.WriteLine("Expected : {0} ", output);
            Console.WriteLine("Result :{0} ", result);
        }
    }
}
