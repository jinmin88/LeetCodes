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
            DFS(graph, 1);
            Console.ReadKey();
        }

        private static void DFS(Graph<int> graph, int start)
        {
            var visited = new HashSet<int>();

            if (!graph.AdjancyList.ContainsKey(start))
                return;

            var stack = new Stack<int>();
            stack.Push(start);
            while (stack.Count > 0)
            {
                var vertex = stack.Pop();

                if (visited.Contains(vertex))
                    Console.Write(vertex + "->");                                                                                                                                                                                                                                                                       )

               

            }
            LinkedList<int> aa = new LinkedList<int>();
            

        }
    }


}
