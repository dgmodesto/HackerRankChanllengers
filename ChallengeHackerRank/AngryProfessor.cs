using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class AngryProfessor
    {
		/*
* Complete the 'angryProfessor' function below.
*
*https://www.hackerrank.com/challenges/angry-professor/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign
*
* The function is expected to return a STRING.
* The function accepts following parameters:
*  1. INTEGER k
*  2. INTEGER_ARRAY a
*/
		public static string angryProfessor(int k, List<int> a)
		{
			var qtd = 0;

			foreach (var student in a)
			{
				if (student <= 0)
					qtd++;
			}

			if (qtd <= k)
				return "NO";
			else
				return "YES";

		}

		public static void Initial(string[] args)
		{
			int t = Convert.ToInt32(Console.ReadLine().Trim());

			for (int tItr = 0; tItr < t; tItr++)
			{
				string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

				int n = Convert.ToInt32(firstMultipleInput[0]);

				int k = Convert.ToInt32(firstMultipleInput[1]);

				List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

				string result = angryProfessor(k, a);

				Console.WriteLine(result);
			}
		}
	}
}
