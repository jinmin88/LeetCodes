using System;

namespace _0074_Search_a_2D_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] m = new int[3][];
            m[0] = new int[] { 1, 3, 5, 7 };
            m[1] = new int[] { 10, 11, 16, 20 };
            m[2] = new int[] { 23, 30, 34, 60 };
            Solution sol = new Solution();
            bool find3 = sol.SearchMatrix(m, 3);
            bool find8 = sol.SearchMatrix(m, 8);
            Console.WriteLine("find 3 = " + find3);
            Console.WriteLine("find 8 = " + find8);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int low = 0;
            int high = matrix.Length * matrix[0].Length - 1;
            int cols = matrix[0].Length;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int rowIdx = mid / cols;
                int colIdx = mid % cols;
                if (matrix[rowIdx][colIdx] == target)
                {
                    return true;
                }
                else if (matrix[rowIdx][colIdx] > target)
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
