using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class ArrayOfProducts
    {

        public static int[] ArrayOfProducts1(int[] array)
        {
            // Complexity O(N²) | Space O(N)
            int[] arrResult = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                var product = 1;
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j)
                        product *= array[j];
                }
                arrResult[i] = product;
            }
            return arrResult;
        }

        public static int[] ArrayOfProducts2(int[] array)
        {
            // Complexity O(N) | Space O(N)
            
            int[] products = new int[array.Length];
            int[] leftProd = new int[array.Length];
            int[] rightProd = new int[array.Length];

            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                leftProd[i] = product;
                product *= array[i];
            }

            product = 1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                rightProd[i] = product;
                product *= array[i];
            }

            for (int i = 0; i < array.Length; i++)
                products[i] = leftProd[i] * rightProd[i];

            return products;
        }

        public static int[] ArrayOfProducts3(int[] array)
        {
            // Complexity O(N) | Space O(N)
            int[] products = new int[array.Length];

            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                products[i] = product;
                product *= array[i];
            }

            product = 1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                products[i] *= product;
                product *= array[i];
            }

            return products;
        }


        public static void Initial(string [] args)
        {
            int[] input = new int[] { 5, 1, 4, 2 };
            var result = ArrayOfProducts2(input);

            Console.WriteLine($"Expected: 8, 40, 10, 20");
            Console.Write($"Actual: ");
            Array.ForEach(result, Console.Write);
        }
    }
}
