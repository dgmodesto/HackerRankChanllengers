using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class MinIndexSumOfTwoLists
    {
        /*
         Suppose Andy and Doris want to choose a restaurant for dinner, and they both have a list of favorite restaurants represented by strings.
         You need to help them find out their common interest with the least list index sum. If there is a choice tie between answers, output all of them with no order requirement. You could assume there always exists an answer.

CASE 1
Input:
["Shogun","Piatti","Tapioca Express","Burger King","KFC"]
["Piatti","The Grill at Torrey Pines","Hungry Hunter Steakhouse","Shogun"]

Output:
["Piatti"]       
        

         */

        public static string[] FindRestaurant(string[] list1, string[] list2)
        {
            var result = new List<string>();
            var indexSum = int.MaxValue;
            for (int i = 0; i < list1.Length; i++)
            {
                var curr = list1[i];
                for (int j = 0; j < list2.Length; j++)
                {
                    var currAux = list2[j];
                    var currIndexSum = (i + j);
              
                    if (curr == currAux)
                    {
                        if (currIndexSum < indexSum)
                        {
                            result.Clear();
                            result.Add(curr);
                            indexSum = currIndexSum;
                        } else if (currIndexSum == indexSum)
                        {
                            result.Add(curr);
                        }

                    }
                }
            }

            return result.ToArray();
        }



        public static void Initial(string[] args)
        {
            var list1 = new string[] { "Shogun", "Piatti", "Tapioca Express", "Burger King", "KFC" };
            var list2 = new string[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" };

            var result = FindRestaurant(list1, list2);

            foreach (var item in result)
            {
                Console.Write(item + ", ");
            }

        }

    }
}
