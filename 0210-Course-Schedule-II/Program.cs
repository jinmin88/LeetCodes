using System;
using System.Collections.Generic;

namespace _0210_Course_Schedule_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            for (int i = 0; i < numCourses; i++) { map.Add(i, new List<int>()); }
            for (int i = 0; i < prerequisites.Length; i++) { map[prerequisites[i][1]].Add(prerequisites[i][0]); }
            NodeStatus[] ns = new NodeStatus[numCourses];
            List<int> orderedList = new List<int>();

            for (int i=0; i<numCourses; i++)
            {
                if (DFS(map, ns, orderedList, i) == true)
                {
                    return new int[] { };
                }
            }
            return orderedList.ToArray();
        }

        private bool DFS(Dictionary<int, List<int>> map, NodeStatus[] ns, List<int> orderedList, int node)
        {
            if (ns[node] == NodeStatus.Visited) return false;
            if (ns[node] == NodeStatus.Visiting) return true;
            ns[node] = NodeStatus.Visiting;
            foreach (var neighbor in map[node])
            {
                if (DFS(map, ns, orderedList, neighbor) == true)
                {
                    return true;
                }
            }
            ns[node] = NodeStatus.Visited;
            orderedList.Insert(0, node);
            return false;
        }



        private enum NodeStatus
        {
            Unmarked = 0,
            Visiting = 1,
            Visited = 2,
            Cycle = 3
        }
    }
}
