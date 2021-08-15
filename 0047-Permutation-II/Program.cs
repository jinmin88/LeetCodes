using System;
using System.Collections.Generic;
using System.Linq;

namespace _0047_Permutation_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            var permutation = sol.PermuteUnique(new int[] { 1, 1, 2 });
            foreach (var inner in permutation)
            {
                foreach (var item in inner)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }


    public class Solution
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> permutations = new List<IList<int>>();
            bool[] visited = new bool[nums.Length];
             
            Backtracking(permutations, new List<int>(), visited, nums);
            return permutations;
        }

        private void Backtracking(IList<IList<int>> permutations, IList<int> curr, bool[] visited, int[] nums)
        {
            if (curr.Count == nums.Length)
            {
                List<int> cloneList = new List<int>();
                foreach (var item in curr) { cloneList.Add(item); }
                permutations.Add(cloneList);
                return;
            }


            //當跑第二輪相同元素時，因為前面第一輪已經跑過並且已經清成false, 所以當前面為false時，不處理
            for (int i = 0; i < nums.Length; i++)
            {
                if (visited[i] == true) continue;

                if (i > 0 && nums[i - 1] == nums[i] && visited[i-1] == false) continue;

                visited[i] = true;
                curr.Add(nums[i]);
                Backtracking(permutations, curr, visited, nums);
                visited[i] = false;
                curr.RemoveAt(curr.Count - 1);
            }
        }


    }
}
