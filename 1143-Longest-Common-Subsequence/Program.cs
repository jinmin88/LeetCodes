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
            X1,X2,X3,...,Xm
            Y1,Y2,Y3,...,Yn

            if (X[i] == Y[j]) {
                m[i][j] = m[i-1][j-1]
            }
            else {
                max(m[i-1][j]
            }


         */ 

        public int LongestCommonSbusequence(string text1, string text2)
        {
            int[][] m = new int[text1.Length + 1][];
            for (int i=0; i<m.Length; i++)
            {
                m[i] = new int[text2.Length + 1];
                Array.Fill(m[i], 0);
            }

            int max = int.MinValue;
            for (int i=1; i<=text1.Length; i++)
            {
                for (int j=1; j<text2.Length; j++)
                {
                    if (text1[i-1] == text1[j-1])
                    {
                        m[i][j] = m[i - 1][j - 1] + 1;
                    }
                    else
                    {
                        m[i][j] = Math.Max(m[i - 1][j], m[i][j - 1]);
                    }
                    max = Math.Max(max, m[i][j]);
                }
            }
            return max;

        }

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
