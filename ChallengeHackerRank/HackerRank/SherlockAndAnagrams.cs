using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public class SherlockAndAnagrams
    {
        /*
        - Two strings are anagrams of each other if the letters of one string can be rearranged to form the other string.
        - Given a string find the number of pairs of substring of the string that are anagrams of each other
        - Example
            - s = mom
            - The list of all anagrammatic pairs is [m,m], [mo, om] at positions [[0],[2]], [[0,1], [1,2]]
            - result is 2
        - Input
2
abba
abcd
        - Output
4
0
        - Input
2
ifailuhkqq
kkkk
        - Output
3
10

        */

        public static void Initial(string [] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = SherlockAndAnagram(s);

                Console.WriteLine(result);
            }
        }

        private static int SherlockAndAnagram(string s)
        {
            var match = 0;
            var dict = new Dictionary<string, int>();
            for (int len = 1; len <= s.Length-1; len++)
            {
                for (int j = 0; j <= s.Length - len; j++)
                {
                    var norm = new string(s.Substring(j, len).OrderBy(c => c).ToArray());
                    if (dict.ContainsKey(norm)) {
                        match += dict[norm];
                        dict[norm] += 1;

                    }
                    else
                    {
                        dict[norm] = 1;
                    }
                }
            }
            return match;

         
        }
    }
}
