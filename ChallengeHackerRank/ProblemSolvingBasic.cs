using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class ProblemSolvingBasic
    {
        /*
 * Complete the 'decryptPassword' function below.
 *
 * The function is expected to return a STRING.
 * The function accepts STRING s as parameter.
 */

        public static string decryptPassword(string s)
        {
            string result = string.Empty;

            var bStringBuilder = new StringBuilder(s);
            for (int i = 0; i < bStringBuilder.Length - 1; i++)
            {
                var ch = bStringBuilder[i];
                var chNext = bStringBuilder[i + 1];

                if (Char.IsDigit(ch))
                {
                    int idx = bStringBuilder.ToString().LastIndexOf('0');

                    if (idx < 0) continue;

                    bStringBuilder.Remove(idx, 1);
                    bStringBuilder.Insert(idx, ch);
                    bStringBuilder.Remove(i, 1);
                    i--;

                }
                else if (Char.IsUpper(ch) && Char.IsLower(chNext))
                {
                    bStringBuilder.Remove(i, 1);
                    bStringBuilder.Insert(i, chNext);
                    bStringBuilder.Remove(i + 1, 1);
                    bStringBuilder.Insert(i + 1, ch);
                    bStringBuilder.Remove(i + 2, 1);
                    i++;
                } else
                {
                    i++;
                }
            }

            // lBgKu1


            result = bStringBuilder.ToString();

            return result;
        }

        public static void Initial(string[] args)
        {

            string s = Console.ReadLine();

            string result = decryptPassword(s);

            Console.WriteLine(result);

        }
    }
}
