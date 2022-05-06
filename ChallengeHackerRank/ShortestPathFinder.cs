using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace ChallengeHackerRank
{
    public static class ShortestPathFinder
    {

        public class Node
        {
            
            public string Name { get; set; }
            public int Weigth { get; set; }


            public Node(string name)
            {
                Name = name;
                Edges = new List<Edge>();
            }

            public List<Edge> Edges { get; set; }

            public IEnumerable Neighbors =>
              from edge in Edges
              select new NeighborhoodInfo(
                  edge.Node1 == this ? edge.Node2 : edge.Node1,
                  edge.Value
                  );


            public void Assign(Edge edge)
            {
                Edges.Add(edge);
            }


            public void ConnectTo(Node other, int connectionValue)
            {
                Edge.Create(connectionValue, this, other);
            }


            public struct NeighborhoodInfo
            {
                public Node Node { get; }
                public int WeightToNode { get; }

                public NeighborhoodInfo(Node node, int weightToNode)
                {
                    Node = node;
                    WeightToNode = weightToNode;
                }
            }


            public class Edge
            {
                public int Value { get; }
                public Node Node1 { get; }
                public Node Node2 { get; }

                public Edge(int value, Node node1, Node node2)
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("Edge value needs to be positive.");
                    }
                    Value = value;
                    Node1 = node1;
                    node1.Assign(this);
                    Node2 = node2;
                    node2.Assign(this);
                }

                public static Edge Create(int value, Node node1, Node node2)
                {
                    return new Edge(value, node1, node2);
                }
            }

        }


        public static List<Node> FindShortestPath(Node @from, Node to)
        {
            var bestPath = new List<Node>();
            Node MinNeig = @from;
            Node FromAux = @from;

            while (to.Name != MinNeig.Name)
            {
                var minWay = int.MaxValue ;
                foreach(var edge in FromAux.Edges)
                {
                    if( minWay > edge.Value)
                    {
                        MinNeig = edge.Node2;
                        minWay = edge.Value;
                    }
                
                }

                MinNeig.Weigth += minWay;
                FromAux = MinNeig;
                bestPath.Add(MinNeig);
            }




            return bestPath;
        }


        public static void Initial (string [] args)
        {
            var a = new Node("A");
            var b = new Node("B");
            var c = new Node("C");
            var d = new Node("D");
            var e = new Node("E");
            var f = new Node("F");
            var g = new Node("G");

            a.ConnectTo(b, 4);
            a.ConnectTo(c, 3);
            a.ConnectTo(d, 6);

            b.ConnectTo(e, 14);
            b.ConnectTo(f, 9);

            c.ConnectTo(f, 7);

            d.ConnectTo(f, 2);

            f.ConnectTo(g, 1);
            
            f.ConnectTo(g, 3);

            var result = FindShortestPath(a, g);

        }
    }
}
