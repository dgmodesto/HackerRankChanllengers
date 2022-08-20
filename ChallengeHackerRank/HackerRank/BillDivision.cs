using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class BillDivision
    {
        // Complete the bonAppetit function below.
        static void bonAppetit(List<int> bill, int k, int b)
        {
            double sum = 0;

            int sum1 = bill.Where((x, i) => i != k).Sum();

            if (b == sum1 / 2)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(b - sum1 / 2);

            if (k < bill.Count)
                sum = bill.Where(x => x != bill[k]).Sum();
            else
                sum = bill.Sum();


            if (b == (sum / 2))
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                var result = b - sum / 2;
                Console.WriteLine(result);
            }

        }

        public static void Initial(string[] args)
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);
        }
    }
}
