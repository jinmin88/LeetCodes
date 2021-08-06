using System;
using System.Collections.Generic;

namespace _0046_Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3 };
            Solution sol = new Solution();
            var result = sol.Permute(nums);

            Console.Write("[");
            foreach (var inner in result)
            {
                Console.Write("[");
                foreach (var element in inner)
                {
                    Console.Write(element + ",");
                }
                Console.Write("],");
            }
            Console.Write("]");

        }
    }

    public class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> permutations = new List<IList<int>>();
            if (nums.Length == 0) return permutations;

            bool[] isVisited = new bool[nums.Length];
            for (int i= 0; i < isVisited.Length; i++)
            {
                isVisited[i] = false;
            }
            List<int> curr = new List<int>();
            BackTracking(permutations, curr, isVisited, nums);
            return permutations;
        }

        private void BackTracking(IList<IList<int>> permutations, IList<int> curr, bool[] isVisited, int[] nums)
        {
            if (curr.Count == nums.Length)
            {
                var cloneCurr = new List<int>();
                foreach (var c in curr)
                {
                    cloneCurr.Add(c);
                }
                permutations.Add(cloneCurr);
                return;
            }

            for (int i=0; i<nums.Length; i++)
            {
                if (isVisited[i] == false)
                {
                    //使用以nums[i]為首的排列
                    isVisited[i] = true;
                    curr.Add(nums[i]);
                    BackTracking(permutations, curr, isVisited, nums);

                    //以i為首結束之後，設定回false
                    isVisited[i] = false;
                    curr.RemoveAt(curr.Count - 1);
                }
            }
        }



    }

}
