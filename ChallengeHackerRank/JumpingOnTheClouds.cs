using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public class JumpingOnTheClouds
    {
        /*
            - There is a new mobile game that starts with consecutively numbered clouds.
            - Some of the clouds are thuderheads and others are crumulus.
            - The player can jump on any cumulus cloud having a number that is equal to the number of the current cloud plus 1 or 2.
            - The player must avoid the thunderheads.
            - Determine the minimum number of jumps it will take to jump from the starting position to the last cloud.
            - It is always possible to win the game
            - For each game, you will get an array of clouds numbered 0 if they are safe or 1 if they must be avoided.
            - Example:
                - c =  [0,1,0,0,0,1,0]
                - Index the array from 0 ... 6.
                - The number on each cloud is its index in the list so the player must avoid the clouds at indices 1 and 5.
                - They could follow these two paths:
                    - 0 -> 2 -> 4 -> 6
                    - 0 -> 2 -> 3 -> 4 -> 6
                - The first path takes 3 jumps while the second takes 4.
                - Return 3

            - Input
7
0 0 1 0 0 1 0

            - Output
4
            - Input
6
0 0 0 0 1 0
            - Output
3
         */


        public static void Initial(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnCloud(c);

            Console.WriteLine(result);
        }

        private static int jumpingOnCloud(int[] c)
        {
            var jump = -1;
            for (int i = 0; i < c.Length; i++, jump++)
            {
                if (i < c.Length - 2 && c[i] == 0)
                    i++;
            }
            return jump;
        }
    }
}
