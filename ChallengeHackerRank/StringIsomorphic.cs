using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class StringIsomorphic
    {

        /*
Example 1:
Input: s = "egg", t = "add"
Output: true

Example 2:
Input: s = "foo", t = "bar"
Output: false

Example 3:
Input: s = "paper", t = "title"
Output: true
         */

        public static bool IsIsomorphic(string s, string t)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            for (int i = 0; i < s.Length; i++)
            {
                string value = "";
                if (map.TryGetValue(s[i].ToString(), out value))
                {
                    if (value != t[i].ToString()) return false;
                }
                else
                {
                    var myKey = map.FirstOrDefault(x => x.Value == t[i].ToString()).Key;
                    if (myKey != null) return false;

                    map.Add(s[i].ToString(), t[i].ToString());
                }
            }
            return true;
        }


        public static void Initial(string [] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();

            var result = IsIsomorphic(s, t);

            Console.WriteLine(result);
        }
    }
}
