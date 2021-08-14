using System;
using System.Collections.Generic;
using System.Linq;

namespace _0077_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            var combinations = sol.Combine(5, 2);
            foreach (var combination in combinations)
            {
                foreach (var val in combination)
                {
                    Console.Write($"{val} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> combinations = new List<IList<int>>();
            DFS(combinations, new List<int>(), n, k, 1);
            return combinations;
        }

        public void DFS(IList<IList<int>> combinations, IList<int> combination, int n, int k, int level)
        {
            if (combination.Count == k)
            {
                IList<int> clone = new List<int>();
                foreach (var item in combination)
                {
                    clone.Add(item);
                }
                combinations.Add(clone);
                return;
            }

            if (combination.Count > k)
            {
                return;
            }

            for (int i=level; i<=n; i++)
            {
                combination.Add(i);
                DFS(combinations, combination, n, k, i + 1);
                combination.RemoveAt(combination.Count - 1);
            }
        }



    }
}
