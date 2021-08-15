using System;
using System.Collections.Generic;

namespace _0015_3_Sum
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
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var len = nums.Length;
            Array.Sort(nums);
            List<IList<int>> result = new List<IList<int>>();

            for (int i=0; i<len; i++)
            {
                if (nums[i] > 0) break;
                if (i > 0 && nums[i - 1] == nums[i]) continue; //略過相同元素
                int start = i + 1;
                int last = len - 1;
                while (start < last)
                {
                    if (nums[start] + nums[last] + nums[i] > 0)
                        last--; //三個加起來大於0, last往左跑一格
                    else if (nums[start] + nums[last] + nums[i] < 0)
                        start ++; //三個加起來小於0 代表start需要大一點
                    else
                    {
                        result.Add(new List<int> { nums[i], nums[start], nums[last] });
                        start++;
                        last--;
                        while (start < last && nums[start - 1] == nums[start])
                            start++;
                    }
                }
            }
            return result;

        }

    
    
    
    }
}
