using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class TournamentWinner
    {
        public static string TournamentWinner1(List<List<string>> competitions, List<int> results)
        {
            // Write your code here.
            var dic = new Dictionary<string, int>();
            for (int i = 0; i < results.Count; i++)
            {

                var competitors = competitions[i];
                string winCompetitor = competitors[results[i] == 0 ? 1 : 0];

                if (!dic.ContainsKey(winCompetitor))
                {
                    dic.Add(winCompetitor, 3);
                }
                else
                {
                    dic[winCompetitor] += 3;
                }
            }

            return dic.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        }

        public static string TournamentWinner2(List<List<string>> competitions, List<int> results)
        {
            // Write your code here.

            string bestCompetitor = "";
            var dic = new Dictionary<string, int>();

            for (int i = 0; i < results.Count; i++)
            {
                var competitors = competitions[i];
                string currentWinner = competitors[results[i] == 0 ? 1 : 0];
                if (!dic.ContainsKey(currentWinner))
                {
                    dic.Add(currentWinner, 3);
                }
                else
                {
                    dic[currentWinner] += 3;
                }

                if (bestCompetitor == string.Empty || dic[currentWinner] > dic[bestCompetitor])
                {
                    bestCompetitor = currentWinner;
                }
            }
            return bestCompetitor;
        }

        public static void Initial(string [] args)
        {
            List<List<string>> competitions = new List<List<string>>();
            List<string> competition1 = new List<string> {
            "HTML", "C#"
        };
            List<string> competition2 = new List<string> {
            "C#", "Python"
        };
            List<string> competition3 = new List<string> {
            "Python", "HTML"
        };
            competitions.Add(competition1);
            competitions.Add(competition2);
            competitions.Add(competition3);
            List<int> results = new List<int> {
            0, 0, 1
        };
            string expected = "Python";
            var actual = TournamentWinner1(competitions, results);

            Console.Write("Expected: ");
            Console.WriteLine(expected);
            Console.WriteLine();
            Console.Write("Actual: ");
            Console.WriteLine(actual);

        }
    }
}
