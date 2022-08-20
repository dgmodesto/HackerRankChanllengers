using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class DrawingBook
    {
        /*
         A teacher asks the class to open their books to a page number. A student can either start turning pages from the front of the book or from the back of the book. They always turn pages one at a time. When they open the book, page  is always on the right side:
         
        When they flip page 1, they see pages 2 and 3. Each page except the last page will always be printed on both sides. The last page may only be printed on the front, given the length of the book. If the book is  pages long, and a student wants to turn to page , what is the minimum number of pages to turn? They can start at the beginning or the end of the book.

        Given n and p, find and print the minimum number of pages that must be turned in order to arrive at page  p
         
         Example:
            n = 5
            p = 3

            Return 1
         */


        public static int pageCount(int n, int p)
        {

            var totalPageTurnCounFromFront = n / 2;
            var targetPageTurnCountFromFront = p / 2;
            var targetPageTurnCountFromBack = totalPageTurnCounFromFront - targetPageTurnCountFromFront;

            return Math.Min(targetPageTurnCountFromFront, targetPageTurnCountFromBack);

        }

        public static void Initial(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int p = Convert.ToInt32(Console.ReadLine().Trim());

            int result = pageCount(n, p);

            Console.WriteLine(result);

        }


    }
}
