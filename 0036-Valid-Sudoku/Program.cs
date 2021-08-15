using System;
using System.Collections.Generic;

namespace _0036_Valid_Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] m = new char[9][];
            m[0] = new char[9] { '5', '3', '.', '.', '7', '.', '.', '.', '.' };
            m[1] = new char[9] { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
            m[2] = new char[9] { '.', '9', '8', '.', '.', '.', '.', '6', '.' };
            m[3] = new char[9] { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
            m[4] = new char[9] { '4', '.', '.', '8', '.', '3', '.', '.', '1' };
            m[5] = new char[9] { '7', '.', '.', '.', '2', '.', '.', '.', '6' };
            m[6] = new char[9] { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
            m[7] = new char[9] { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
            m[8] = new char[9] { '.', '.', '.', '.', '8', '.', '.', '7', '9' };

            Solution sol = new Solution();
            bool isValid = sol.IsValidSudoku(m);
            Console.WriteLine("is_valid of m=" + isValid);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            var set = new HashSet<char>();
            //1. 檢查所有的列
            for (int row = 0; row < board.Length; row++)
            {
                set.Clear();
                for (int col = 0; col < board[row].Length; col++)
                {
                    if (board[row][col] != '.')
                    {
                        if (set.Contains(board[row][col]))
                            return false;
                        else
                            set.Add(board[row][col]);
                    }
                }
            }

            //2. 檢查所有欄
            set.Clear();
            for (int col = 0; col < board[0].Length; col++)
            {
                set.Clear();
                for (int row = 0; row < board.Length; row++)
                {
                    if (board[row][col] != '.')
                    {
                        if (set.Contains(board[row][col]))
                            return false;
                        else
                            set.Add(board[row][col]);
                    }
                }
            }
            //3. 檢查所有的九宮格
            for (int i=0; i<3; i++)
            {
                for (int j=0; j<3; j++)
                {
                    set.Clear();

                    int row_start = i * 3;
                    int col_start = j * 3;

                    for (int row = row_start; row < row_start+3; row++)
                    {
                        for (int col = col_start; col < col_start+3; col++)
                        {
                            if (board[row][col] != '.')
                            {
                                if (set.Contains(board[row][col]))
                                    return false;
                                else
                                    set.Add(board[row][col]);
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}
