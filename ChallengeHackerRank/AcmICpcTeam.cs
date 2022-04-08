using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class AcmICpcTeam
    {
        /*
 * Complete the 'acmTeam' function below.
 *
 *https://www.hackerrank.com/challenges/acm-icpc-team/problem?isFullScreen=true
 *
 * The function is expected to return an INTEGER_ARRAY.
 * The function accepts STRING_ARRAY topic as parameter.
 * 
 * 
 */

        public static List<int> acmTeam(List<string> topic)
        {
            var result = new List<int>();
            var teamList = new List<int>();
            int team = 1;
            int tk = 0;
            for (int i = 0; i <= topic.Count - 1; i++)
            {
                for (int j = i + 1; j < topic.Count; j++)
                {
                    var firstMember = i;
                    var secondMember = j;
                    tk = 0;

                    for (int k = 0; k < topic[firstMember].Length; k++)
                    {
                        if (topic[firstMember][k] == '1' || topic[secondMember][k] == '1')
                            tk++;
                    }
                    if (!result.Any() || result.Where(x => x == tk).Any())
                    {
                        result.Add(tk);
                    }
                    else if (result.Where(x => x < tk).Any())
                    {
                        result.Clear();
                        result.Add(tk);

                    }
                    team++;
                }

            }

            teamList.Add(result.Count > 0 ? result[0] : 0);
            teamList.Add(result.Count);
            return teamList;
        }

        public static void Initial(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<string> topic = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string topicItem = Console.ReadLine();
                topic.Add(topicItem);
            }

            List<int> result = acmTeam(topic);

            Console.WriteLine(String.Join("\n", result));

        }
    }
}
