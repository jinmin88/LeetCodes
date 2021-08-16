using System;

namespace _0033_Search_in_Rotated_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine("search=" + sol.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int rot = FindMinIdx(nums);
            if (target == nums[rot]) return rot;

            int start; int end;
            if (target <= nums[nums.Length-1])
            {
                start = rot;
                end = nums.Length - 1;
            }
            else
            {
                start = 0;
                end = rot;
            }


            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return -1;


        }

        private int FindMinIdx(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] > nums[end])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }
            return start;
        }
    }
}
