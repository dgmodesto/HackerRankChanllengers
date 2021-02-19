using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class FindTheRunningMedian
    {
        /*
         por algum motivo essa implementação com grande carga de dados, apresenta problemas com timeout

         resolvi achando uma solução em python
        import bisect
        n=int(input())
        a=[]
        for i in range(n):
            p=int(input())
            bisect.insort(a,p)
            if len(a)%2!=0:
                print(a[len(a)//2])
            else:
                print((a[len(a)//2]+a[len(a)//2-1])/2)
         */
        static double[] runningMedian(int[] a)
        {
            var result = new List<double>();
            var arrAux = new List<double>();

            for (int i = 0; i < a.Length; i++)
            {
                arrAux.Add(a[i]);
                arrAux.Sort();

                int size = arrAux.Count;
                int mid = size / 2;
                double midian = (size % 2 != 0) ?
                    arrAux[mid] :
                    (arrAux[mid] + arrAux[mid - 1]) / 2;

                result.Add(midian);
            }

            return result.ToArray<double>();
        }

        public static List<int> QuickSort(List<int> vet)
        {
            int inicio = 0;
            int fim = vet.Count - 1;

            QuickSort(vet, inicio, fim);

            return vet;
        }

        private static void QuickSort(List<int> vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;

                while (i <= f)
                {
                    if (vetor[i] <= p)
                    {
                        i++;
                    }
                    else if (p < vetor[f])
                    {
                        f--;
                    }
                    else
                    {
                        int troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }

                vetor[inicio] = vetor[f];
                vetor[f] = p;

                QuickSort(vetor, inicio, f - 1);
                QuickSort(vetor, f + 1, fim);
            }
        }


        public static void Initial(string[] args)
        {

            var result = new List<double>();
            var arrAux = new List<int>();
            int aCount = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[aCount];

            for (int aItr = 0; aItr < aCount; aItr++)
            {
                int aItem = Convert.ToInt32(Console.ReadLine());
                a[aItr] = aItem;
                arrAux.Add(aItem);
                arrAux = QuickSort(arrAux);

                if (arrAux.Count % 2 != 0)
                    Console.WriteLine((double)arrAux[arrAux.Count / 2]);
                else
                    Console.WriteLine((double)(arrAux[arrAux.Count / 2] + arrAux[arrAux.Count / 2 - 1]) / 2);
            }

            //Console.WriteLine(string.Join("\n", result));
        }
    }
}
