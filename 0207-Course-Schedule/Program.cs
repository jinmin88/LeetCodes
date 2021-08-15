using System;
using System.Collections.Generic;
using System.Linq;

namespace _0207_Course_Schedule
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
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            for (int i=0; i<numCourses; i++)
            {
                map.Add(i, new List<int>());
            }
            for (int i=0; i<prerequisites.Length; i++)
            {
                map[prerequisites[i][1]].Add(prerequisites[i][0]);
            }

            NodeStatus[] ns = new NodeStatus[numCourses];
            for (int i=0; i<ns.Length; i++)
            {
                ns[i] = NodeStatus.UnMarked;
            }

            for (int i=0; i<numCourses; i++)
            {
                if (DFS(map, ns, i) == true)
                {
                    //有cycle則return false
                    return false;
                }
            }

            return true;
        }


        private bool DFS(Dictionary<int, List<int>> map, NodeStatus[] ns, int node)
        {
            if (ns[node] == NodeStatus.Visited) 
                return false;
            if (ns[node] == NodeStatus.Visiting)
                return true;
            ns[node] = NodeStatus.Visiting;
            foreach (var neighbor in map[node])
            {
                if (DFS(map, ns, neighbor) == true)
                {
                    return true;
                }
            }
            ns[node] = NodeStatus.Visited;
            return false;
        }


        private enum NodeStatus
        {
            UnMarked = 0,
            Visiting = 1,
            Visited = 2,
            Cycle = 3
        }

    }
}
