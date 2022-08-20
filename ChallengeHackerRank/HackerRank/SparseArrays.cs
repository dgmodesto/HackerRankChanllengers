using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public class SparseArrays
    {

        /*
            - There is a collection of input strings and a collection of query strings.
            - For each query string, determine how many times it occurs in the list of input strings.
            - Return an array of the results.
            - Example
                - strings = ['ab', 'ab', 'abc']
                - queries = [ 'ab', 'abc', 'bc']
                - There are 
                    - 2 instances of 'ab'
                    - 1 instances of 'abc'
                    - 0 instances of 'bc'
                - For each query, add an element to the return array,
                - results = [2, 1,0]
         
            - Input
4
aba
baba
aba
xzxb
3
aba
xzxb
ab

            - Output
2
1
0
         */

        private static int[] MatchingStrings(string[] strings, string[] queries)
        {
            var result = new List<int>();
            queries.ToList().ForEach(q =>
            {
                var res = strings.ToList().Where(x => x == q).ToArray();
                result.Add(res.Length);
            });

            return result.ToArray();
        }


        public static void Initial(string [] args)
        {
            int stringsCount = Convert.ToInt32(Console.ReadLine());

            string[] strings = new string[stringsCount];

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings[i] = stringsItem;
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine());

            string[] queries = new string[queriesCount];

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries[i] = queriesItem;
            }

            int[] res = MatchingStrings(strings, queries);

            Console.WriteLine(string.Join("\n", res));
        }

    }
}
