using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class AppleAndOrange
    {
        // Complete the countApplesAndOranges function below.
        /*
         Sam's house has an apple tree and an orange tree that yield an abundance of fruit. Using the information given below, determine the number of apples and oranges that land on Sam's house.

        In the diagram below:

        The red region denotes the house, where  is the start point, and  is the endpoint. The apple tree is to the left of the house, and the orange tree is to its right.
        Assume the trees are located on a single point, where the apple tree is at point , and the orange tree is at point .
        When a fruit falls from its tree, it lands  units of distance from its tree of origin along the -axis. *A negative value of  means the fruit fell  units to the tree's left, and a positive value of  means it falls  units to the tree's right. *
        Apple and orange(2).png

        Given the value of  for  apples and  oranges, determine how many apples and oranges will fall on Sam's house (i.e., in the inclusive range )?

For example, Sam's house is between  and . The apple tree is located at  and the orange at . There are  apples and  oranges. Apples are thrown  units distance from , and  units distance. Adding each apple distance to the position of the tree, they land at . Oranges land at . One apple and two oranges land in the inclusive range  so we print
         */
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {

            var result = new List<int>();
            var applesFall = 0;
            var orangesFall = 0;
            for (int i = 0; i < apples.Length; i++)
            {
                var res = apples[i] + a;

                if (res >= s && res <= t)
                {
                    applesFall++;
                }
            }

            for (int i = 0; i < oranges.Length; i++)
            {
                var res = oranges[i] + b;

                if (res >= s && res <= t)
                {
                    orangesFall++;
                }
            }
            Console.WriteLine(applesFall);
            Console.WriteLine(orangesFall);

        }

        static void Initial(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
