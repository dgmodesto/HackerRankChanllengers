using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class MigratoryBirds
    {
        /*
         Given an array of bird sightings where every element represents a bird type id, determine the id of the most frequently sighted type. If more than 1 type has been spotted that maximum amount, return the smallest of their ids.

        Example

        There are two each of types  and , and one sighting of type . Pick the lower of the two types seen twice: type .

        Function Description

        Complete the migratoryBirds function in the editor below.

        migratoryBirds has the following parameter(s):

        int arr[n]: the types of birds sighted
        Returns

        int: the lowest type id of the most frequently sighted birds
        Input Format

        The first line contains an integer, , the size of .
        The second line describes  as  space-separated integers, each a type number of the bird sighted.

        Constraints

        It is guaranteed that each type is , , , , or .
        Sample Input 0

        6
        1 4 4 4 5 3
        Sample Output 0

        4
         
         */


        // Complete the migratoryBirds function below.
        static int migratoryBirds(List<int> arr)
        {

            var types = 0;
            var wich = 0;

            var maxNumber = arr.Max();
            for( int i = 1; i <= maxNumber; i++)
            {
                var result = arr.Select(x => x == i).ToArray().Where(x => x == true);

                if(result.Count() == types)
                {
                    if (wich > i)
                        wich = i;

                } else if (result.Count() > types){
                    wich = i;
                    types = result.Count();
                }
            }

            return wich;
        }

        public static void Initial(string[] args)
        {

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            Console.WriteLine(result);

        }

    }
}
