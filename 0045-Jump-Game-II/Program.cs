using System;

namespace _0045_Jump_Game_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
          //  Console.WriteLine("greedy sol1=" + sol.Jump_Greedy(new int[] { 2, 3, 1, 1, 4 }));
            Console.WriteLine("greedy sol2=" + sol.Jump_Greedy(new int[] { 2, 3, 0, 1, 4 }));

            Console.ReadKey();
        }
    }

    public class Solution
    {

        public int Jump_Greedy(int[] nums)
        {
            int count = 0;
            int curFarthest = 0;
            int curEnd = 0;

            for (int i = 0; i<nums.Length-1; i++)
            {
                curFarthest = Math.Max(i + nums[i], curFarthest);
                if (i == curEnd)
                {
                    count++;
                    curEnd = curFarthest;
                }
            }
            return count;
        }
    }
}
