using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class MicrosoftCaseTwo
    {
        public static int solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            S =  new StringBuilder(1 * 400000).Insert(0, "1", 400000).ToString();
            var result = 0;

            var conv = Convert.ToInt64(S);
            int V = 0;

            

            for(double i = conv; i > 0; i--)
            {
                if(i % 2 == 0)
                {
                    i = i / 2 + 1;
                }
                V++;
            }

            return V;
        }

        public static void Initial(string[] args)
        {

            solution(string.Empty);
        }
    }
}
