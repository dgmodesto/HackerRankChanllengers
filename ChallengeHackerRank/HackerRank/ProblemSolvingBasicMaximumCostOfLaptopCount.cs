using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class ProblemSolvingBasicMaximumCostOfLaptopCount
    {

        /*
     * Complete the 'maxCost' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY cost
     *  2. STRING_ARRAY labels
     *  3. INTEGER dailyCount
     *  
     *  Description Problem
        2. Maximum cost of Laptop count A company manufactures a fixed number of laptops every day. 
            However, if some defect is encountered during the testing of a laptop, it is labeled as "illegal" and is not counted in the laptop count of the day. 
            Given the cost to manufacture each laptop, its label as "illegal" or "legal", and the number of legal laptops to be manufactured each day, find the maximum cost incurred by the company in a single day in manufacturing all the laptops. 
            Note that if a laptop is labeled as illegal, its manufacturing cost is still incurred by the company, even though it is not included in the laptop count. 
            Also, days are only taken into when the daily laptop count has been completely met. If there are no such days, the answer is 0. 
            For example, let's say there are n = 5 laptops, where cost = [2,5, 3, 11, 1). 
            The labels for these laptops are labels = ["legal", "illegal", "legal", "illegal", "legal"). Finally, the dailyCount = 2, which means that the company needs to manufacture 2 legal laptops each day. 
            The queue of laptops can be more easily viewed as follows: . cost 2, "legal" cost 5, "illegal" cost 3, "legal" cost 11, "illegal" cost 1, "legal" On the first day, the first three laptops are manufactured in order to reach the daily count of 2 legal laptops. 
            The cost incurred on this day is 2 + 5+ 3 = 10. On the second day, the fourth and fifth laptops are manufactured, but because only one of them is legal, the daily count isn't met, so that day is not taken into consideration. Therefore, the maximum cost incurred on a single day is 10. 
            Function Description Complete the function maxCost in the editor below. 
            maxCost has the following parameter(s): 
                int cost[n] an array of integers denoting the cost to manufacture each laptop 
                string labels[n]: an array of strings denoting the label of each laptop ("legal" or "illegal") 
                int dailyCount: the number of legal laptops to be manufactured each day Returns: 
                int: the maximum cost incurred in a single day of laptop manufacturing Constraints • 1sns 105 Os cost[i]
     *  
  Input
5
0
3
2
3
4
5
legal
legal
illegal
legal
legal
1

Output
5
     */

        public static int maxCost(List<int> cost, List<string> labels, int dailyCount)
        {
            int[] b = new int[cost.Count];

            for (int i = 0; i < cost.Count - 1; i++)
                b[i] = labels[i] == ("legal") ? 1 : 0;

            int s = 0, sum = 0, max = 0;
            for (int i = 0; i < cost.Count - 1; i++)
            {
                s += b[i];
                sum += cost[i];
                if (s == dailyCount)
                {
                    max = (sum > max) ? sum : max;
                    s = sum = 0;
                }
            }

            return max;
        }


        public static void Initial(string[] args)
        {
            int costCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> cost = new List<int>();

            for (int i = 0; i < costCount; i++)
            {
                int costItem = Convert.ToInt32(Console.ReadLine().Trim());
                cost.Add(costItem);
            }

            int labelsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> labels = new List<string>();

            for (int i = 0; i < labelsCount; i++)
            {
                string labelsItem = Console.ReadLine();
                labels.Add(labelsItem);
            }

            int dailyCount = Convert.ToInt32(Console.ReadLine().Trim());

            int result = maxCost(cost, labels, dailyCount);

            Console.WriteLine(result);

        }
    }
}
