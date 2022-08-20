using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class JimAndOrders
    {
        /*
         * https://www.hackerrank.com/challenges/jim-and-the-orders/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign
        * Complete the 'jimOrders' function below.
        *
        * The function is expected to return an INTEGER_ARRAY.
        * The function accepts 2D_INTEGER_ARRAY orders as parameter.
        * 
Input (stdin)
3
1 3
2 3
3 3

Expected Output
1 2 3
        */

        public static List<int> jimOrders(List<List<int>> orders)
                {
                    var dic = new Dictionary<int, int>();

                    for (int i = 0; i < orders.Count; i++)
                    {
                        var cus = orders[i][0];
                        var time = orders[i][1];

                        dic.Add(i + 1, cus + time);
                    }

                    return dic.OrderBy(x => x.Value).Select(x => x.Key).ToList();
                }

        public static void Initial(string [] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> orders = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                orders.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ordersTemp => Convert.ToInt32(ordersTemp)).ToList());
            }

            List<int> result = jimOrders(orders);

            Console.WriteLine(String.Join(" ", result));

        }

    }
}
