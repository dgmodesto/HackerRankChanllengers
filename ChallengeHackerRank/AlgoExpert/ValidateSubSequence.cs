using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class ValidateSubSequence
    {
        public static bool IsValidSubsequence1(List<int> array, List<int> sequence)
        {
            // Write your code here.
            // complexity O(n) | Space O(1)

            foreach (var item in array)
            {
                if (sequence.Contains(item))
                {
                    var idx = sequence.IndexOf(item);
                    if (idx != 0) return false;
                    sequence.RemoveAt(idx);
                }
            }
            return !sequence.Any();
        }

        public static bool IsValidSubsequence2(List<int> array, List<int> sequence)
        {
            // Write your code here.
            // complexity O(n) | Space O(1)

            int idx = 0;
            int count = 0;
            if (sequence.Count > array.Count) return false;

            for (int i = 0; i < array.Count; i++)
            { // O(n)
                if (sequence.Contains(array[i]))
                {
                    int idxSeq = sequence.IndexOf(array[i]); // O(m)
                    if (idxSeq - idx <= 1)
                    {
                        idx = idxSeq;
                        count++;

                        if (count == sequence.Count) return true;
                    }
                    else
                        return false;
                }
            }


            return count == sequence.Count;
        }

        public static bool IsValidSubsequence3(List<int> array, List<int> sequence)
        {

            //Complexity O(n) | Space O(1)
            int idxSeq = 0;
            foreach (int item in array)
            {
                if (item == sequence[idxSeq])
                    idxSeq++;

                if (idxSeq >= sequence.Count)
                    break;
            }
            return idxSeq == sequence.Count;

        }

        public static bool IsValidSubsequence4(List<int> array, List<int> sequence)
        {
            // Write your code here.
            // Complexity O(n) | Space O(1)
            int idxArr = 0;
            int idxSeq = 0;

            while (idxArr < array.Count && idxSeq < sequence.Count)
            {
                if (array[idxArr] == sequence[idxSeq])
                    idxSeq++;
                idxArr++;
            }
            return idxSeq == sequence.Count;


        }


        public static void Initial(string[] args)
        {
            List<int> array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            List<int> sequence = new List<int> { 1, 6, -1, 10 };

            IsValidSubsequence1(array, sequence);
        }
    }
}
