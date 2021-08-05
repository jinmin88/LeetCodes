using System;
using System.Collections.Generic;

namespace _0547_Number_Of_Provinces
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] isConnected = new int[][]
            {
                new int[] {1, 1, 0 },
                new int[] {1, 1, 0 },
                new int[] {0, 0, 1 }
            };

            Solution sol = new Solution();
            Console.WriteLine("result=" + sol.FindCircleNum(isConnected));

        }
    }

    public class Solution
    {
        public int FindCircleNum(int[][] isConnected)
        {
            bool[] visited = new bool[isConnected.Length];
            for (int i=0; i<visited.Length; i++)
            {
                visited[i] = false;
            }

            int total = 0;

            Stack<int> stack = new Stack<int>();
            for (int start=0; start<isConnected.Length; start++)
            {
                if (visited[start] == true)
                    continue;
                stack.Clear();
                stack.Push(start);
                while (stack.Count > 0)
                {
                    int item = stack.Pop();
                    if (visited[item] == true)
                        continue;
                    visited[item] = true;
                    for (int neighbor = 0; neighbor < isConnected[item].Length; neighbor++)
                    {
                        if (isConnected[item][neighbor] == 1)
                        {
                            stack.Push(neighbor);
                        }
                    }
                }
                total++;
            }
            return total;
        }

    }
}
