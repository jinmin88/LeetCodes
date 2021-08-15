using System;
using System.Collections.Generic;

namespace _0054_Spiral_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[5, 5] {
                { 1,   2,  3,  4,  5 },
                { 6,   7,  8,  9, 10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25 }
            };

            //int[,] m = new int[2, 1] { { 3 }, { 2 } };

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j].ToString().PadLeft(3, ' '));
                }
                Console.WriteLine();
            }
            Solution sol = new Solution();
            var l = sol.SpiralOrder(m);

            foreach (var item in l)
            {
                Console.Write(item.ToString().PadLeft(3, ' '));
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int rowStart = 0;
            int rowEnd = rows - 1;
            int colStart = 0;
            int colEnd = cols - 1;

            List<int> l = new List<int>();
            while ((rowStart <= rowEnd) && (colStart <= colEnd))
            {
                var newL = GenerateSpiralOrder(matrix, rowStart, rowEnd, colStart, colEnd);
                l.AddRange(newL);
                rowStart++; rowEnd--; colStart++; colEnd--;
            }
            return l;

        }

        private List<int> GenerateSpiralOrder(int[,] matrix, int rowStart, int rowEnd, int colStart, int colEnd)
        {
            List<int> l = new List<int>();
            if (rowStart < rowEnd && colStart < colEnd)
            {
                for (int i = colStart; i <= colEnd; i++)
                {
                    l.Add(matrix[rowStart, i]);
                }
                for (int i = rowStart + 1; i <= rowEnd; i++)
                {
                    l.Add(matrix[i, colEnd]);
                }
                for (int i = colEnd - 1; i >= colStart + 1; i--)
                {
                    l.Add(matrix[rowEnd, i]);
                }
                for (int i = rowEnd; i >= rowStart + 1; i--)
                {
                    l.Add(matrix[i, colStart]);
                }
            }
            else if (rowStart == rowEnd && colStart < colEnd)
            {
                for (int i = colStart; i<=colEnd; i++)
                {
                    l.Add(matrix[rowStart, i]);
                }
            }
            else if (rowStart < rowEnd && colStart == colEnd)
            {
                for (int i = rowStart; i<= rowEnd; i++)
                {
                    l.Add(matrix[i, colStart]);
                }
            }
            else
            {
                l.Add(matrix[rowStart, colStart]);
            }
            return l;

        }


    }


}
