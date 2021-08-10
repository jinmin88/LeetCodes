using System;
using System.Collections.Generic;
using System.Linq;

namespace _0018_4_Sum
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
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            return kSum(nums, target, 0, 4);
        }

        private List<IList<int>> kSum(int[] nums, int target, int start, int k)
        {
            List<IList<int>> res = new List<IList<int>>();
            if (start == nums.Length) //只剩一個元素可玩 => 無解
                return res;
            else if (nums[start] * k > target)  //最小的值乘上k倍大於target => 無解
                return res;
            else if (target > nums[nums.Length - 1] * k)  //target大於此陣列最大的數乘上k次=>一定無解
                return res;

            if (k == 2) return TwoSum(nums, target, start);

            // |start|
            for (int i = start; i<nums.Length; i++)
            {
                if (i == start || nums[i-1] != nums[i])
                {
                    //降k
                    foreach (var subset in kSum(nums, target - nums[i], i + 1, k - 1))
                    {
                        List<int> innerResult = new List<int>() { nums[i] };
                        innerResult.AddRange(subset);
                        res.Add(innerResult);
                    }
                }
            }
            return res;
        }

        private List<IList<int>> TwoSum(int[] nums, int target, int start)
        {
            //  start ... lo-1   lo
            //              x     x
            
            List<IList<int>> res = new List<IList<int>>();
            int lo = start, hi = nums.Length - 1;
            while (lo < hi)
            {
                int currSum = nums[lo] + nums[hi];
                if (currSum < target || (lo > start && nums[lo] == nums[lo-1]))
                {
                    lo++;
                }
                else if (currSum > target || (hi < nums.Length-1 && nums[hi] == nums[hi+1]))
                {
                    hi--;
                }
                else
                {
                    res.Add(new List<int> { nums[lo], nums[hi] });
                    lo++;
                    hi--;
                }
            }
            return res;
        }


    }


}
