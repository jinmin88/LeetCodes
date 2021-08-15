using System;

namespace _0053_Maximum_Subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Solution sol = new Solution();
            int val = sol.MaxSubArray(nums);
            Console.WriteLine("max=" + val);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        /// <summary>
        /// 思路：
        /// dp[1] = nums[1];
        /// dp[2] = Max(nums[2], dp[1] + nums[2])
        /// ...
        /// dp[i] = Max(nums[i], dp[i-1] + nums[i])
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        /// 
        public int MaxSubArray (int[] nums)
        {
            int max = int.MinValue;
            int[] dp = new int[nums.Length];
            for (int i=0; i<nums.Length; i++)
            {
                if (i == 0)
                    dp[0] = nums[0];
                else
                {
                    dp[i] = Math.Max(nums[i], dp[i - 1] + nums[i]);
                }

                if (dp[i] > max)
                {
                    max = dp[i];
                }
            }
            return max;


        }

    }
}
