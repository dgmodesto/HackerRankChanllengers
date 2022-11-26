using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class ClassPhotos
    {
        public static bool ClassPhotos1(List<int> redShirtHeights, List<int> blueShirtHeights)
        {
            // Write your code here.

            redShirtHeights = redShirtHeights.OrderByDescending(x => x).ToList();
            blueShirtHeights = blueShirtHeights.OrderByDescending(x => x).ToList();
            var tallestStudentRed = redShirtHeights.Max();
            var tallestStudentBlue = blueShirtHeights.Max();

            if (tallestStudentRed == tallestStudentBlue)
                return false;
            else if (tallestStudentRed > tallestStudentBlue)
            {
                for (int i = 1; i < redShirtHeights.Count; i++)
                {
                    if (redShirtHeights[i] <= blueShirtHeights[i])
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 1; i < redShirtHeights.Count; i++)
                {
                    if (blueShirtHeights[i] <= redShirtHeights[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool ClassPhotos2(List<int> redShirtHeights, List<int> blueShirtHeights)
        {
            // Write your code here.
            redShirtHeights = redShirtHeights.OrderByDescending(x => x).ToList();
            blueShirtHeights = blueShirtHeights.OrderByDescending(x => x).ToList();

            if (string.Join("", redShirtHeights) == string.Join("", blueShirtHeights))
            {
                return false;
            }
            else if (redShirtHeights[0] > blueShirtHeights[0])
            {

                for (int i = 1; i < redShirtHeights.Count; i++)
                {
                    if (redShirtHeights[i] <= blueShirtHeights[i])
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 1; i < redShirtHeights.Count; i++)
                {
                    if (blueShirtHeights[i] <= redShirtHeights[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool ClassPhotos3(List<int> redShirtHeights, List<int> blueShirtHeights)
        {
            // Write your code here.
            redShirtHeights.Sort();
            blueShirtHeights.Sort();

            var isTallestBlue = blueShirtHeights.Last() > redShirtHeights.Last();

            for (int i = 0; i < blueShirtHeights.Count; i++)
            {

                if (isTallestBlue && blueShirtHeights[i] <= redShirtHeights[i])
                    return false;


                if (!isTallestBlue && redShirtHeights[i] <= blueShirtHeights[i])
                    return false;
            }

            return true;
        }

        public static void Initial(string [] args)
        {
            int[] blueShirtHeights = new int[] { 5, 4 };
            int[] redShirtHeights = new int[] { 4, 5 };

            var result = ClassPhotos1(redShirtHeights.ToList(), blueShirtHeights.ToList()) ;

            Console.WriteLine("Expected: False");
            Console.WriteLine($"Actual: { result }");
        }
    }
}
