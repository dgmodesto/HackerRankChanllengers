using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class LisasWorkbook
    {

        /*
* Complete the 'workbook' function below.
*
*https://www.hackerrank.com/challenges/lisa-workbook/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
*
* The function is expected to return an INTEGER.
* The function accepts following parameters:
*  1. INTEGER n
*  2. INTEGER k
*  3. INTEGER_ARRAY arr
*  
5 3
4 2 6 1 10
*/

        public static int workbook(int n, int k, List<int> arr)
        {
            var countResult = 0;
            var page = 1;
            for (int i = 0; i < arr.Count; i++)
            {
                var problem = arr[i];
                var countProblemPerPage = 0;
                var chapter = i + 1;

                for (int currentProblem = 1; currentProblem <= problem; currentProblem++)
                {

                    if (page == currentProblem)
                    {
                        countResult++;
                    }

                    countProblemPerPage++;

                    if(countProblemPerPage == k && currentProblem < problem)
                    {
                        page++;
                        countProblemPerPage = 0;
                    }

                }
                page++;
            }


            return countResult;
        }



        public static void Initial(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = workbook(n, k, arr);

            Console.WriteLine(result);
        }
    }

}
