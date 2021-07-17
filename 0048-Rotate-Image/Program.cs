using System;

namespace _0048_Rotate_Image
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

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j].ToString().PadLeft(3, ' '));
                }
                Console.WriteLine();
            }
            Solution sol = new Solution();
            sol.Rotate(m);

            for (int i=0; i< m.GetLength(0); i++)
            {
                for (int j = 0; j<m.GetLength(1); j++)
                {
                    Console.Write(m[i, j].ToString().PadLeft(3, ' '));
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }


    public class Solution
    {
        public void Rotate (int[,] m)
        {
            int n = m.GetLength(0);

            for (int i = 0; i < n/2; i++)
            {
                for (int j=0; j < (n+1) / 2; j++)
                {
                    int temp = m[n - j - 1, i];
                    m[n - j - 1, i] = m[n - i - 1, n - j - 1];
                    m[n - i - 1, n - j - 1] = m[j, n - i - 1];
                    m[j, n - i - 1] = m[i, j];
                    m[i, j] = temp;
                }
            }

        }
    }
}
