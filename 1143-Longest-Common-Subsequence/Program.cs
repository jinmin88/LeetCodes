using System;

namespace _1143_Longest_Common_Subsequence
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
        /*
            X = (x1, x2, x3, x4, ..., xm)
            Y = (y1, y2, y3, y4, ..., yn)

            if (xm = yn) then zk = xm = yn 


         */ 

        public int LongestCommonSubsequence(string text1, string text2)
        {
            int max = int.MinValue;
            int[][] m = new int[text1.Length+1][];
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = new int[text2.Length + 1];
            }
            for (int i = 1; i <= text1.Length; i++)
            {
                for (int j = 1; j<= text2.Length; j++)
                {
                    if (text1[i-1] == text2[j-1])
                    {
                        m[i][j] = m[i - 1][j - 1] + 1;
                    }
                    else
                    {
                        m[i][j] = Math.Max(m[i - 1][j], m[i][j - 1]);
                    }
                    if (m[i][j] > max) max = m[i][j];
                }
            }
            return max;

        }
    }
}
