using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class EletronicsShop
    {
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            var moreExpensive = -1;

            foreach(var kb in keyboards)
            {
                foreach(var dr in drives)
                {
                    var value = dr + kb;

                    if(value > moreExpensive && value <= b)
                    {
                        moreExpensive = value;
                    }
                }
            }

            return moreExpensive;

        }


        public static void Initial(string[] args)
        {
            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
            ;

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
            ;
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = getMoneySpent(keyboards, drives, b);

            Console.WriteLine(moneySpent);

        }
    }
}
