using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class CavityMap
    {
        /*
 * Complete the 'cavityMap' function below.
 *
 *https://www.hackerrank.com/challenges/cavity-map/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
 *
 * The function is expected to return a STRING_ARRAY.
 * The function accepts STRING_ARRAY grid as parameter.
 STDIN   Function
-----   --------
4       grid[] size n = 4
1112    grid = ['1112', '1912', '1892', '1234']
1912
1892
1234

4
1112
1912
1892
1234

 */

        public static List<string> cavityMap(List<string> grid)
        {
            var rowAux = new List<string>();
            var gridResult = new List<string>(grid);

            

            for (int i = 1; i < grid.Count - 1; i++)
            {
                var row = grid[i].ToArray().Select(x => Convert.ToInt32(x.ToString())).ToList();
                rowAux = grid[i].ToArray().Select(x => x.ToString()).ToList();

                for (int j = 1; j < row.Count() - 1; j++)
                {
                    var current = row[j];

                    var left = Convert.ToInt32(row[j - 1]);
                    var right = Convert.ToInt32(row[j + 1]);
                    var top = Convert.ToInt32(grid[i - 1][j].ToString());
                    var bottom = Convert.ToInt32(grid[i + 1][j].ToString());

                    if(current > left && current > right && current > top && current > bottom) {
                        rowAux[j] = "X";
                        gridResult[i] = String.Join("", rowAux);
                    }
                }
            }

            return gridResult;
        }

        public static void Initial(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            List<string> result = cavityMap(grid);

            Console.WriteLine(String.Join("\n", result));

        }

    }
}
