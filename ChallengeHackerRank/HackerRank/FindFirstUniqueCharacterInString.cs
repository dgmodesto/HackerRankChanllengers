using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static  class FindFirstUniqueCharacterInString
    {
        /*
         Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.

Example 1:
Input: s = "leetcode"
Output: 0

Example 2:
Input: s = "loveleetcode"
Output: 2

Example 3:
Input: s = "aabb"
Output: -1
         
         */

        public static int FirstUniqChar(string s)
        {

            var hasRepeat = false;

            for (int i = 0; i < s.Length; i++)
            {
                var curr = s[i].ToString();

                for (int j = 0; j < s.Length; j++)
                {
                    var currAux = s[j].ToString();


                    if (i == j) continue;

                    if (curr == currAux)
                    {
                        hasRepeat = true;
                        break;
                    }
                }

                if (!hasRepeat)
                    return i;

                hasRepeat = false;
            }

            return -1;
        }

        public static void Initial(string[] args)
        {
            var s = "loveleetcode";
            

            var result = FirstUniqChar(s);
            Console.Write(result);

        }

    }
}
