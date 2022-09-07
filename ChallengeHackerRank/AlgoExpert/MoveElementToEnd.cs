using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class MoveElementToEnd
    {
        public static List<int> MoveElementToEnd1(List<int> array, int toMove)
        {
            // Write your code here.
            // Complexity O(n) | Space O(n)
            var qArray = new Queue<int>();
            var qArrayMove = new Queue<int>();
            foreach (int value in array)
            {
                if (value == toMove)
                {
                    qArray.Enqueue(value);
                }
                else
                {
                    qArrayMove.Enqueue(value);
                }
            }
            while (qArray.Count > 0)
                qArrayMove.Enqueue(qArray.Dequeue());

            return qArrayMove.ToList();
        }

        public static List<int> MoveElementToEnd2(List<int> array, int toMove)
        {
            // Write your code here.
            // Complexity
            int idxStart = 0;
            int idxEnd = array.Count - 1;
            while (idxStart <= idxEnd)
            {
                if (array[idxStart] == toMove && array[idxEnd] != toMove)
                {
                    int aux = array[idxStart];
                    array[idxStart] = array[idxEnd];
                    array[idxEnd] = aux;
                    idxStart++;
                    idxEnd--;
                }
                else if (array[idxStart] != toMove)
                {
                    idxStart++;
                }
                else if (array[idxEnd] == toMove)
                {
                    idxEnd--;
                }
            }
            return array;
        }

        public static List<int> MoveElementToEnd3(List<int> array, int toMove)
        {
            // Write your code here.
            // Complexity O(n) | Space O(1)
            int idxStart = 0;
            int idxEnd = array.Count - 1;

            while (idxStart < idxEnd)
            {
                while (idxStart < idxEnd && array[idxEnd] == toMove)
                    idxEnd--;

                if (array[idxStart] == toMove)
                {
                    int aux = array[idxStart];
                    array[idxStart] = array[idxEnd];
                    array[idxEnd] = aux;
                }
                idxStart++;
            }

            return array;
        }

        public static void Initial(string [] args)
        {
            List<int> array = new List<int>(){
            2, 1, 2, 2, 2, 3, 4, 2
        };
            int toMove = 2;
            List<int> expectedStart = new List<int>(){
            1, 3, 4
        };
            List<int> expectedEnd = new List<int>(){
            2, 2, 2, 2, 2
        };
            List<int> output = MoveElementToEnd1(array, toMove);
            List<int> outputStart = output.GetRange(0, 3);
            outputStart.Sort();
            List<int> outputEnd = output.GetRange(3, output.Count - 3);

            Console.WriteLine("Expected");
            Array.ForEach(expectedStart.ToArray(), Console.Write);
            Array.ForEach(expectedEnd.ToArray(), Console.Write);

            Console.WriteLine("Actual");
            Array.ForEach(outputStart.ToArray(), Console.Write);
            Array.ForEach(outputEnd.ToArray(), Console.Write);

        }
    }
}
