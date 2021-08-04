using System;
using System.Collections.Generic;
using System.Text;

namespace ShareLib
{
    public class Graph<T>
    {
        public Graph() { }

        public Dictionary<T, HashSet<T>> AdjancyList { get; } = new Dictionary<T, HashSet<T>>();

        public Graph(IEnumerable<T> vertices, IEnumerable<Tuple<T, T>> edges)
        {
            foreach (var vertex in vertices)
            {
                AddVertex(vertex);
            }

            foreach (var edge in edges)
            {
                AddEdge(edge);
            }
        }

        public void AddVertex(T vertex)
        {
            AdjancyList[vertex] = new HashSet<T>();
        }

        public void AddEdge(Tuple<T,T> edge)
        {
            if (AdjancyList.ContainsKey(edge.Item1) && AdjancyList.ContainsKey(edge.Item2))
            {
                AdjancyList[edge.Item1].Add(edge.Item2);
                AdjancyList[edge.Item2].Add(edge.Item1);
            }
        }

    }
}
