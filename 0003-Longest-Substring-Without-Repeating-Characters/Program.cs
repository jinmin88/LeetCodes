using System;
using System.Collections.Generic;
using System.Linq;

namespace _0003_Longest_Substring_Without_Repeating_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine("abcabcbb=" + sol.LengthOfLongestSubstring("abcabcbb"));
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s == "") return 0;
            HashSet<char> map = new HashSet<char>();
            int maxLen = int.MinValue;
            int start = 0; int tempLen = 0;
            while (start < s.Length)
            {
                tempLen = 0;
                map.Clear();
                for (int i=start; i<s.Length; i++)
                {
                    if (map.Contains(s[i]) == false)
                    {
                        map.Add(s[i]);
                        tempLen++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (tempLen > maxLen)
                {
                    maxLen = tempLen;
                }
                start++;
            }
            return maxLen;
        }


    }
}
