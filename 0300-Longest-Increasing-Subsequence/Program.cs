using System;

namespace _0300_Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 10, 4, 3, 8 , 9 };
            Solution sol = new Solution();
            int k = sol.LengthOfLIS(nums);
            Console.WriteLine("example 1=" + k);

        }
    }

    public class Solution
    {
        public int LengthOfLIS(int[] nums)
        {
            // L(i) = 1 + max(L(j)) where 0<j<i and arr[j] < arr[i]
            // L(i) = 1 , if len = 1;

            //ie. arr[] = {3, 10, 2, 11}
            // f(4) = 1 + max(f(1), f(2), f(3))

            int[] dp = new int[nums.Length];
            Array.Fill(dp, 1);
            for (int i = 1; i < nums.Length; i++)
            {
                for (int j=0; j<i; j++)
                {
                    if (nums[i] > nums[j] && dp[i] < dp[j] + 1)
                    {
                        dp[i] = dp[j] + 1;
                    }
                }
            }

            int max = 0;
            for (int i = 0; i < dp.Length; i++)
            {
                if (max < dp[i])
                    max = dp[i];
            }
            return max;

        }
    }
}
