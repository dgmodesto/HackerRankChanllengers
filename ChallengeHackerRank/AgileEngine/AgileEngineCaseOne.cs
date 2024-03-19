using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

namespace ChallengeHackerRank.AgileEngine
{
    public class AgileEngineCaseOne
    {
        public static string solution(string[] A, string[] B, string p)
        {
            // Implement your solution here
            IEnumerable<int> indexes = B.ToList()
                                .Select((value, index) => new { Value = value, Index = index })
                                .Where(item => item.Value.Contains(p))
                                .OrderByDescending(x => x.Value)
                                .Select(item => item.Index);
                                //.FirstOrDefault();

            
            if(!indexes.Any()) return "NO CONTACT";

            return A[indexes.FirstOrDefault()];

        }


        public static void Initial(string[] args)
        {
            string[] A = new string[] { "Adam", "amy", "ann", "michel" };
            string[] B = new string[] { "121212121", "111111111", "444555666", "789123456" };
            string P = "112";

            var result = solution(A, B, P);
            Console.WriteLine(result);
        }
    }
}
