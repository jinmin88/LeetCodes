using System;

namespace _0096_Unique_Binary_Search_Trees
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
        public int NumTrees(int n)
        {
            // dp[0] = 1;
            // dp[1] = 1;
            // dp[2] = dp[0]*dp[1] + dp[1]*dp[0] = 2
            // dp[3] = dp[0]*dp[2] + dp[1]*dp[1] + dp[2]*dp[0]=2+1+2=5
            // dp[i] = dp[0]*dp[n-1] + dp[1]*dp[n-2] + ... + dp[n-1]*dp[0]

            // dp[0] = 1;
            // dp[1] = 1;
            // dp[i] = dp[0]*dp[i-1] + dp[1]*dp[n-2]

            int[] arr = new int[n + 1];
            arr[0] = 1;
            arr[1] = 1;

            for (int i=2; i<=n; i++)
            {
                for (int j=0; j<i; j++)
                {
                    arr[i] += arr[j] * arr[i - j - 1];
                }
            }
            return arr[n];
        }
    }
}
