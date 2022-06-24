using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank.Sorting
{
    public static class Sorting
    {
        #region MergeSort



        private static int[] Merge(int[] list, int start, int mid, int end)
        {
            int n = list.Count();
            int[] left = list[start..mid];
            int[] right = list[mid..end];
            int topLeft = 0, topRight = 0;

            for (int i = start; i < end; i++)
            {
                if(topLeft >= left.Count())
                {
                    list[i]= right[topRight];
                    topRight++;
                } else if (topRight >= right.Count())
                {
                    list[i] = left[topLeft];
                    topLeft++;
                } else if( left[topLeft] < right[topRight] )
                {
                    list[i] = left[topLeft];
                    topLeft++;
                } else
                {
                    list[i] = right[topRight];
                    topRight++;
                }
            }

            return list;

        }

        public static int[] MergeSort(int[] list, int start = 0, int end = -1)
        {
            if (end< 0) end = list.Length;
            if(end - start > 1)
            {
                var mid = (end + start)/ 2;
                MergeSort(list, start, mid);
                MergeSort(list, mid, end);
                list = Merge(list, start, mid, end);
            }

            return list;

        }

        #endregion

        #region InsertionSort
        public static int [] InsertionSort(int [] list)
        {
            int n = list.Length; 

            for(int i = 1; i < n; i++)
            {
                int key = list[i];
                int j = i - 1;
                while(j >= 0 && list[j] > key)
                {
                    list[j+1] = list[j];
                    j--;
                }
                list[j+1] = key;
            }
            return list;
        }
        /*
            # Complexidade de tempo O(nˆ2)
            # Complexidade de espaço O(n)
         */
        #endregion

        #region BubbleSort
        public static int [] BubbleSort(int [] list)
        {
            var n = list.Length;

            for(int i = 0; i < n-1; i++)
                for(int j = 0; j < n-1; j++)
                {
                    if(list[j] > list[j+1])
                    {
                        var aux = list[j];
                        list[j] = list[j+1];
                        list[j+1] = aux;
                    }
                }

            return list;
        }
        /*
            Complexidade de tempo O(nˆ2) 
            Complexidade de espaço O(n)
         */
        #endregion

        #region Selection Sort
        private static int [] SelectionSort(int [] list)
        {
            var n = list.Length;
            for(int i = 0; i < n-1; i++)
            {
                var minIndex = i;
                for(int j = i+1; j < n; j++)
                {
                    if(list[j] < list[minIndex])
                        minIndex = j;
                }

                if(list[i] > list[minIndex])
                {
                    int aux = list[i];
                    list[i] = list[minIndex];
                    list[minIndex] = aux;
                }
            }

            return list;
        }
        /* 
            1 + (n-1)*[5 + X] = 1 + 5*(n-1) + X*(n-1)
            Complexidade de tempo O(nˆ2)
            Complexidade de espaço O(n)
        */
        #endregion


        public static void Initial(string [] args)
        {
            var randon = new Random(77);
            var list = new List<int>();
            for (int i = 1; i < 42; i++)
            {
                var value = randon.Next(0, 50);
                list.Add(value);
            }
            var any_numbers = list.Distinct().ToArray();

            var already_sorted = new int[] {1, 2, 3, 4, 5, 6, 9, 20, 22, 23, 28,
                    32, 34, 39, 40, 42, 76, 87, 99, 112};

            var inversed = new int[] {117, 90, 88, 83, 81, 77, 74, 69, 64, 63, 51,
            50, 49, 42, 41, 34, 32, 29, 28, 22, 16, 8, 6, 5, 3, 1 };

            var repeated = new int[] { 7, 7, 7, 7, 7, 1, 1, 9, 9, 0, 4, 4, 4, 5, 4, 5, 7, 1, };


            var test_Cases = new Dictionary<string, int[]>();

            test_Cases.Add("Números aleatórios", any_numbers);
            test_Cases.Add("Já ordenados", already_sorted);
            test_Cases.Add("Ordem inversa", inversed);
            test_Cases.Add("Elementos repetidos", repeated);

            Console.WriteLine("*************************************************************");

            foreach(var cases in test_Cases)
            {
                Console.WriteLine($"Case de Teste: { cases.Key}");
                PrintList(cases.Value);
                var listOrdered = MergeSort(cases.Value);
                Console.WriteLine("Ordenados");
                PrintList(listOrdered);
                Console.WriteLine();
            }

            Console.WriteLine("*************************************************************");
        }

        private static void PrintList(int [] list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
