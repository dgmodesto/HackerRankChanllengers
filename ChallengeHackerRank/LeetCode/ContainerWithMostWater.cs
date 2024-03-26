using System;

namespace ChallengeHackerRank.LeetCode
{
    public static class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            int left = 0;
            int rigth = height.Length - 1;
            int maxContainer = 0;
            int current;

            while (left < height.Length && rigth >= 0)
            {

                //maxContainer = Math.Max(maxContainer, Math.Min(height[left], height[rigth])*(rigth-left)
                if (height[left] > height[rigth])
                {
                    current = height[rigth] * (rigth - left); ;
                    rigth--;
                }
                else
                {
                    current = height[left] * (rigth - left);
                    left++;
                }

                if (current > maxContainer)
                {
                    maxContainer = current;
                }
            }

            return maxContainer;
        }

        public static void Initial(string[] args)
        {
            int[] input = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int output = 49;

            var result = MaxArea(input);

            Console.WriteLine("Expected : {0} ", output);
            Console.WriteLine("Result :{0} ", result);
        }
    }
}
