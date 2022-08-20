using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class IsomorphicStrings
    {
        /*

Input: s = "egg", t = "add"
Output: true

Input: s = "foo", t = "bar"
Output: false

Input: s = "paper", t = "title"
Output: true
         */

        public static bool IsIsomorphicString(string s, string t)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            for(int i = 0; i < s.Length; i++)
            {
                string value = "";
                if(map.TryGetValue(s[i].ToString(), out value))
                {
                    if (value != t[i].ToString()) return false;
                } else
                {
                    var key = map.FirstOrDefault( x => x.Value == t[i].ToString()).Key;

                    if(key != null) return false;
                    map.Add(s[i].ToString(), t[i].ToString());
                }
            }
            return true;
        }

        public static void Initial(string [] args)
        {
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            var result = IsIsomorphicString(s, t);
            
            if (result)
                Console.WriteLine($"{s} and {t} are isomorphic");
            else
                Console.WriteLine($"{s} and {t} are not isomorphic");

        }
    }
}
