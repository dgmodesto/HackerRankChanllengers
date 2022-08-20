using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class CaesarCipher
    {
        /*
         https://www.hackerrank.com/challenges/one-week-preparation-kit-caesar-cipher-1/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-three
         * 
 * Complete the 'caesarCipher' function below.
 *
 * The function is expected to return a STRING.
 * The function accepts following parameters:
 *  1. STRING s
 *  2. INTEGER k
 *  
INPUT
11
middle-Outz
2

OUTPUT
okffng-Qwvb

 */

        public static string caesarCipherOptmized(string s, int k)
        {
            string cipher = "";

            foreach (char c in s)
            {
                if (!char.IsLetter(c))
                {
                    cipher += c;
                }
                else
                {
                    char letter = char.IsUpper(c) ? 'A' : 'a';
                    cipher += Convert.ToChar((c + k - letter) % 26 + letter);
                }
            }
            return cipher;
        }

        public static string caesarCipher(string s, int k)
        {
            var list = new List<char>();

            char chAux = 'a';
            foreach (char ch in s)
            {
                if (Char.IsPunctuation(ch) || char.IsNumber(ch) || Char.IsSymbol(ch))
                {
                    list.Add(ch);
                    continue;
                }
                else  if (char.IsUpper(ch))
                {
                    chAux = Convert.ToChar(
                                         Convert.ToInt32(
                                             Convert.ToChar(ch) + k - 65) % 26 + 65);
                } else
                {
                    chAux = Convert.ToChar(
                                    Convert.ToInt32(
                                        Convert.ToChar(ch) + k - 97) % 26 + 97);
                }
                list.Add(chAux);
            }
            var result = new string(list.ToArray());
            return result;
        }


        public static void Initial(string [] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string s = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string result = caesarCipher(s, k);

            Console.WriteLine(result);

        }
    }
}
