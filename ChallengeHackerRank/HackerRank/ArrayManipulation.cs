using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public class ArrayManipulation
    {
        /*
         
            - Input
5 3
1 2 100
2 5 100
3 4 100
            - Output
200
        ***
            - Input
10 4
2 6 8
3 5 7
1 8 1
5 9 15
            - Output
31
         */

        private static long ArrayManipulations(int n, int[][] queries)
        {
            /*
                - Starting with a 1-indexed array of zeros and a list of operations, for each operation add a value to each the array element
                    - between two given indices, inclusive.
                - Once all operations have been performed, return the maximum value in the array.
             */

            List<long> list = new List<long>();
            for (int i = 0; i < n+1; i++)
                list.Add(0);

            foreach(var q in queries)
            {
                var a = q[0] - 1;
                var b = q[1] ;
                var k = q[2];
                list[a] += k;
                list[b] -= k;
            }

            long maxValue = 0;
            long count = 0;

            foreach (long i in list)
            {
                count += i;
                if (count > maxValue)
                    maxValue = count;
            }
            return maxValue;


            //long maxValue = 0;
            //List<long> list = new List<long>();
            //List<List<long>> listGroup = new List<List<long>>();
            //int cont = 0;
            //listGroup.Add(list);

            //foreach (var q in queries)
            //{
            //    list = new List<long>();

            //    var a = q[0] - 1;
            //    var b = q[1] - 1;
            //    var k = q[2];

            //    for (int i = 0; i < n; i++)
            //    {
            //        var value = (cont >= 0 && listGroup[cont].Count >= i) ? listGroup[cont][i] : 0;

            //        if (i >= a && i <= b)
            //        {
            //            var val = k + value;
            //            list.Add(val);

            //            if (val > maxValue)
            //                maxValue = val;
            //        }
            //        else
            //        {
            //            list.Add(value );

            //        }
            //    }

            //    listGroup.Add(list);
            //    cont++;

            //}

            //return maxValue;
        }

        public static void Initial(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[][] queries = new int[m][];

            for (int i = 0; i < m; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            long result = ArrayManipulations(n, queries);

            Console.WriteLine(result);
        }

    }
}
