using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class ContainsDuplicateII
    {

        /*
        Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.

        Example 1:
        Input: nums = [1,2,3,1], k = 3
        Output: true

        Example 2:
        Input: nums = [1,0,1,1], k = 1
        Output: true

        Example 3:
        Input: nums = [1,2,3,1,2,3], k = 2
        Output: false


        Example 4:
        Input: nums = [1,0,1,1], k = 1
        Output: true
         */

        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Count(); i++)
            {
                var currI = nums[i];
                for (int j = i + 1; j < nums.Count(); j++)
                {
                    var currJ = nums[j];
                    if (currI == currJ && Math.Abs(i - j) <= k)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool ContainsNearbyDuplicateOptimized(int[] nums, int k)
        {



            var map = new Hashtable();
            

            for (int i = 0; i < nums.Count(); i++)
            {
               if(map.ContainsKey(nums[i]))
                {
                    int y = (int)map[nums[i]];
                    int x = Math.Abs(i - y);

                    if (x < k)
                        return true;
                } else
                {
                    map.Add(nums[i], i);
                }

            }

            return false;
        }

        public static void Initial(string[] args)
        {
            int[] nums1 = new int[] { 1, 0, 1, 1 };
            int k = 1;

            var result = ContainsNearbyDuplicateOptimized(nums1, k);
            Console.Write($" { result } ");


        }

    }
}
