using System.Collections.Generic;
using System;

namespace ChallengeHackerRank.HackerRank
{
    public static class StrangeCounter
    {
        //https://www.hackerrank.com/challenges/strange-code/problem?isFullScreen=true

        public static long strangeCounter(long t)
        {
            int lastTime = 3;
            int value = 3;
            while (t > lastTime)
            {
                value *= 2;
                lastTime += value;
            }

            return lastTime - t + 1;
        }

        public static void Initial(string[] args)
        {
            int input = 10;
            int output = 12;
            
            var result = strangeCounter(input);

            Console.WriteLine("Expected : {0} ", output);
            Console.WriteLine("Result :{0} ", result);
        }

    }
}
