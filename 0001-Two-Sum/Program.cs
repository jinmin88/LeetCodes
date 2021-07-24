using System;
using System.Collections.Generic;

namespace _0001_Two_Sum
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
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<long, int>();
            for (int i=0; i<nums.Length; i++)
            {
                dict[nums[i]] = i;
            }

            for (int i=0; i<nums.Length; i++)
            {
                var val = target - nums[i];
                if (dict.ContainsKey(val))
                {
                    var idx = dict[val];
                    if (idx != i)
                    {
                        return new int[] { idx, i };
                    }
                }
            }
            return null;
        }
    }
}
