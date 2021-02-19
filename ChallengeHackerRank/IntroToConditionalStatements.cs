using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    /*
     Objective
In this challenge, we learn about conditional statements. Check out the Tutorial tab for learning materials and an instructional video.

Task
Given an integer, , perform the following conditional actions:

If  is odd, print Weird
If  is even and in the inclusive range of  to , print Not Weird
If  is even and in the inclusive range of  to , print Weird
If  is even and greater than , print Not Weird
Complete the stub code provided in your editor to print whether or not  is weird.

Input Format

A single line containing a positive integer, .

Constraints

Output Format

Print Weird if the number is weird; otherwise, print Not Weird.

Sample Input 0
     */
    class IntroToConditionalStatements
    {
        static void Initial(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            bool isEven = N % 2 == 0;
            var result = "Not Weird";

            if (!isEven)
            {
                result = "Weird";
            }
            else
            {
                if (isEven && N >= 6 && N <= 20)
                {
                    result = "Weird";
                }

            }

            Console.WriteLine(result);

        }
    }
}
