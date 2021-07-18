using System;
using System.Collections.Generic;

namespace _0169_Majority_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine("example1=" + sol.MajorityElement(new int[] { 3, 2, 3 }));
            Console.WriteLine("example2=" + sol.MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
            Console.ReadKey();
        }


    }

    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            int majorityNum = nums.Length / 2;
            var map = new Dictionary<int, int>();
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
                if (map[num] > majorityNum)
                {
                    return num;
                }
            }
            return -1;
        }
    }
}
