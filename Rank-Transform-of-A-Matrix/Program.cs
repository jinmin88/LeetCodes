using System;
using System.Collections.Generic;
using System.Linq;

namespace Rank_Transform_of_A_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[][] m = new int[2][];
            for (int i=0; i<m.Length; i++)
            {
                m[i] = new int[2];
            }
            m[0][0] = -37; m[0][1] = -50; m[0][2] =  -3; m[0][3] =  44;
            m[1][0] = -37; m[1][1] =  46; m[1][2] =  13; m[1][3] = -32;
            m[2][0] =  47; m[2][1] = -42; m[2][2] =  -3; m[2][3] = -40;
            m[3][0] = -17; m[3][1] = -22; m[3][2] = -39; m[3][3] =  24;
            */

            int[][] m = { new int[] {-24,-9,-14,-15,44,31,-46,5,20,-5,34}, new int[] {9,-40,-49,-50,17,40,35,30,-39,36,-49}, new int[] {-18,-43,-40,-5,-30,9,-28,-41,-6,-47,12}, new int[] { 11, 42, -23, 20, 35, 34, -39, -16, 27, 34, -15 }, new int[] { 32, 27, -30, 29, -48, 15, -50, -47, -28, -21, 38 }, new int[] { 45, 48, -1, -18, 9, -4, -13, 10, 9, 8, -41 }, new int[] { -42, -35, 20, -17, 10, 5, 36, 47, 6, 1, 8 }, new int[] { 3, -50, -23, 16, 31, 2, -39, 36, -25, -30, 37 }, new int[] { -48, -41, 18, -31, -48, -1, -42, -3, -8, -29, -2 }, new int[] { 17, 0, 31, -30, -43, -20, -37, -6, -43, 8, 19 }, new int[] { 42, 25, 32, 27, -2, 45, 12, -9, 34, 17, 32}};
            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < m[i].Length; j++)
                {
                    Console.Write(m[i][j].ToString().PadLeft(4, ' '));
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------");
            Solution sol = new Solution();
            var result = sol.MatrixRankTransform(m);
            for (int i=0; i<m.Length; i++)
            {
                for (int j=0; j<m[i].Length; j++)
                {
                    Console.Write(result[i][j].ToString().PadLeft(4, ' '));
                }
                Console.WriteLine();
            }
        }
    }

    public class Solution
    {
        public int[][] MatrixRankTransform(int[][] matrix)
        {
            var map = new Dictionary<int, List<List<Tuple<int, int>>>>();
            for (int y = 0; y < matrix.Length; y++)
            {
                for (int x = 0; x < matrix[y].Length; x++)
                {
                    if (!map.ContainsKey(matrix[x][y]))
                    {
                        map.Add(matrix[x][y], new List<List<Tuple<int, int>>>() { new List<Tuple<int, int>> { new Tuple<int, int>(x, y) } });
                    }
                    else
                    {
                        List<List<Tuple<int, int>>> sourceTuples = map[matrix[x][y]];
                        while (true)
                        {
                            var newTuple = new Tuple<int, int>(x, y);

                            foreach (var inner_list in sourceTuples)
                            {
                                if (inner_list.Any(a => a.Item1 == x || a.Item2 == y))
                                {
                                    inner_list.Add(new )
                                }
                            }


                        }

                    }
                }
            }


            var dict = new Dictionary<int, List<Tuple<int, int>>>();
            for (int row=0; row < matrix.Length; row++)
            {
                for (int col=0; col<matrix[row].Length; col++)
                {
                    if (!dict.ContainsKey(matrix[row][col]))
                    {
                        dict.Add(matrix[row][col], new List<Tuple<int, int>> { new Tuple<int, int>(row, col) });
                    }
                    else
                    {
                        dict[matrix[row][col]].Add(new Tuple<int, int>(row, col));
                    }
                }
            }

            int[][] result = new int[matrix.Length][];
            for (int i=0; i<matrix.Length; i++)
            {
                result[i] = new int[matrix[i].Length];
                for (int j = 0; j < result[i].Length; j++)
                {
                    result[i][j] = 0; //預設值為0 代表還沒設定
                }
            }

            List<List<Tuple<int, int>>> set = new List<List<Tuple<int, int>>>();
            HashSet<int> xmap = new HashSet<int>();
            HashSet<int> ymap = new HashSet<int>();
            int rowMax, colMax;
            foreach (var key in dict.Keys.OrderBy(a => a))
            {
                var locations = dict[key];                
                set.Clear();

                for (int i=0; i<locations.Count; i++)
                {
                    //以location[i]為出發點去找set
                    var compared_item = locations[i];
                    //如果location[i]已經處理過，則略過
                    if (SetContains(set, compared_item) == true) 
                        continue;
                    xmap.Clear();
                    ymap.Clear();
                    xmap.Add(compared_item.Item1);
                    ymap.Add(compared_item.Item2);

                    bool stop = false;
                    while (stop == false)
                    {
                        int before_x_count = xmap.Count;
                        int before_y_count = ymap.Count;

                        foreach (var loc in locations)
                        {
                            if (xmap.Contains(loc.Item1))
                            {
                                ymap.Add(loc.Item2);
                            }
                            if (ymap.Contains(loc.Item2))
                            {
                                xmap.Add(loc.Item1);
                            }
                        }

                        if (xmap.Count == before_x_count &&
                            ymap.Count == before_y_count)
                        {
                            stop = true;
                        }
                    }

                    foreach (var other_item in locations)
                    {
                        if (xmap.Contains(other_item.Item1))
                        {
                            ymap.Add(other_item.Item2);
                        }
                        if (ymap.Contains(other_item.Item2))
                        {
                            xmap.Add(other_item.Item1);
                        }
                    }
                    if (xmap.Count > 1 || ymap.Count > 1)
                    {
                        List<Tuple<int, int>> temp = new List<Tuple<int, int>>();
                        foreach (var x in xmap)
                        {
                            foreach (var y in ymap)
                            {
                                if (locations.Contains(new Tuple<int, int>(x, y)))
                                {
                                    temp.Add(new Tuple<int, int>(x, y));
                                }
                            }
                        }
                        set.Add(temp);
                    }
                    else
                    {
                        set.Add(new List<Tuple<int, int>> { new Tuple<int, int>(compared_item.Item1, compared_item.Item2) });
                    }
                }

                foreach (var inner_set in set)
                {
                    if (inner_set.Count > 1)
                    {
                        int localMax = int.MinValue;
                        foreach (var loc in inner_set)
                        {
                            rowMax = FindRowMax(result, loc.Item1, inner_set);
                            colMax = FindColMax(result, loc.Item2, inner_set);
                            localMax = Math.Max(localMax, Math.Max(rowMax, colMax) + 1);
                        }
                        foreach (var loc in inner_set)
                        {
                            result[loc.Item1][loc.Item2] = localMax;
                        }
                    }
                    else
                    {
                        rowMax = FindRowMax(result, inner_set.First().Item1, new List<Tuple<int, int>>() { inner_set.First() });
                        colMax = FindColMax(result, inner_set.First().Item2, new List<Tuple<int, int>>() { inner_set.First() });
                        result[inner_set.First().Item1][inner_set.First().Item2] = Math.Max(rowMax, colMax) + 1;
                    }
                }
            }

            return result;
        }

        private bool SetContains(List<List<Tuple<int, int>>> set, Tuple<int, int> item)
        {
            foreach (var list in set)
            {
                if (list.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }

        private int FindRowMax(int[][] m, int row, List<Tuple<int, int>> ignored)
        {
            int currentMax = 0;
            for (int i = 0; i <m[row].Length; i++)
            {
                if (ignored.Any(a => a.Item1 == row && a.Item2 == i))
                    continue;
                if (m[row][i] > currentMax)
                {
                    currentMax = m[row][i];
                }
            }
            return currentMax;
        }

        private int FindColMax(int[][] m, int col, List<Tuple<int, int>> ignored)
        {
            int currentMax = 0;
            for (int i=0; i<m[0].Length; i++)
            {
                if (ignored.Any(a => a.Item1 == i && a.Item2 == col))
                    continue;
                if (m[i][col] > currentMax)
                {
                    currentMax = m[i][col];
                }
            }
            return currentMax;
        }


        private List<List<Tuple<int, int>>> UnionElement(List<List<Tuple<int, int>>> set)
        {
            HashSet<int> x_set = new HashSet<int>();
            HashSet<int> y_set = new HashSet<int>();
            int orig_x_count = 0;
            int orig_y_count = 0;
            while (true)
            {
                orig_x_count = x_set.Count;
                orig_y_count = y_set.Count;
                foreach (var inner_set in set)
                {
                    foreach (var tuple in inner_set)
                    {
                        if (orig_x_count == 0 && orig_y_count == 0)
                        {
                            x_set.Add(tuple.Item1);
                            y_set.Add(tuple.Item2);
                        }
                        else
                        {
                            if (x_set.Contains(tuple.Item1))
                            {
                                y_set.Add(tuple.Item2);
                            }
                            if (y_set.Contains(tuple.Item2))
                            {
                                x_set.Add(tuple.Item1);
                            }
                        }
                    }
                }
                if (orig_x_count == x_set.Count && orig_y_count == y_set.Count)
                {
                    break;
                }
            }

            List<List<Tuple<int, int>>> result = new List<List<Tuple<int, int>>>();
            foreach (var inner_set in set)
            {
                foreach (var tuple in inner_set)
                {
                    if (x_set.Contains(tuple.Item1) && y_set.Contains(tuple.Item2))
                    {

                    }
                }
            }


        }
    }
}
