using System;

namespace _0080_Remove_Duplicates_from_Sorted_Array_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] example1 = new int[] { 1, 1, 1, 2, 2, 3 };
            int[] example2 = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
            Solution sol = new Solution();
            Console.WriteLine("example1=" + sol.RemoveDuplicates(example1));
            Console.WriteLine("example2=" + sol.RemoveDuplicates(example2));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int prev = nums[0];
            int prev_cnt = 1;
            int n = 1;
            for (int i=1; i<nums.Length; i++)
            {
                if (nums[i] != prev)
                {
                    nums[n++] = nums[i];
                    prev_cnt = 1;
                    prev = nums[i];   
                }
                else
                {
                    if (prev_cnt >= 2)
                    {
                        //如果 pre元素已經超過2個, continue下去
                        continue;
                    }
                    else
                    {
                        //沒超過兩個
                        nums[n++] = nums[i];
                        prev_cnt++;
                        prev = nums[i];
                    }
                }
            }
            return n;
        }
    }
}
