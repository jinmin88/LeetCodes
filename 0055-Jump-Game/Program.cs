using System;

namespace _0055_Jump_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine("dp sol1=" + sol.CanJump(new int[] { 2, 3, 1, 1, 4 }));
            Console.WriteLine("dp sol2=" + sol.CanJump(new int[] { 3, 2, 1, 0, 4 }));

            Console.WriteLine("greedy sol1=" + sol.CanJump_Greedy(new int[] { 2, 3, 1, 1, 4 }));
            Console.WriteLine("greedy sol2=" + sol.CanJump_Greedy(new int[] { 3, 2, 1, 0, 4 }));

            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool CanJump(int[] nums)
        { 
            int[] dp = new int[nums.Length];
            Array.Fill(dp, 0);
            for (int i=1; i<nums.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 1], nums[i - 1]) - 1;
                if (dp[i] < 0) return false;
            }
            return true;
        }

        public bool CanJump_Greedy(int[] nums)
        {
            int reach = 0;
            for (int i=0; i<nums.Length; i++)
            {
                if (i > reach) 
                    break;
                //目前這布去計算到這格後跟不到這格 reach哪個比較大
                reach = Math.Max(reach, i + nums[i]);
            }

            return (reach >= nums.Length - 1) ? true : false;
        }
    }
}
