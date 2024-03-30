using System;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank.LeetCode
{
    public static class LongestCommonPrefix
    {
        public static string LongestCommonPref(string[] ss)
        {
            StringBuilder sb = new StringBuilder();
            string shortest = ss.OrderBy(s => s.Length).First();

            foreach(var(c,i) in shortest.Select((c, i) => (c, i)))
            {
                if (ss.Any(s => s[i] != c)) break;
                sb.Append(c);
            }

            return sb.ToString();
        }
            
        public static void Initial(string[] args)
        {
            string[] input = new string[] { "flower", "flow", "flight" };
            string output = "fl";

            var result = LongestCommonPref(input);

            Console.WriteLine("Expected : {0} ", output);
            Console.WriteLine("Result :{0} ", result);
        }
    }
}
