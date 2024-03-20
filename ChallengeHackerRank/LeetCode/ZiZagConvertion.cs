using System;

namespace ChallengeHackerRank.LeetCode
{
    public static class ZiZagConvertion
    {

        /*
         https://leetcode.com/problems/zigzag-conversion/
         */

        public static string Convert(string s, int numRows)
        {
            int size = s.Length;
            string[] rows = new string[numRows];
            bool isDownDiretcion = true;

            int row = 0;
            for (int i = 0; i < size; i++)
            {
                rows[row] += s[i].ToString();

                if (numRows > 1)
                {
                    if (isDownDiretcion)
                    {
                        row++;
                    }
                    else
                    {
                        row--;
                    }
                }

                isDownDiretcion = row == numRows - 1 ? false : row == 0 ? true : isDownDiretcion;
            }

            string convertStg = "";
            for (int i = 0; i < rows.Length; i++)
            {
                convertStg += rows[i];
            }

            return convertStg;
        }

        public static void Initial(string[] args)
        {
            string input = "PAYPALISHIRING";
            int numRows = 4;
            string output = "PINALSIGYAHRPI";

            var result = Convert(input, numRows);
            Console.WriteLine("Expected : ", output);
            Console.WriteLine("Result : ", result);
        }

    }
}
