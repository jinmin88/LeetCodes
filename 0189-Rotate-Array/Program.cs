using System;

namespace _0189_Rotate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            if (nums.Length == 1) return;
            Array.Reverse(nums, 0, nums.Length);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, nums.Length - k);
        }
    }
}
