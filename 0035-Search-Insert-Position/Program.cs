using System;

namespace _0035_Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine("Test case 1=" + sol.SearchInsert(new int[] { 1, 3, 5, 6 }, 5));
            Console.WriteLine("Test case 2=" + sol.SearchInsert(new int[] { 1, 3, 5, 6 }, 2));
            Console.WriteLine("Test case 3=" + sol.SearchInsert(new int[] { 1, 3, 5, 6 }, 7));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while(left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }                
            }

            if (target > nums[left])
                return left + 1;
            else
                return left;
        }

        public int BinarySearch(int[] nums, int start, int end, int target)
        {
            if (start >= end)
            {
                if (nums[start] > target)
                {
                    return start + 1;
                }
                else
                {
                    return start;
                }
            }
                
            int mid = (end - start + 1) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (target > nums[mid])
            {
                return BinarySearch(nums, mid + 1, end, target); 
            }
            else
            {
                return BinarySearch(nums, start, mid - 1, target);
            }
        }

    }
}
