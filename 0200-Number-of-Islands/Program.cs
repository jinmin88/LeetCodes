using System;
using System.Collections.Generic;
using System.Linq;

namespace _0200_Number_of_Islands
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
        public int NumIslands(char[][] grid)
        {
            bool[][] visited = new bool[grid.Length][];
            for (int i=0; i<visited.Length; i++)
            {
                visited[i] = new bool[grid[i].Length];
                for (int j=0; j<visited[i].Length; j++)
                {
                    visited[i][j] = false;
                }
            }

            int numIslands = 0;
            for (int i = 0; i < visited.Length; i++)
            {
                for (int j = 0; j < visited[i].Length; j++)
                {
                    if (visited[i][j] == true)
                        continue;

                    if (grid[i][j] == '0')
                    {
                        visited[i][j] = true;
                        continue;
                    }
                    else
                    {
                        Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
                        stack.Push(new Tuple<int, int>(i, j));
                        while (stack.Count > 0)
                        {
                            var loc = stack.Pop();
                            if (loc.Item1 < 0 || loc.Item1 >= grid.Length)
                                continue;
                            if (loc.Item2 < 0 || loc.Item2 >= grid[0].Length)
                                continue;
                            if (visited[loc.Item1][loc.Item2] == true)
                            {
                                continue;
                            }
                            else
                            {
                                visited[loc.Item1][loc.Item2] = true;
                                if (grid[loc.Item1][loc.Item2] == '0')
                                {
                                    continue;
                                }
                                else
                                {
                                    stack.Push(new Tuple<int, int>(loc.Item1, loc.Item2 - 1));
                                    stack.Push(new Tuple<int, int>(loc.Item1, loc.Item2 + 1));
                                    stack.Push(new Tuple<int, int>(loc.Item1 - 1, loc.Item2));
                                    stack.Push(new Tuple<int, int>(loc.Item1 + 1, loc.Item2));
                                }
                            }
                        }
                        numIslands++;
                    }
                }
            }
            return numIslands;

        }
    }
}
