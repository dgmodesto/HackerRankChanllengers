using System;

namespace ChallengeHackerRank.LeetCode
{
    public static class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            string strX = x.ToString();
            bool isOdd = strX.Length % 2 == 0;

            var mid = (int)strX.Length / 2;
            if (isOdd)
            {
                return IsPalindrome(strX, mid - 1, mid);
            }
            else
            {
                return IsPalindrome(strX, mid, mid);
            }
            return false;

        }

        public static bool IsPalindrome(string strX, int left, int rigth)
        {
            while (left >= 0 && rigth < strX.Length)
            {
                if (strX[left] != strX[rigth])
                {
                    return false;
                }
                left--;
                rigth++;
            }
            return true;
        }

        public static void Initial(string[] args)
        {
            int input = 4193;
            bool output = true;

            var result = IsPalindrome(input);
            Console.WriteLine("Expected : ", output);
            Console.WriteLine("Result : ", result);
        }
    }
}
