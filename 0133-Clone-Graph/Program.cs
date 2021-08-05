using ShareLib;
using System;
using System.Collections.Generic;

namespace _0133_Clone_Graph
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public Node CloneGraph(Node node)
        {
            if (node == null) return null;
            Dictionary<Node, Node> map = new Dictionary<Node, Node>();
            return DFS(node, map);
        } 

        private Node DFS(Node node, Dictionary<Node, Node> map)
        {
            if (map.ContainsKey(node)) return map[node];

            map.Add(node, new Node(node.val));
            var cloneNode = map[node];
            foreach (var nei in node.neighbors)
            {
                cloneNode.neighbors.Add(DFS(nei, map));
            }
            return cloneNode;

        }
    }
}
