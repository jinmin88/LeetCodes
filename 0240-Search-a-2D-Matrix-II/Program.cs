using System;

namespace _0240_Search_a_2D_Matrix_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] m = new int[5][];
            m[0] = new int[] { 1, 4, 7, 11, 15 };
            m[1] = new int[] { 2, 5, 8, 12, 19 };
            m[2] = new int[] { 3, 6, 9, 16, 22 };
            m[3] = new int[] { 10, 13, 14, 17, 24 };
            m[4] = new int[] { 18, 21, 23, 26, 30 };

            Solution sol = new Solution();
            var sol5 = sol.SearchMatrix(m, 5);
            var sol20 = sol.SearchMatrix(m, 20);
            Console.WriteLine("search 5=" + sol5);
            Console.WriteLine("search 20=" + sol20);
            Console.ReadKey();
        }
    }

    public class Solution2
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;


            int i = rows - 1, j = 0;
            while (i >= 0 && j <= cols-1)
            {
                if (target > matrix[i][j])
                    j++;
                else if (target < matrix[i][j])
                    i--;
                else
                    return true;
            }
            return false;

        }
    }

    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            for (int i=0; i<matrix.Length; i++)
            {
                bool search = SearchMatrixRow(matrix, i, target);
                if (search == true) return true;
            }
            return false;
        }

        public bool SearchMatrixRow(int[][] matrix, int row, int target)
        {
            int cols = matrix[0].Length;
            int low = 0;
            int high = cols - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (matrix[row][mid] == target)
                {
                    return true;
                }
                else if (matrix[row][mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return false;

        }

    }
}
