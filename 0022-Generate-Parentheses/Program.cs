using System;
using System.Collections.Generic;
using System.Text;

namespace _0022_Generate_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution2 sol = new Solution2();
            var result = sol.GenerateParenthesis(3);

            foreach (var item in result)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.ReadKey();
            
        }
    }

    public class Solution2
    {
        public IList<string> GenerateParenthesis(int n)
        {
            // ((()))
            IList<string> arr = new List<string>();
            Backtracking(arr, new StringBuilder(), 0, 0, n);
            return arr;
        }
        
        public void Backtracking(IList<string> ans, StringBuilder curr, int l, int r, int n)
        {
            if (curr.Length == n * 2)
            {
                ans.Add(curr.ToString());
                return;
            }

            if (l < n)
            {
                curr.Append("(");
                Backtracking(ans, curr, l + 1, r, n);
                curr.Remove(curr.Length - 1, 1);
            }

            if (r < l)
            {
                curr.Append(")");
                Backtracking(ans, curr, l, r + 1, n);
                curr.Remove(curr.Length - 1, 1);
            }
        }

    }


    public class Solution
    {
        public IList<string> GenerateOarenthesis(int n)
        {
            IList<string> arr = new List<string>();
            Backtack(arr, new StringBuilder(), 0, 0, n);
            return arr;
        }

        public void Backtack(IList<string> ans, StringBuilder cur, int open, int close, int max)
        {
            if (cur.Length == max * 2)
            {
                ans.Add(cur.ToString());
                return;
            }

            if (open < max)
            {
                cur.Append("(");
                Backtack(ans, cur, open + 1, close, max);
                cur.Remove(cur.Length - 1, 1);
            }
            if (close < open)
            {
                cur.Append(")");
                Backtack(ans, cur, open, close + 1, max);
                cur.Remove(cur.Length - 1, 1);
            }

        }
         
    }
}
