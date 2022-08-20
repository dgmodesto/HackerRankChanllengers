using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public class Operators
    {
        // Complete the solve function below.
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {

            double tip = (Convert.ToDouble(tip_percent) / 100) * meal_cost;
            double tax = (Convert.ToDouble(tax_percent) / 100) * meal_cost;

            Console.WriteLine(Convert.ToInt32(meal_cost + tip + tax));
        }

        static void Initial(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }
    }
}
