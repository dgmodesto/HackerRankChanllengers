using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class DepthFirstSearch
    {
		public class NodeDFS1
		{
			public string name;
			public List<NodeDFS1> children = new List<NodeDFS1>();

			public NodeDFS1(string name)
			{
				this.name = name;
			}

			// Complexity O(v + e) | Space O(v)
			public List<string> DepthFirstSearch(List<string> array)
			{
				// Write your code here.
				array.Add(name);
				foreach (NodeDFS1 item in children)
				{
					array = item.DepthFirstSearch(array);
				}

				return array;
			}

			public NodeDFS1 AddChild(string name)
			{
				NodeDFS1 child = new NodeDFS1(name);
				children.Add(child);
				return this;
			}
		}

		public class NodeDFS2
		{
			public string name;
			public List<NodeDFS2> children = new List<NodeDFS2>();

			public NodeDFS2(string name)
			{
				this.name = name;
			}

			public List<string> DepthFirstSearch(List<string> array)
			{
				// Write your code here.

				array.Add(name);
				foreach (var item in children)
				{
					array.Add(item.name);
					if (item.children.Count > 0)
					{
						array = _DepthFirstSearch(array, item.children);
					}
				}
				return array;
			}


			private List<string> _DepthFirstSearch(List<string> array, List<NodeDFS2> childrens)
			{
				if (childrens != null)
				{
					for (int i = 0; i < childrens.Count; i++)
					{
						array.Add(childrens[i].name);
						_DepthFirstSearch(array, childrens[i].children);
					}

				}
				return array;
			}

			public NodeDFS2 AddChild(string name)
			{
				NodeDFS2 child = new NodeDFS2(name);
				children.Add(child);
				return this;
			}
		}

		public class NodeDFS3
		{
			public string name;
			public List<NodeDFS3> children = new List<NodeDFS3>();

			public NodeDFS3(string name)
			{
				this.name = name;
			}

			public List<string> DepthFirstSearch(List<string> array)
			{
				// Write your code here.
				Stack<NodeDFS3> nodeStack = new Stack<NodeDFS3>();
				nodeStack.Push(this);

				while (nodeStack.Count > 0)
				{
					var currNode = nodeStack.Pop();
					array.Add(currNode.name);
					for (int i = currNode.children.Count - 1; i >= 0; i--)
					{
						nodeStack.Push(currNode.children[i]);
					}
				}
				return array;
			}

			public NodeDFS3 AddChild(string name)
			{
				NodeDFS3 child = new NodeDFS3(name);
				children.Add(child);
				return this;
			}
		}

		public static void Initial(string [] args )
        {
			NodeDFS1 graph = new NodeDFS1("A");
			graph.AddChild("B").AddChild("C").AddChild("D");
			graph.children[0].AddChild("E").AddChild("F");
			graph.children[2].AddChild("G").AddChild("H");
			graph.children[0].children[1].AddChild("I").AddChild("J");
			graph.children[2].children[0].AddChild("K");
			string[] expected = { "A", "B", "E", "F", "I", "J", "C", "D", "G", "K", "H" };
			List<string> inputArray = new List<string>();
			inputArray = graph.DepthFirstSearch(inputArray);

			Console.WriteLine("Expected");
			Array.ForEach(expected, Console.Write);
			Console.WriteLine();
			Console.WriteLine("Actual");
			Array.ForEach(inputArray.ToArray(), Console.Write);
		}

    }
}
