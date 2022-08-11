using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class FindZigZagSequence
    {


        /*
INPUT 
1
7
1 2 3 4 5 6 7
        
OUTPUT
1 2 3 7 6 5 4
         */

        public static void findZigZagSequence(int[] a, int n)
        {
            Array.Sort(a);
            int mid = (n + 1) / 2 - 1;
            int temp = a[mid];
            a[mid] = a[n - 1];
            a[n - 1] = temp;

            int st = mid + 1;
            int ed = n - 2;
            while (st <= ed)
            {
                temp = a[st];
                a[st] = a[ed];
                a[ed] = temp;
                st = st + 1;
                ed = ed - 1;
            }
            for (int i = 0; i < n; i++)
            {
                if (i > 0) Console.Write(" ");
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }

        public static void Initial(string [] args)
        {
            int testsCases= Convert.ToInt32(Console.ReadLine().Trim());
            for (int cs = 1; cs <= testsCases; cs++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());
                int [] a  = new int[n];

                a = Console.ReadLine().Split(" ").ToList().Select(x => Convert.ToInt32(x)).ToArray();

                //for (int i = 0; i < n; i++)
                //{
                //}
                findZigZagSequence(a, n);
            }
        }
    }
}
