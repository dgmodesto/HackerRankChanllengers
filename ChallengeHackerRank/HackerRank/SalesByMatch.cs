using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class SalesByMatch
    {
        /*
        - There is a large pile of socks that must be paired by color.
        - Given an array of integers representing the color of each sock, determine how many pairs of socks with matching soclors ther are.
        - Example
            - n = 7
            - ar = [ 1,2,1,2,1,3,2]
            - There is one pair of color 1 and one of color 2.
            - There are three odd socks left, one of each color.
            - The number of pairs is 2.
          
        - Input
9
10 20 20 10 10 30 50 10 20
        - Output
3

         */


        public static void Initial(string [] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = SockMerchant(n, ar);

            Console.WriteLine(result);
        }

        private static int SockMerchant(int n, int[] ar)
        {
            int sum = 0;
            var results = new List<int>();

            for( int i = 0; i < ar.Length; i++)
            {
                if (!results.Contains(ar[i]))
                    results.Add(ar[i]);
            }

            foreach(var item in results)
            {
                var value = ar.ToList().Where(x => x == item).Count();
                if (value % 2 != 0)
                    value--;

                sum += (value / 2);
            }

            return sum;
        }

        private static object List<T>()
        {
            throw new NotImplementedException();
        }
    }
}
