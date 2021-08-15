using System;
using System.Collections.Generic;

namespace _0046_Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3 };
            Solution3 sol = new Solution3();
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

    public class Solution3
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            bool[] visited = new bool[nums.Length];
            for (int i = 0; i < visited.Length; i++) visited[i] = false;
            Backtracking(result, new List<int>(), visited, nums);
            return result;
        }

        private void Backtracking(IList<IList<int>> result, IList<int> curr, bool[] visited, int[] nums)
        {
            if (curr.Count == nums.Length)
            {
                List<int> cloneList = new List<int>();
                foreach (var item in curr)
                {
                    cloneList.Add(item);
                }
                result.Add(cloneList);
                return;
            }


            for (int i=0; i<nums.Length; i++)
            {
                if (visited[i] == true) 
                    continue;

                visited[i] = true;
                curr.Add(nums[i]);
                Backtracking(result, curr, visited, nums);
                visited[i] = false;
                curr.RemoveAt(curr.Count - 1);
            }
        }

    }


    public class Solution2
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> permutations = new List<IList<int>>();
            if (nums.Length == 0) return permutations;
            bool[] visited = new bool[nums.Length];
            for (int i=0; i<visited.Length; i++)
            {
                visited[i] = false;
            }

            return permutations;
        }


        private void Backtracking(IList<IList<int>> permutations, IList<int> curr, bool[] visited, int[] nums)
        {
            if (curr.Count == nums.Length)
            {
                //curr代表此次排類的組合
                var cloneList = new List<int>();
                foreach (var item in curr)
                {
                    cloneList.Add(item);
                }
                permutations.Add(cloneList);
                return;
            }

            for (int i = 0; i<nums.Length; i++)
            {
                if (visited[i] == false)
                {
                    //使用nums[i]為字首開始排列
                    visited[i] = true;
                    curr.Add(nums[i]);

                    //用nums[i]開始，排列剩下的組合
                    Backtracking(permutations, curr, visited, nums);
                    
                    //出來之後，之前使用curr的組合已經排列完成，重新整理下一次的組合
                    visited[i] = false;
                    curr.RemoveAt(curr.Count - 1);
                }
            }
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
