using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class SegmentSpaceAnalisy
    {
/*
2
4
8
2
4
6
 
 
 */
        public static int segment(int x, List<int> space)
        {
            int maxResult = int.MinValue;
            for (int i = 0; i < space.Count; i++)
            {
                var groups = space.Skip(i).Take(x);
                if (groups.Count() < x) break;
                var minMax = groups.Min();
                if (minMax > maxResult)
                    maxResult = minMax;
            }


            //var queue = new Queue<int>();
            //int i = 0;
            //int n = space.Count;
            //while(i < n)
            //{
            //    if (queue.Count > 0 && queue.Count == i - x)
            //        queue.Dequeue();

            //    while(queue.Count > 0 && space[queue.Peek()] > space[i])
            //        queue.Dequeue();

            //    queue.Enqueue(i);

            //    if(i >= x -1)
            //        maxResult = space[queue.Peek()];

            //    i++;
            //}


            return maxResult;

        }

        public static void Initial(string [] args)
        {
            int x = Convert.ToInt32(Console.ReadLine().Trim());

            int spaceCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> space = new List<int>();

            for (int i = 0; i < spaceCount; i++)
            {
                int spaceItem = Convert.ToInt32(Console.ReadLine().Trim());
                space.Add(spaceItem);
            }

            int result = segment(x, space);

            Console.WriteLine(result);
        }
    }
}
