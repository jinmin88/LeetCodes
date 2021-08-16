using System;
using System.Collections.Generic;

namespace _0131_Palindrome_Partitioning
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
        /// <summary>
        /// 1. s[start] = s[end]
        /// 2. dp[start+1,end-1] 
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public IList<IList<string>> Partition(string s)
        {
            int len = s.Length;
            bool[][] dp = new bool[len][];
            for (int i=0; i<dp.Length; i++) { dp[i] = new bool[len]; }
            IList<IList<string>> result = new List<IList<string>>();
            DFS(result, new List<string>(), dp, s, 0);
            return result;
        }

        private void DFS(IList<IList<string>> result, IList<string> curr, bool[][] dp, string s, int start)
        {
            if (start >= s.Length)
            {
                var cloneList = new List<string>();
                foreach (var item in curr) { cloneList.Add(item); }
                result.Add(cloneList);
            }

            for (int end = start; end < s.Length; end++)
            {
                if (s[start] == s[end] && (end - start <= 2 || dp[start+1][end-1] == true))
                {
                    dp[start][end] = true;
                    curr.Add(s.Substring(start, end-start+1));
                    DFS(result, curr, dp, s, end + 1);
                    curr.RemoveAt(curr.Count - 1);
                }
            }
        }
    }
}
