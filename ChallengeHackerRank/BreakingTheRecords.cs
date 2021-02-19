using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    /*
     Maria plays college basketball and wants to go pro. Each season she maintains a record of her play. She tabulates the number of times she breaks her season record for most points and least points in a game. Points scored in the first game establish her record for the season, and she begins counting from there.

For example, assume her scores for the season are represented in the array . Scores are in the same order as the games played. She would tabulate her results as follows:

                                 Count
Game  Score  Minimum  Maximum   Min Max
 0      12     12       12       0   0
 1      24     12       24       0   1
 2      10     10       24       1   1
 3      24     10       24       1   1
Given the scores for a season, find and print the number of times Maria breaks her records for most and least points scored during the season.

Function Description

Complete the breakingRecords function in the editor below. It must return an integer array containing the numbers of times she broke her records. Index  is for breaking most points records, and index  is for breaking least points records.

breakingRecords has the following parameter(s):

scores: an array of integers
Input Format

The first line contains an integer , the number of games.
The second line contains  space-separated integers describing the respective values of .

Constraints

Output Format

Print two space-seperated integers describing the respective numbers of times the best (highest) score increased and the worst (lowest) score decreased.
     */

    class BreakingTheRecords
    {
        // Complete the breakingRecords function below.
        static int[] breakingRecords(int[] scores)
        {

            var higher = new List<int>();
            var lower = new List<int>();

            int h = 0;
            int l = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                if (i == 0)
                {
                    h = scores[i];
                    l = scores[i];
                    continue;
                }

                if (h < scores[i])
                {
                    higher.Add(scores[i]);
                    h = scores[i];
                }

                if (l > scores[i])
                {
                    lower.Add(scores[i]);
                    l = scores[i];
                }
            }

            return new int[] { higher.Count, lower.Count };

        }

        static void Initial(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
            ;
            int[] result = breakingRecords(scores);

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
