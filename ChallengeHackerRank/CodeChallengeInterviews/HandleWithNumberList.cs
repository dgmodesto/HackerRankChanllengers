using System.Collections.Generic;
using System;

namespace ChallengeHackerRank.CodeChallengeInterviews
{
    public class HandleWithNumberList
    {
        /*
            Write a C# function that takes a list of integers as input and performs the following operations:

            - Find the largest number in the list.
            - Find the smallest number in the list.
            - Calculate the sum of all numbers in the list.
            - Calculate the average of the numbers in the list.
            - Create a new list containing only the odd numbers from the original list, sorted in ascending order.

            Technical Requirements:

            - The function should be named AnalyzeNumberList.
            - The function should have the following signature: public static (int max, int min, int sum, double average, List<int> oddNumbers) AnalyzeNumberList(List<int> numbers).
            - The function should return a tuple containing the maximum number, minimum number, sum, average, and sorted list of odd numbers.
            - Utilize efficient algorithms for each operation.
            - If the list of numbers is empty, return appropriate default values for each output.

            Points to Consider:

            - Efficiency in implementing search and manipulation algorithms.
            - Handling edge cases and exceptions.
            - Code clarity and readability.
            - Use of comments to explain complex logic if necessary.

            [,9,8,1,3,5,6]

            [1, 3, 5, 6, 8, 9]

            size

            smallest - [0] - O(1)
            largest - [size-1] O(1)
            sum - O(N)
            odds - O(N)
            average - sum / size O(1)

            */

        // Complexity O(N)
        public static (int, int, int, double, List<int>) AnalyzeNumberList(List<int> numbers)
        {
            int max = 0;
            int min = 0;
            int sum = 0;
            double average = 0.0;
            List<int> oddNumbers = new List<int>();

            if (numbers?.Count > 0)
            {

                numbers.Sort();
                int size = numbers.Count;
                min = numbers[0];
                max = numbers[size - 1];

                for (int i = 0; i < size - 1; i++)
                {
                    int curr = numbers[i];
                    sum += curr;

                    if (curr % 2 == 0) oddNumbers.Add(curr);
                }
                average = sum / size;

            }

            return (max, min, sum, average, oddNumbers);

        }


        public static void Initial(string[] args)
        {
            List<int> numbers = new List<int> { 9, 8, 1, 3, 5, 6};

            var result = AnalyzeNumberList(numbers);
            Console.WriteLine(result);
        }
    }

}
