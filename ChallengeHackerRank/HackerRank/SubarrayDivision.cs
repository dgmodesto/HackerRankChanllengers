using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public class SubarrayDivision
    {
        /*
         Given a chocolate bar, two children, Lily and Ron, are determining how to share it. Each of the squares has an integer on it.

        Lily decides to share a contiguous segment of the bar selected such that:

        The length of the segment matches Ron's birth month, and,
        The sum of the integers on the squares is equal to his birth day.
        You must determine how many ways she can divide the chocolate.

        Consider the chocolate bar as an array of squares, . She wants to find segments summing to Ron's birth day,  with a length equalling his birth month, . In this case, there are two segments meeting her criteria:  and .

        Function Description

        Complete the birthday function in the editor below. It should return an integer denoting the number of ways Lily can divide the chocolate bar.

        birthday has the following parameter(s):

        s: an array of integers, the numbers on each of the squares of chocolate
        d: an integer, Ron's birth day
        m: an integer, Ron's birth month
        Input Format

        The first line contains an integer , the number of squares in the chocolate bar.
        The second line contains  space-separated integers , the numbers on the chocolate squares where .
        The third line contains two space-separated integers,  and , Ron's birth day and his birth month.

        Constraints

        , where ()
        Output Format

        Print an integer denoting the total number of ways that Lily can portion her chocolate bar to share with Ron.

        Sample Input 0

5
1 2 1 3 2
3 2
        Sample Output 0

        2
         */

        // Complete the birthday function below.
        public int birthday(List<int> s, int d, int m)
        {

            int total = 0;
            for (int i = 0; i <= s.Count - m; i++)
            {
                var segsSum = s.GetRange(i, m).Aggregate((a, b) => a + b);
                if (segsSum == d)
                {
                    total++;
                }
            }
            return total;

        }

        public void Inital()
        {
            /*
Input

5
1 2 1 3 2
3 2

Output
2
   
            
             */

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);

            Console.WriteLine(result);

        }
    }
}
