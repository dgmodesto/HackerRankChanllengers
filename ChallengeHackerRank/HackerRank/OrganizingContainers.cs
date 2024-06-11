using System.Collections.Generic;
using System;

namespace ChallengeHackerRank.HackerRank
{
    public static class OrganizingContainers
    {


        public static string organizingContainers(List<List<int>> container)
        {
            int size = container[0].Count;
            int[] types = new int[size];
            int[] cnts = new int[size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    types[j] += container[i][j];
                    cnts[i] += container[i][j];
                }
            }

            Array.Sort(types);
            Array.Sort(cnts);

            for (int i = 0; i < size; i++)
                if (types[i] != cnts[i]) return "Impossible";

            return "Possible";
        }

        public static void Initial(string[] args)
        {
            var input = new List<List<int>>();
            input.Add(new List<int>() {1, 3, 1 });
            input.Add(new List<int>() { 2, 1, 2 });
            input.Add(new List<int>() { 3, 3, 3 });

            string output = "Impossible";
            var result = organizingContainers(input);

            Console.WriteLine("Expected : {0} ", output);
            Console.WriteLine("Result :{0} ", result);

            Console.WriteLine("-----------------------");

            input = new List<List<int>>();
            input.Add(new List<int>() { 0, 2, 1 });
            input.Add(new List<int>() { 1, 1, 1 });
            input.Add(new List<int>() { 2, 0, 0 });

            output = "Possible";

            result = organizingContainers(input);

            Console.WriteLine("Expected : {0} ", output);
            Console.WriteLine("Result :{0} ", result);
        }
    }
}
