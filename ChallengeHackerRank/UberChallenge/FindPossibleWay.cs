using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.UberChallenge
{
    
  
    public static  class FindPossibleWay
    {

        /*
         map:
             [
              [1,  1,  1], 
              [1, -1,  1],
              [1,  1,  1 ]
             ] 
            
            [2, 2] start point
            [0, 0]end point
            
            bool 
            4 direction vertical and horizontal        


            constraints 
            - respect the limits 
            - map never empty 


    */
        

        public class Graph<T>
        {
           
            public Dictionary<T, HashSet<T>> AdjacencyList { get; } = new Dictionary<T, HashSet<T>>();

            public Graph() { }

            public Graph(IEnumerable<T> vertices, IEnumerable<Tuple<T, T>> edges)
            {
                foreach (var vertex in vertices)
                    AddVertex(vertex);

                foreach (var edge in edges)
                    AddEdges(edge);
            }

            private void AddVertex(T vertex)
            {
                AdjacencyList[vertex] = new HashSet<T>();
            }
            private void AddEdges(Tuple<T, T> edge)
            {
                if(AdjacencyList.ContainsKey(edge.Item1) && AdjacencyList.ContainsKey(edge.Item2) ){
                    AdjacencyList[edge.Item1].Add(edge.Item2);
                    AdjacencyList[edge.Item2].Add(edge.Item1);
                }
            }

        }


     

        private static int [][] getDirections()
        {
            var up = new int[] { 1, 0 };
            var down = new int[] { -1, 0 };
            var left = new int[] { 0, -1 };
            var right = new int[] { 0, 1 };
            int[][] directions = new int[][] { up, left, down, right };
            return directions;
        }


        public static bool FindTheWay(int [] [] map, string startPoint, string endPoint)
        {
            int[][] directions = getDirections();

            //This kind of problem can be solve with BFS


            return false;
        }


        public static void Initial(string[] args)
        {
            int[][] map = new int[][] { 
              new int[] { 1,  1, 1 },
              new int[] { 1, -1, 1 },
              new int[] { 1, -1, 1 },
            };

            var vertices = new[] { "00", "01", "02", "10", "11", "12", "20", "21", "22" };

            string startPoint = "22";
            string endPoint = "00";

            /*
                        00

                    01      10
                    
                 02    11 12     
             
             */

            var edges = new[] {
                Tuple.Create("00", "01"),  Tuple.Create("00", "10"), 
                Tuple.Create("01", "11"),  Tuple.Create("01", "11"), Tuple.Create("11", "21"), 
                Tuple.Create("11", "21"), Tuple.Create("11", "12"),
            };


            var graph = new Graph<string>(vertices, edges);
            var result = FindTheWay(map, startPoint, endPoint);


            Console.WriteLine("Expected: true");
            Console.WriteLine($"Actual: { result }");

        }

    }
}
