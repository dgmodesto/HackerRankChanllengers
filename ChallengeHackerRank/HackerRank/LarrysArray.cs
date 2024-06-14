using System;
using System.Collections.Generic;

namespace ChallengeHackerRank.HackerRank
{
    public static class LarrysArray
    {

        public static string larrysArray(List<int> A)
        {
            int size = A.Count;
            bool hasRotation = false;
            int rotationEnough = 0;
            int curr;
            for (int i = 0; i < size - 1; i++)
            {
                curr = A[i];
                rotationEnough = 0;
                int count = 0;
                for (int j = i + 1; j < size; j++)
                {
                    if (curr < A[j])
                        break;

                    count++;
                    rotationEnough++;
                    if (rotationEnough == 2 || count == 2) break;

                }
                if (rotationEnough == 2)
                {
                    hasRotation = true;
                    break;
                }
            }

            if (!hasRotation)
            {
                for (int i = size - 1; i > 1; i--)
                {
                    curr = A[i];
                    rotationEnough = 0;
                    int count = 0;
                    for (int j = i - 1; j > 0; j--)
                    {
                        if (curr > A[j])
                            break;

                        count++;
                        rotationEnough++;
                        if (rotationEnough == 2 || count == 2) break;
                    }

                    if (rotationEnough == 2)
                    {
                        hasRotation = true;
                        break;
                    }

                }
            }
            return hasRotation ? "YES" : "NO";
        }


        public static void Initial(string[] args)
        {
            var input = new List<int>();
            input.Add(3); 
            input.Add(1);
            input.Add(2); 

            string output = "YES";
            var result = larrysArray(input);

            Console.WriteLine("Expected : {0} ", output);
            Console.WriteLine("Result :{0} ", String.Join(" ", result));

            Console.WriteLine("-------------------------------");
            input = new List<int>();
            input.Add(1);
            input.Add(3);
            input.Add(4);
            input.Add(2);

            output = "YES";
            result = larrysArray(input);

            Console.WriteLine("Expected : {0} ", output);
            Console.WriteLine("Result :{0} ", String.Join(" ", result));



            Console.WriteLine("-------------------------------");
            input = new List<int>();
            input.Add(1);
            input.Add(2);
            input.Add(3);
            input.Add(5);
            input.Add(4);

            output = "NO";
            result = larrysArray(input);

            Console.WriteLine("Expected : {0} ", output);
            Console.WriteLine("Result :{0} ", String.Join(" ", result));

        }


    }
}
