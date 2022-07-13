using System;
using System.Collections.Generic;

namespace ChallengeHackerRank.DataStructure
{
  public class QueueSample
    {
        

        static void PrintBynary(int n) {
            if (n <= 0) return;

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            for(int i = 0; i < n; i++) {
                int current = queue.Dequeue();
                Console.WriteLine(current);
                queue.Enqueue(current * 10);
                queue.Enqueue(current * 10 + 1);
            }
        }

        public static void Initial(string [] args) {

            PrintBynary(5);
            PrintBynary(-2);
            PrintBynary(0);
            PrintBynary(2);
            PrintBynary(8);
        }
    }
}