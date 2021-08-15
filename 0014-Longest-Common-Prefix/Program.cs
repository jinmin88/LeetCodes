using System;
using System.IO;
using System.Collections.Generic;

namespace _0014_Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution2 sol = new Solution2();
            Console.WriteLine(sol.LongestCommonPrefix(new string[] { "aa", "aaa", "aa" }));
        }
    }


    public class Solution2
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string prefix = strs[0];
            if (prefix == "") return prefix;
            for (int i=1; i<strs.Length; i++)
            {
                int lastPrefixIndex = -1;
                for (int j=0; j<strs[i].Length && j<prefix.Length; j++)
                {
                    if (strs[i][j] == prefix[j])
                    {
                        lastPrefixIndex = j;
                    }
                    else
                    {
                        break;
                    }
                }

                if (lastPrefixIndex == -1)
                {
                    return "";
                }
                else
                {
                    prefix = prefix.Substring(0, lastPrefixIndex + 1);
                }
            }
            return prefix;
        }
    }

    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var curr_max_prefix = strs[0];
            for (int i=1; i<strs.Length; i++)
            {
                curr_max_prefix = FindTwoStringPrefix(curr_max_prefix, strs[i]);
            }
            return curr_max_prefix;
        }

        private string FindTwoStringPrefix(string a, string b)
        {
            string common_prefix = string.Empty;
            for (int i=0; i<a.Length; i++)
            {
                if (i < b.Length)
                {
                    if (a[i] == b[i])
                    {
                        common_prefix += a[i];
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            return common_prefix;
        }
    }
}
