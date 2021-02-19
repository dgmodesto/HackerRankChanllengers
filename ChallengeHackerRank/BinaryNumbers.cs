using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class BinaryNumbers
    {
        /*
         Objective
        Today, we're working with binary numbers. Check out the Tutorial tab for learning materials and an instructional video!

        Task
        Given a base- integer, , convert it to binary (base-). Then find and print the base- integer denoting the maximum number of consecutive 's in 's binary representation. When working with different bases, it is common to show the base as a subscript.

        Example

        The binary representation of  is . In base , there are  and  consecutive ones in two groups. Print the maximum, .

        Input Format

        A single integer, .

        Constraints

        Output Format

        Print a single base- integer that denotes the maximum number of consecutive 's in the binary representation of .

        Sample Input 1

        5
        Sample Output 1

        1
        Sample Input 2

        13
        Sample Output 2

        2
         
         */

        public static void Initial(string [] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var bin = Convert.ToString(n, 2);
            int q = 0;
            int max = 0;
            for(int i =0; i < bin.Length; i++)
            {
                if (bin[i] == '1')
                    q++;
                else
                    q = 0;

                if (q > max)
                {
                    max = q;
                }
            }
            Console.WriteLine(max);
        }
    }
}
