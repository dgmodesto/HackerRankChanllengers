using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class CatAndMouse
    {
        /*
         Two cats and a mouse are at various positions on a line. You will be given their starting positions. Your task is to determine which cat will reach the mouse first, assuming the mouse does not move and the cats travel at equal speed. If the cats arrive at the same time, the mouse will be allowed to move and it will escape while they fight.

You are given  queries in the form of x, y, and z representing the respective positions for cats A and B, and for mouse C. Complete the function  to return the appropriate answer to each query, which will be printed on a new line.

If cat A catches the mouse first, print Cat A.
If cat B  catches the mouse first, print Cat B.
If both cats reach the mouse at the same time, print Mouse C as the two cats fight and mouse escapes.
        Example

        x = 2
        y = 5
        z = 4

        The cats are at positions  (Cat A) and  (Cat B), and the mouse is at position . Cat B, at position  will arrive first since it is only  unit away while the other is  units away. Return 'Cat B'.

         */


        static string catAndMouse(int x, int y, int z)
        {
            var catA = Math.Abs(x - z);
            var catB = Math.Abs(y - z);

            if (catA < catB)
            {
                return "Cat A";
            }

            if (catA > catB)
            {
                return "Cat B";
            }

            return "Mouse C";

        }

        static void Initial(string[] args)
        {

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);

                Console.WriteLine(result);
            }

        }

    }
}
