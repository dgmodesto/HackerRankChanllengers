using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    /*

    https://www.hackerrank.com/challenges/ctci-merge-sort/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=sorting

INPUT
    
2
5
1 1 1 2 2
5
2 1 3 1 2

OUTPUT

0
4
     
    */

    public static class MergeSortCountingInversion
    {

        public static long countInversions(List<int> arr)
        {

            var (arrSorted, ci) = MergeSortCountingInv(arr);
            return ci;
            //return MergeSort(arr.ToArray(), 0, arr.Count());
        }

        public static (List<int> arrSorted, long ci) MergeSortCountingInv(List<int> arr, long count = 0)
        {
            if (arr.Count == 0) return (arr, 0);
            else
            {
                var mid = arr.Count() / 2;

                List<int> a = arr.Skip(0).Take(mid).ToList();
                List<int> b = arr.Skip(mid).Take(arr.Count()).ToList();

                long ai, bi;
                (a, ai) = MergeSortCountingInv(a);
                (b, bi) = MergeSortCountingInv(b);
                var c = new List<int>();

                int i = 0;
                int j = 0;
                long inversions = 0 + ai + bi;

                while (i < a.Count() && j < b.Count())
                {
                    if (a[i] <= b[i])
                    {
                        c.Add(a[i]);
                        i++;
                    } else
                    {
                        c.Add(b[j]);
                        j++;
                        inversions += (arr.Count() - i);
                    }
                }

                c.AddRange(a.Skip(i).Take(arr.Count()).ToList());
                c.AddRange(b.Skip(j).Take(arr.Count()).ToList());

                return (c, inversions);
            }



        }

        public static long MergeSort(int[] a, int low, int high)
        {
            var n = high - low;
            if (n <= 1)
            {
                return 0;
            }

            var mid = low + n / 2;

            var swapsLeft = MergeSort(a, low, mid);
            var swapsRight = MergeSort(a, mid, high);
            long swaps = 0;

            var temp = new int[n];
            var i = low;
            var j = mid;
            for (var k = 0; k < n; k++)
            {
                if (i == mid)
                {
                    temp[k] = a[j++];
                }
                else if (j == high)
                {
                    temp[k] = a[i++];
                }
                else if (a[i] > a[j])
                {
                    temp[k] = a[j++];
                    swaps += mid - i;
                }
                else
                {
                    temp[k] = a[i++];
                }
            }

            for (var k = 0; k < n; k++)
            {
                a[low + k] = temp[k];
            }

            return swapsLeft + swapsRight + swaps;
        }



        public static void Initial(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                long result = countInversions(arr);

                Console.WriteLine(result);
            }

        }
    }
}
