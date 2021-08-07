using System;
using System.Linq;
using System.Collections.Generic;

namespace Palindrome_Partition_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine("bb=" + sol.MinCut("bb"));
        }
    }


    public class Solution
    {
        public int MinCut(string s)
        {
            int n = s.Length;
            
            //P是用來記錄str[i,j]是否為迴文
            bool[,] P = new bool[n, n];

            //C是用來記錄str[0..i]最小幾個cut
            int[] C = new int[n];

            //先設定P陣列為回文
            for (int i=0; i<n; i++)
            {
                P[i, i] = true;
            }

            for (int len = 2; len<=n; len++)
            {
                for (int i=0; i<n-len+1; i++)
                {
                    int j = i + len - 1;
                    if (len == 2)
                    {
                        P[i, j] = s[i] == s[j];
                    }
                    else
                    {
                        P[i, j] = P[i + 1, j - 1] && (s[i] == s[j]);
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                //假設str[0, i]為回文，則設定minimum cut C[i]為0
                if (P[0, i] == true) {
                    C[i] = 0;
                }
                else
                {
                    //先設定C[i]為max value
                    C[i] = int.MaxValue;
                    
                    //判斷 str[0..i] , str[1..i], str[2..i]是否為回文
                    //    
                    for (int j=0; j<i; j++)
                    {
                        //從j處切
                        if (P[j+1, i] == true)
                        {
                            C[i] = Math.Min(C[i], 1 + C[j]);
                        }
                    }

                }
            }

            return C[n - 1];
        }


    }
}
