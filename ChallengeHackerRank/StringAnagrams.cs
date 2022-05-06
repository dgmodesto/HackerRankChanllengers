using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class StringAnagrams
    {
        /*
CASE: 1
Input:
nameless
salesman

Output
nameless and salesman are not anagrams

CASE 2:
Input:
danger
garden

Output
danger and gardem are anagrams

         */

        public static bool AreAnagrams(string s1, string s2)
        {
            /*O(n)*/

            if(s1.Length != s2.Length) return false;

            Hashtable freq1 = new Hashtable();
            Hashtable freq2 = new Hashtable();

            foreach(var ch in s1)
            {
                if (freq1.ContainsKey(ch))
                    freq1[ch] = (int)freq1[ch] + 1;
                else
                    freq1[ch] = 1;
            }

            foreach (var ch in s2)
            {
                if (freq2.ContainsKey(ch))
                    freq2[ch] = (int)freq2[ch] + 1;
                else
                    freq2[ch] = 1;
            }

            foreach(var key in freq1.Keys)
            {
                if(!freq2.ContainsKey(key) || (int)freq1[key] != (int)freq2[key]) 
                    return false; 
            }

            return true;
        }

        public static bool AreAnagramOptmized(string s1, string s2)
        {
            /*O(n log n) */

            if(s1.Length !=s2.Length) return false;

            var aS1 = s1.ToCharArray();
            var aS2 = s2.ToCharArray();
            Array.Sort(aS1);
            Array.Sort(aS2);

            s1 = String.Join("", aS1);
            s2 = String.Join("", aS2);

            return s1 == s2;
        }

        public static void Initial(string [] args)
        {
            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();

            var result = AreAnagramOptmized(s1, s2);

            if (result)
                Console.WriteLine($"{s1} and {s2} are anagrams");
            else
                Console.WriteLine($"{s1} and {s2} are not anagrams");

        }
    }
}
