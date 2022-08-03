using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class StringMakingAnagram
    {

        /*
         * 
         * https://www.hackerrank.com/challenges/ctci-making-anagrams/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
         * 
 * Complete the 'makeAnagram' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts following parameters:
 *  1. STRING a
 *  2. STRING b
 */

        public static int makeAnagram(string a, string b)
        {
            //solution 1
            var listA = new List<char>(a);
            var listB = new List<char>(b);
            int total = listA.Count + listB.Count;
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(listA.Contains(listB[i]))
                {
                    count++;
                    listB.Remove(listA[i]);
                }
            }
            return total - (count  * 2);


        }


        public static int makeAnagram2(string a, string b)
        {

            //solution 2
            List<int> list = new List<int>(new int[26]);
            int total = 0;
            foreach (char item in a) { list[item - 'a']++; }
            foreach (char item in b) { list[item - 'a']--; }
            foreach (int item in list) { total += Math.Abs(item); }
            return total;
        }


        public static void Initial(string [] args)
        {
            string a = Console.ReadLine();

            string b = Console.ReadLine();

            int res = makeAnagram2(a, b);

            Console.WriteLine(res);
        }
    }
}
