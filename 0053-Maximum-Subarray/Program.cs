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
        public int MaxSubArray(int[] nums)
        {
            int max = int.MinValue;
            int[] table = new int[nums.Length];
            for (int i=0; i<nums.Length; i++)
            {
                if (i == 0)
                {
                    table[i] = nums[i];
                }
                else
                {
                    table[i] = Math.Max(nums[i], table[i - 1] + nums[i]);
                }
                max = Math.Max(max, table[i]);
            }

            return max;
        }

    }
}
