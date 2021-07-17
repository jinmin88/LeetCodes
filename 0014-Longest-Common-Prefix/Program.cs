using System;

namespace _0014_Longest_Common_Prefix
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
