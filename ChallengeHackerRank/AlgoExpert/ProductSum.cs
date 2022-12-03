using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class ProductSum
    {
        public static int ProductSum1(List<object> array, int level = 1)
        {
            // Complexity O(N) | Space O(S) = S represent each special array
            int sum = 0;

            int i = 0;
            while (i < array.Count)
            {
                sum += array[i] is IList<object> ?
                    ProductSum1(array[i] as List<object>, level + 1) :
                    (int)array[i];
                i++;
            }
            return sum * level;
        }

        public static int ProductSum2(List<object> array)
        {
            // Complexity O(N) | Space O(S) - S represent each special array
            int result = ProductSumRecur(array);
            return result;
        }

        private static int ProductSumRecur(object array, int sumValue = 0, int level = 2)
        {
            int i = 0;
            List<object> arr = (List<object>)array;
            while (i < arr.Count)
            {
                var tp = arr[i].GetType();
                if (tp == typeof(int))
                {
                    sumValue += (int)arr[i];
                }
                else
                {
                    sumValue += (level * ProductSumRecur(arr[i], 0, level + 1));
                }
                i++;
            }
            return sumValue;
        }


        public static void Initial(string[] args)
        {
            // [5, 2, [7, -1], 3, [6, [-13, 8], 4]]
            List<object> list = new List<object>();

            list.Add(5);
            list.Add(2);
            list.Add(new List<object>() { 7, -1});
            list.Add(3);
            list.Add(new List<object>() { 
                6,
                new List<object>() { -13, 8},
                4
            });

            var result = ProductSum1(list);


            Console.WriteLine($"Expected: 12 ");
            Console.WriteLine($"Actual: { result }");
        }
    }
}
