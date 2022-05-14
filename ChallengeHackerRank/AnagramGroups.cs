using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class AnagramGroups
    {
        /*
         * Given an array of string sstrs, group the angrams together. You can return the answer in any order.
         * An Anagram is a word or phrase formed by rearragin the letters of a different word or phrase typically using all the original letters exctly once.
         
Example 1:
Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

Example 2:
Input: strs = [""]
Output: [[""]]

Example 3:
Input: strs = ["a"]
Output: [["a"]]   
     
         
         */

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dic = new Dictionary<string, List<string>>();

            foreach (var s in strs)
            {
                var key = String.Concat(s.OrderBy(c => c));

                if (!dic.ContainsKey(key))
                {
                    dic.Add(key, new List<string>());
                }

                dic[key].Add(s);
            }

            return dic.Values.ToArray();
        }

        public static void Initial(string[] args)
        {
            string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var result = GroupAnagrams(strs);

            foreach (var str in result)
                Console.Write($" [{ String.Join(", ", str.ToArray()) }], ");
        }
    }
}
