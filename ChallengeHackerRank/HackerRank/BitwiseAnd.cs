using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    /*
     
        int a = 60;            60 = 0011 1100 
        int b = 13;            13 = 0000 1101
        int c = 0;

        c = a & b;             12 = 0000 1100
        Line 1 - Value of c is 12

        c = a | b;             61 = 0011 1101
        Line 2 - Value of c is 61
         
        c = a ^ b;             49 = 0011 0001
         Line 3 - Value of c is 49
         
        c = ~a;                -61 = 1100 0011
        Line 4 - Value of c is -61
         
        c = a << 2;      240 = 1111 0000
        Line 5 - Value of c is 240
         
        c = a >> 2;      15 = 0000 1111 
        Line 6 - Value of c is 15

        

     */
    public class BitwiseAnd
    {
        public static void Initial(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int result = 0;

                for(int i =0; i < n; i++)
                {
                    for(int j = i+1; j <= n; j++)
                    {
                        int amp = i & j;
                        if (amp < k && amp > result)
                            result = amp;
                    }
                }
                Console.WriteLine(result);

            }
        }
    }
}
