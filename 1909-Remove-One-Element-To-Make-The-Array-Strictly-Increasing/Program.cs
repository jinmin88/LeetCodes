using System;
using System.Collections.Generic;

namespace _1909_Remove_One_Element_To_Make_The_Array_Strictly_Increasing
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine($"Test case 1 = {sol.CanBeIncreasing(new int[] { 1, 2, 10, 5, 7 })}");
            Console.WriteLine($"Test case 2 = {sol.CanBeIncreasing(new int[] { 2, 3, 1, 2})}");
            Console.WriteLine($"Test case 3 = {sol.CanBeIncreasing(new int[] { 1, 1, 1 })}");
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool CanBeIncreasing(int[] nums)
        {
            bool removed = false;
            int prev = nums[0];

            for (int i=1; i<nums.Length; i++)
            {
                if (prev >= nums[i])
                {
                    if (removed == true)
                    {
                        return false;
                    }
                    else
                    {
                        if (i == 1 || nums[i] > nums[i-2])
                        {
                            prev = nums[i];
                            removed = true;
                        }
                        else
                        {
                            removed = true;
                        }
                    }
                }
                else
                {
                    prev = nums[i];
                }
                
            }
            return true;
        }
    }
}
