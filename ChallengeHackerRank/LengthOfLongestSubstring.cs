using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{

    /*
Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.

Example 2:
Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.

Example 3:
Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.

Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
     
     */
    public static class LengthOfLongestSubstring
    {
        public static int GetLengthOfLongestSubstring(string s)
        {
            
            int result = 0;
            var queue = new Queue<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!queue.Contains(s[i]))
                {
                    queue.Enqueue(s[i]);

                }
                else
                {
                    while(true)
                    {
                        var element = queue.FirstOrDefault();
                        if (element == s[i])
                        {
                            queue.Dequeue();
                            break;
                        } else 
                            queue.Dequeue();
                    }

                    queue.Enqueue(s[i]);
                }
                result = result > queue.Count ? result : queue.Count;
            }
            return result == 0 ? queue.Count : result;
        }


        public static void Initial(string[] args)
        {
            string input = "jbpnbwwd";

            var result = GetLengthOfLongestSubstring(input);
            Console.WriteLine(result);
        }
    }
}
