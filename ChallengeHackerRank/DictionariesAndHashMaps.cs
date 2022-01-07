using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank
{
    public static class DictionariesAndHashMaps
    {
        // Complete the freqQuery function below.
        /*
8
1 5
1 6
3 2
1 10
1 10
1 6
2 5
3 2
         */
        static List<int> freqQuery(List<List<int>> queries)
        {
            var retList = new List<int>();
            Dictionary<int, int> hash = new Dictionary<int, int>();

            int maxFr = 0;
            for(int i = 0; i < queries.Count;i++)
            {
                int op = queries[i][0];
                int num = queries[i][1];

                hash.TryGetValue(num, out int valAux);

                if(op == 1)
                {
                    hash[num] = ++valAux;
                    maxFr = Math.Max(maxFr, valAux);
                } else if (op == 2)
                {
                    if(valAux > 0)
                    {
                        hash[num] = --valAux;
                    }
                } else
                {
                    if (num <= maxFr && hash.ContainsValue(num)) retList.Add(1);
                    else retList.Add(0);
                }
            }
            return retList;




            // O método abaixoo funciona porém tem baixa performance. Testa de alta carga de dados demora para executar.


            //for (int i = 0; i < queries.Count; i++)
            //{
            //    int op = queries[i][0];
            //    int num = queries[i][1];

            //    if (op == 1)
            //    {
            //        if (!hash.ContainsKey(num))
            //            hash.Add(num, 1);
            //        else
            //        {
            //            hash.TryGetValue(num, out int valAux);
            //            hash.Remove(num);
            //            hash.Add(num, valAux + 1);
            //        }
            //    }
            //    else if (op == 2)
            //    {
            //        if (hash.ContainsKey(num))
            //        {
            //            hash.TryGetValue(num, out int value);
            //            if (value <= 1)
            //                hash.Remove(num);
            //            else
            //            {
            //                hash.TryGetValue(num, out int valAux);
            //                hash.Remove(num);
            //                hash.Add(num, valAux - 1);
            //            }
            //        }

            //    }
            //    else if (op == 3)
            //    {
            //        if (hash.ContainsValue(num))
            //        {
            //            retList.Add(1);
            //        }
            //        else
            //            retList.Add(0);

            //    }
            //}

            //return retList;

        }

        public static void Initial(string[] args)
        {

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            List<int> ans = freqQuery(queries);

            Console.WriteLine(String.Join("\n", ans));

        }
    }
}
