using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class NonConstructibleChange
    {
        public static int NonConstructibleChange1(int[] coins)
        {
            // Write your code here.
            Array.Sort(coins);
            int changeAmmount = 1;
            foreach (int coin in coins)
            {
                if (coin > changeAmmount)
                    return changeAmmount;
                changeAmmount += coin;
            }
            return changeAmmount;
        }

        public static int NonConstructibleChange2(int[] coins)
        {
            // Write your code here.
            // Complexity O(n) | Space O(1)

            Array.Sort(coins);
            int currentAmmount = 1;
            for (int i = 0; i < coins.Length; i++)
            {
                if (coins[i] > currentAmmount)
                    return currentAmmount;
                currentAmmount += coins[i];
            }
            return currentAmmount;
        }

        public static void Initial(string [] args)
        {
            int[] input = new int[] { 5, 7, 1, 1, 2, 3, 22 };
            int expected = 20;
            var actual = NonConstructibleChange1(input);

            Console.Write("Expected: ");
            Console.WriteLine(expected);
            Console.WriteLine();
            Console.Write("Actual: ");
            Console.WriteLine(actual);

        }
    }
}
