using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.Graphs
{

    public class Graph<T>
    {
        public Dictionary<T, HashSet<T>> AdjacencyList { get; } = new Dictionary<T, HashSet<T>>();

        public Graph() { }
        public Graph(IEnumerable<T> vertices, IEnumerable<Tuple<T, T>> edges)
        {
            foreach (var vertex in vertices)
                AddVertex(vertex);
            
            foreach (var edge in edges)
                AddEdge(edge);
        }
        private void AddVertex(T vertex)
        {
            AdjacencyList[vertex] = new HashSet<T>();
        }

        private void AddEdge(Tuple<T, T> edge)
        {
            if(AdjacencyList.ContainsKey(edge.Item1) && AdjacencyList.ContainsKey(edge.Item2))
            {
                AdjacencyList[edge.Item1].Add(edge.Item2);
                AdjacencyList[edge.Item2].Add(edge.Item1);
            }
        }

    }


    public static class GraphExample
    {
        /*
            1
          /   \
        2      3
      /      /   \
     4      5  -  6
      \   /   \
        7       8
              /   \
             9  - 10

         
         */
        
        /*Breadth-First Search and Shortes Path */
        public static HashSet<T> BFS<T>(Graph<T> graph, T start)
        {
            var visited = new HashSet<T>();

            if(!graph.AdjacencyList.ContainsKey(start))
                return visited; 

            var queue = new Queue<T>();
            queue.Enqueue(start);

            while(queue.Count > 0)
            {
                var vertex = queue.Dequeue();

                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach(var neighboor in graph.AdjacencyList[vertex])
                {
                    if (!visited.Contains(neighboor))
                        queue.Enqueue(neighboor);
                }
            }

            return visited;
        }

        public static void Initial(string [] args)
        {
            var vertices = new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var edges = new[] {
                Tuple.Create(1,2), Tuple.Create(1,3),Tuple.Create(2,4),
                Tuple.Create(3,5), Tuple.Create(3,6),Tuple.Create(5,6),
                Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
                Tuple.Create(8,9), Tuple.Create(8,10), Tuple.Create(9,10)
            };
            /*
             Representation Graph above
                        1
                      /   \
                    2      3
                  /      /   \
                 4      5  -  6
                  \   /   \
                    7       8
                          /   \
                         9  - 10
             */

            var graph = new Graph<int>(vertices, edges);
            var result = BFS(graph, 3);

            Console.WriteLine("Expected: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
            Console.WriteLine("Actual:   " + String.Join(", ", result));
        }


    }
}
