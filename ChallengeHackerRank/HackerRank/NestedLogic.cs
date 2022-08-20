using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public class NestedLogic
    {
        public static void Initial(string [] args)
        {

            var dt1 = Console.ReadLine().ToString().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList(); ;
            var dt2 = Console.ReadLine().ToString().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList(); ; ;
            var hackos = 0;
            var diff = 0;

            var date1 = new DateTime(dt1[2], dt1[1], dt1[0]);
            var date2 = new DateTime(dt2[2], dt2[1], dt2[0]);

            if (dt2[2] == dt1[2])
            {
                if (dt2[1] == dt1[1])
                {
                    if (dt2[0] < dt1[0])
                    {
                        hackos = 15;
                        diff = (date1.Day - date2.Day);
                    }
                }
                else if (dt2[1] < dt1[1])
                {
                    hackos = 500;
                    diff = (date1.Month- date2.Month);
                }
            } else if (dt2[2] < dt1[2])
            {
                hackos = 10000;
                diff = 1;

            }

            var result = diff * ((hackos > 0) ? hackos : 1);

            Console.WriteLine(result);
        }
    }
}
