using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class MicrosoftCaseOne
    {

        public static int solution(string S)
        {
            S = "bbbaaabbb";


            var maxValue = 0;
            var ocurr = new List<string>();
            var before = "";
            for (int i = 0; i < S.Length; i++)
            {

                if (i == 1)
                    before = S[i - 1].ToString();


                var current = S[i].ToString();

                if (before.Contains(current))
                {
                    if(ocurr.Count > 0)
                    {
                        var lastOcurrence = ocurr[ocurr.Count - 1];

                        if (lastOcurrence != before)
                            ocurr.Add(before);

                        ocurr.RemoveAt(ocurr.Count - 1);
                    }
                    
                    ocurr.Add(before + current);
                    var idx = ocurr.IndexOf(before + current);
                    if(ocurr[idx].Length > maxValue)
                    {
                        maxValue = ocurr[idx].Length;
                    }

                    before = before + current;
                }
                else
                {
                    ocurr.Add(current);
                    before = current;
                }
            }

            var count = 0;
            for(int i = 0; i < ocurr.Count; i++ )
            {
                if(ocurr[i].Length < maxValue)
                {
                    count += maxValue - ocurr[i].Length;
                }
            }

            return count;

        }


        public static void Initial(string[] args)
        {

            //int[] A = new int[] { 1, 3, 6, 4, 1, 2 }; // 5
            //int[] A = new int[] { 1, 2, 3 }; // 4
            //int[] A = new int[] { -1, -3 }; // 1

            var s = "babaa";

            solution(s);
        }
    }
}
