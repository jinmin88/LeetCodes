using System;

namespace _0414_Third_Maximum_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Test case 1: {ThirdMax(new int[] { 3, 2, 1 })}");
            Console.WriteLine($"Test case 2: {ThirdMax(new int[] { 1, 2 })}");
            Console.WriteLine($"Test case 3: {ThirdMax(new int[] { 2, 2, 3, 1 })}");
            Console.ReadKey();
        }


        public static int ThirdMax(int[] nums)
        {
            int? firstMax_val = FindMaxLessThan(nums, null);
            int? secondMax_val = FindMaxLessThan(nums, firstMax_val);
            int? thirdMax_val = FindMaxLessThan(nums, secondMax_val);
            return thirdMax_val == null ? firstMax_val.Value : thirdMax_val.Value;
        }

        private static int? FindMaxLessThan(int[] nums, int? n)
        {
            int? max = null;

            for (int i = 0; i < nums.Length; i++)
            {
                if (n != null && nums[i] >= n.Value)
                    continue;
                if (max == null)
                {
                    max = nums[i];
                }
                else
                {
                    if (nums[i] >= max.Value)
                        max = nums[i];
                }
            }
            return max;
        }
 


    }
}
