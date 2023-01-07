using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class Semordnilap
    {
        public static List<List<string>> Semordnilap1(string[] words)
        {
            // Write your code here.
            var map = new Dictionary<string, List<string>>();
            var output = new List<List<string>>();

            foreach (var word in words)
            {
                var wordArr = word.ToCharArray();
                Array.Sort(wordArr);
                var wordKey = new String(wordArr);

                if (!map.ContainsKey(wordKey))
                {
                    map.Add(wordKey, new List<string>());
                }
                map[wordKey].Add(word);
            }

            foreach (var item in map.Values)
                if (item.Count > 1)
                    output.Add(item);

            return output;
        }

        public static void Initial(string [] args)
        {
            var input = new string[] { "dog", "hello", "desserts", "test", "god", "stressed" };
            var output = Semordnilap1 (input);

            Console.WriteLine(@"Expected:  ['dog', 'god'], ['desserts', 'stressed']");

            Console.Write(@"Expected:  ");


            output.ForEach(item =>
            {
                Console.Write("[ ");
                item.ForEach(i =>
                {
                    Console.Write(i);

                    Console.Write(", ");

                });
                Console.Write("] , ");

            });
        }
    }
}
