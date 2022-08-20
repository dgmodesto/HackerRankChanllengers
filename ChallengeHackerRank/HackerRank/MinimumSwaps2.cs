using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public class MinimumSwaps2
    {
        /*
        - You are given an unordered array consisting of consecutive integers E[1,2,3,...] without any duplicates.
        - You ara allowed to swap any two elements.
        - You need to find the minimum number of swaps required to sort the array in ascending order.
        - For example, given the array arr = [7,1,3,2,4,5,6] we perform the following steps:
            - i   arr                     swap (indices)
            - 0   [7, 1, 3, 2, 4, 5, 6]   swap (0,3)
            - 1   [2, 1, 3, 7, 4, 5, 6]   swap (0,1)
            - 2   [1, 2, 3, 7, 4, 5, 6]   swap (3,4)
            - 3   [1, 2, 3, 4, 7, 5, 6]   swap (4,5)
            - 4   [1, 2, 3, 4, 5, 7, 6]   swap (5,6)
            - 5   [1, 2, 3, 4, 5, 6, 7]
         -It look 5 swaps to sort the array.

        - Input
4
4 3 1 2
        - Output
3


         */
        public static void Initial(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int res = MinimumSwaps(arr);

            Console.WriteLine(res);
        }

        private static int MinimumSwaps(int[] arr)
        {
            int swap = 0;
            // intera em todo o array
            for (int i = 0; i < arr.Length; i++)
            {
                /*
                    -  È uma boa prática usar uma função guiada booleana em um loop For longo.
                    - While irá avaliar e SE a declaração for verdadeira, ela continuará
                    - Usei os valores consecutivos e crescentes para trocar por índice
                 */

                // quando o valor do array for igual a (i + 1) singifica que não tem mais trocas a serem feitas.
                // por exemplo se arr na posição 2, arr[2] = 3, então seria (2 == (2 + 1)) = 3
                while (arr[i] != (i + 1))
                {
                    //temp é o indice correto do arr[i]
                    // se arr[i] for igual a 4, em array devidamente organizado, o valor 4 ficaria na posição 3
                    // com isso podemos dizer que a posição de qualquer numero é o numero menos um, 4-1 = posição 3 no array
                    var temp = arr[i] - 1;
                    
                    var currentValue = arr[i];

                    // fazer o swap com qualquer elemente que esteja aonde arr[temp] está, isso vai continuar a troca até arr[i] == index + 1
                    arr[i] = arr[temp];
                    arr[temp] = currentValue;

                    // incrementar swapp
                    swap++;
                }
    
            }
            return swap;


        }
    }
}
