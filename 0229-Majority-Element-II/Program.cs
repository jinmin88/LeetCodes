using System;
using System.Collections.Generic;

namespace _0229_Majority_Element_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            Console.Write("example 3=");
            var example3 = sol.MajorityElement(new int[] { 1, 2 });
            foreach (var item in example3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    public class Solution
    {
        public IList<int> MajorityElement(int[] nums)
        {
            IList<int> result = new List<int>();
            int threshold = nums.Length / 3;
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (map.ContainsKey(num) == false)
                {
                    map.Add(num, 1);
                }
                else
                {
                    map[num]++;
                }
                if (map[num] > threshold)
                {
                    if (result.Contains(num) == false)
                    {
                        result.Add(num);
                    }
                }
            }
            return result;
        }
    }
}
