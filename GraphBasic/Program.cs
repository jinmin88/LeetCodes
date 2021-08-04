using System;
using System.Collections.Generic;
using ShareLib;

namespace GraphBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var vertices = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var edges = new Tuple<int, int>[]
            {
                new Tuple<int, int>(1, 3),
                new Tuple<int, int>(2, 4),
                new Tuple<int, int>(3, 5),
                new Tuple<int, int>(3, 6),
                new Tuple<int, int>(4, 7),
                new Tuple<int, int>(5, 7),
                new Tuple<int, int>(5, 8),
                new Tuple<int, int>(5, 6),
                new Tuple<int, int>(8, 9),
                new Tuple<int, int>(9, 10)
            };
            var graph = new Graph<int>(vertices, edges);
            var result1 = DFS_With_Stack(graph, 1);
            foreach (var item in result1)
            {
                Console.Write($"{item} ");
            }



            Console.WriteLine();
            Console.ReadKey();
        }

        private static List<int> DFS_With_Stack(Graph<int> graph, int start)
        {
            var result = new List<int>();
            var visited = new HashSet<int>();

            //假設graph不存在start這個點，直接回傳空的結果
            if (!graph.AdjancyList.ContainsKey(start))
                return result;

            var stack = new Stack<int>();
            stack.Push(start);
            while (stack.Count > 0)
            {
                var vertex = stack.Pop();
                if (visited.Contains(vertex) == false)
                {
                    result.Add(vertex);
                    visited.Add(vertex);
                    var edges = graph.AdjancyList[vertex];
                    foreach (var edge in edges)
                    {
                        if (!visited.Contains(edge))
                            stack.Push(edge);
                    }
                }
            }
            return result;
        }

        private static List<int> DFS(Graph<int> graph, int start, HashSet<int> visited)
        {
            List<int> result = new List<int>();

            if (visited.Contains(start) == false)
            {
                result.Add(start);
                visited.Add(start);
                foreach (var neibor in graph.AdjancyList[start])
            }

        }

    }


}
