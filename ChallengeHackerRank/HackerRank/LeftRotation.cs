using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public class LeftRotation
    {
        /*
            - A left rotation operation on an array of size n shifts each of the array's element 1 unit to the left.
            - Given an integer, d, rotate the array that many steps left and return the result.
            - Example
                - d  = 2
                - arr = [ 1,2,3,4,5]
                - after 2 rotations, arr' = [3,4,5,1,2]
         
         */
        private static List<int> RotateLeft(int d, List<int> arr)
        {
            var queue = new Queue<int>();
            for (int i = 0; i < arr.Count; i++)
                queue.Enqueue(arr[i]);

            for(int i = 0; i < d; i++)
            {
                var val = queue.Dequeue();
                queue.Enqueue(val);
            }
            return queue.ToList();
        }

        public static void Initial(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = RotateLeft(d, arr);

            Console.WriteLine(String.Join(" ", result));
        }

    }

}
