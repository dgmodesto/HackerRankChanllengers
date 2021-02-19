using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public class RunningTimeAndComplexity
    {
        public static void Initial(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            var isPrime = true;
            var n = Convert.ToInt32(Console.ReadLine());
            var values = new List<int>();
            while (n-- > 0)
            {

                int val = Convert.ToInt32(Console.ReadLine());

                for (int i = 2; i <= val / i; i++)
                    if (val % i == 0) val = 1;

                if (val == 1) Console.WriteLine("Not prime");
                else Console.WriteLine("Prime");

            }


           
        }
    }
}
