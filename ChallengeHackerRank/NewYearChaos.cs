using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public class NewYearChaos
    {
        /*
            - It is New Year's Day and people are n line for the Wonderland rollercoaster ride.
            - Each person wears a sticker indicating their initial position in the queue from 1 to n.
            - Any person can bribe the person directly in front of them to swap positions, but they still wear their original sticker. 
            - One person can bribe at most two others.
            - Determine the minimum number of bribes that took place to get to a given queue order.
            - Print the number of bribes, or, if anyone has bribed more than two people, print Too chaotic.
            - Example
                - q [1,2,3,5,4,6,7,8]
                    - if person 5 bribe person 4, the queue will look like this 1,2,3,5,4,6,7,8.
                    - Only 1 bribes is required.
                    - Print 1
                - q = [4,1,2,3]
                    - Person 4 had to bribes 3 peeple to get to the current position.
                    - Print Too chaotic

            - Input
2
5
2 1 5 3 4
5
2 5 1 3 4
            - Output
3
Too chaotic
            
         
         */
        public static void Initial(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
                MinimumBribes(q);
            }
        }

        private static void MinimumBribes(int[] q)
        {
            int bribe = 0;
            bool chaotic = false;
            for (int i = 0; i < q.Length; i++)
            {
                if (q[i] - (i + 1) > 2)
                {
                    chaotic = true;
                    break;
                }

                var high = Math.Max(0, q[i] - 2);  // update the highest value encountered
                for (int j = high; j < i; j++)
                    if (q[j] > q[i])
                        bribe++;

            }

            if (chaotic)
                Console.WriteLine("Too chaotic");
            else
                Console.WriteLine(bribe);
        }
    }
}