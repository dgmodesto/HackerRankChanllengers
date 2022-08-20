using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public class SortingBoubleSorting
    {
        /*
        - Given an array, a, of size na distinct elements, sort the array in ascending orer using the Buble Sort algorithm.
        - Once sorted, print the the following 3 lines
            - 1. Array is sorted in numSwapps swaps
            - 2. first element: firstElement
                - where firstElement is the first element in the sorted array.
            - 3. Last Element: lastElement
                - where lastElement is the last element in the sorted array.
        - Hint: To complete this challenge, you will need to add a variable that keeps a running tally of all swaps that occru during execution.

        - Input
3
1 2 3
        - Output
Array is sorted in 0 swaps.
First Element: 1
Last Element: 3
         */
        static void Initital(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            // Write Your Code Hefa

            int swaps = 0;

            for (int i = 0; i < a.Count() - 1; i++)
            {
                for (int j = 0; j < a.Count() - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        var temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        swaps++;
                    }
                }
            }


            Console.WriteLine("Array is sorted in " + swaps + " swaps.");
            Console.WriteLine("First Element: " + a[0]);
            Console.WriteLine("Last Element: " + a[a.Count() - 1]);

        }
    }
}
