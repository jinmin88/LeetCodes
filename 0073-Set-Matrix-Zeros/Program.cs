using System;

namespace _0073_Set_Matrix_Zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[4] { 0, 1, 2, 0 };
            matrix[1] = new int[4] { 3, 4, 5, 2 };
            matrix[2] = new int[4] { 1, 3, 1, 5 };

            Solution sol = new Solution();
            sol.SetZeros(matrix);

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col].ToString().PadLeft(3, ' '));
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }

    public class Solution
    {

        public void SetZeros(int[][] matrix)
        {
            //因為matrix[0][0]為0的話，要判斷first row或first column本身是否有含0
            bool IsColumn = false;
            bool IsRow = false;
            for (int row=0; row<matrix.Length; row++)
            {
                if (matrix[row][0] == 0)
                {
                    IsColumn = true;
                    break;
                }
            }
            for (int col = 0; col < matrix[0].Length; col++)
            {
                if (matrix[0][col] == 0)
                {
                    IsRow = true;
                    break;
                }
            }



            //掃到0時，把firstRow, firstColumn都設定為0標記記號
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 0)
                    {
                        matrix[row][0] = 0;
                        matrix[0][col] = 0;
                    }
                }
            }

            //把非首row或首col的元素都設定一次
            for (int row = 1; row < matrix.Length; row++)
            {
                for (int col = 1; col < matrix[row].Length; col++)
                {
                    //matrix[row][col] = (matrix[row][0] == 0 ? 0 : (matrix[0][col] == 0 ? 0 : matrix[row][col]))
                    matrix[row][col] = matrix[row][0] == 0 ? 0 : (matrix[0][col] == 0 ? 0 : matrix[row][col]);
                }
            }

            if (IsRow)
            {
                for (int col = 0; col < matrix[0].Length; col++)
                {
                    matrix[0][col] = 0;
                }
            }
            if (IsColumn)
            {
                for (int row = 0; row < matrix.Length; row++)
                {
                    matrix[row][0] = 0;
                }
            }


        }
    }
}
