using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class JewelsAndStones
    {
        /*
         
CASE 1        
Input
"aA"
"aAAbbb"

Output
3

CASE 2        
Input
"z"
"ZZZ"

Output
0

         
         */

        public static int NumJewelsInStones(string jewels, string stones)
        {
            Dictionary<string, int> stonesDict = new Dictionary<string, int>();

            foreach(char jewel in jewels)
            {
                stonesDict.Add(jewel.ToString(), 0);
            }

            int count = 0;

            foreach(char stone in stones)
            {
                if(stonesDict.ContainsKey(stone.ToString()))
                {
                    count++;
                }
            }

            return count;
        }

        public static void Initial(string [] args)
        {
            string jewels = "Aa";
            string stones = "aAAbbb";

            Console.WriteLine(NumJewelsInStones(jewels, stones));

        }
    }
}
