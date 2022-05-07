using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class FirstDuplicate
    {

        /*
         
CASE 1
Input
1 2 1 2 3 3 

Output
1

CASE 2
Input
2 1 3 5 3 2

Output
3 

CASE 3
Input
1 2 3 4 5 6

Output 
-1
         */

        private static int FindFirstDuplicate(int[] arr)
        {
        
            HashSet<int> result = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if(result.Contains(arr[i]))
                    return arr[i];

                result.Add(arr[i]);
            }

            return -1;
        }

        public static void Initial(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .ToList()
                .Select(x => Convert.ToInt32(x))
                .ToArray();


            int result = FindFirstDuplicate(arr);

            Console.WriteLine(result);
        }

    }
}
