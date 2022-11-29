using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class TandemBycycle
    {
        public static int TandemBicycle1(int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest)
        {
            // Write your code here.

            int totalSpeed = 0;
            Array.Sort(redShirtSpeeds);

            if (fastest)
                blueShirtSpeeds = blueShirtSpeeds.ToList().OrderByDescending(x => x).ToArray();
            else
                Array.Sort(blueShirtSpeeds);

            for (int i = 0; i < redShirtSpeeds.Length; i++)
            {
                totalSpeed += Math.Max(redShirtSpeeds[i], blueShirtSpeeds[i]);

            }


            return totalSpeed;
        }

        public static int TandemBicycle2(int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest)
        {
            // Write your code here.
            int totalSpeed = 0;
            Array.Sort(redShirtSpeeds);
            Array.Sort(blueShirtSpeeds);

            if (fastest)
                Array.Reverse(blueShirtSpeeds);

            for (int i = 0; i < redShirtSpeeds.Length; i++)
            {
                totalSpeed += Math.Max(redShirtSpeeds[i], blueShirtSpeeds[i]);

            }


            return totalSpeed;
        }

        public static void Initial(string [] args)
        {
            int[] blueShirtSpeeds = new int[] { 3, 6, 7, 2, 1 };
            int[] redShirtSpeeds = new int[] { 5, 5, 3, 9, 2 };
            bool fastest = true;

            int result = TandemBicycle1(redShirtSpeeds, blueShirtSpeeds, fastest);

            Console.WriteLine("Expected: 32");
            Console.WriteLine($"Actual: { result }");

        }
    }
}
