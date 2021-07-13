﻿using System;

namespace _0026_Remove_Duplicates_From_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[] arr = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int k = sol.RemoveDuplicates(arr);
            Console.WriteLine("k=" + k);
            for (int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int n = 1;
            int prev = nums[0];
            for (int i=0; i<nums.Length; i++)
            {
                if (nums[i] == prev)
                {
                    continue;
                }
                else
                {
                    n++;
                    nums[n - 1] = nums[i];
                    prev = nums[i];
                }
            }
            return n;
        }

    }
}
