using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class FraudulentActivityNotifications
    {

        /*
   * Complete the 'activityNotifications' function below.
   *
   * The function is expected to return an INTEGER.
   * The function accepts following parameters:
   *  1. INTEGER_ARRAY expenditure
   *  2. INTEGER d
STDIN               Function
-----               --------
9 5                 expenditure[] size n =9, d = 5
2 3 4 2 3 6 8 4 5   expenditure = [2, 3, 4, 2, 3, 6, 8, 4, 5]

Sample Output 0
2


9 5
2 3 4 2 3 6 8 4 5
   */

        public static int activityNotifications(List<int> expenditure, int d)
        {
            int countNotify = 0;
            var auxExp = new int[d];
            expenditure.CopyTo(0, auxExp, 0, d);
            var auxExp1 = auxExp;
            Array.Sort(auxExp1);

            for (int i = d; i < expenditure.Count; i++)
            {
                var current = expenditure[i];
                var avg = auxExp1[d / 2] + auxExp1[(d - 1) / 2];


                if (current >= avg)
                {
                    countNotify++;
                }

                int index = Array.BinarySearch(auxExp1, expenditure[i - d]);
                Array.Copy(auxExp1, index + 1, auxExp1, index, d - index - 1);
                index = Array.BinarySearch(auxExp1, 0, d - 1, expenditure[i]);
                index = index >= 0 ? index : ~index; // ~ = bitwise negation operator
                Array.Copy(auxExp1, index, auxExp1, index + 1, d - index - 1);
                auxExp1[index] = expenditure[i];

            }

            return countNotify;
        }

        public static void Initial(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> expenditure = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(expenditureTemp => Convert.ToInt32(expenditureTemp)).ToList();

            int result = activityNotifications(expenditure, d);

            Console.WriteLine(result);

        }

    }
}
