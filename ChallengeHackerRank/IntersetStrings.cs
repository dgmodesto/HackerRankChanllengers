using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class IntersetStrings
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums1.Count(); i++)
            {
                var curr = nums1[i];
                for (int j = 0; j < nums2.Count(); j++)
                {
                    var currAux = nums2[j];
                    if (curr == currAux)
                    {
                        var key = j;
                        if (!map.ContainsKey(key))
                        {
                            map.Add(key, curr);
                            break;
                        }
                    }
                }
            }

            return map.Values.ToArray();
        }

        public static void Initial(string[] args)
        {
            int[] nums1 = new int[] {1, 2, 2, 1};
            int[] nums2 = new int[] { 2, 2 };
            


            var result = Intersect(nums1, nums2);
            Console.Write($"[ ");

           result.ToList().ForEach(x =>
                Console.Write($"{ x } ,")
            );
            Console.Write($"]");

        }
    }
}
