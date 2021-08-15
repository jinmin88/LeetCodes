using System;

namespace _0005_Longest_Palindromic_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution2 sol = new Solution2();
            Console.WriteLine(sol.LongestPalindrome("cbbd"));
        }
    }


    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (s == null || s.Length < 1) return string.Empty;

            int start = 0, end = 0;

            for (int i=0;i<s.Length; i++)
            {
                int len1 = ExpandAroundCenter(s, i, i);
                int len2 = ExpandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    //   (len-1)/2   (len-1)/2
                    //   --------- i ---------
                    //   start + (len-1)/2 = i
                    //   start = i - (len-1)/2;
                    //   i + (len-1)/2 = end
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
            return s.Substring(start, end-start+1);
        }

        private int ExpandAroundCenter(string s, int left, int right)
        { 
            //       l
            //         r
            //   l>=0 r<len && s[l]=s[r]    0
            int l = left;
            int r = right;
            while (l >=0 && r < s.Length && s[l] == s[r])
            {
                l--; r++;
            }
            return r - l - 1;
        }


    }

    public class Solution2
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;
            int start = 0; int end = 0;
            for (int i=0; i < s.Length; i++)
            {
                int len1 = ExpandAroundCenter(s, i, i);
                int len2 = ExpandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
            return s.Substring(start, end - start + 1);
        }

        private int ExpandAroundCenter(string s, int left, int right)
        {
            int l = left; int r = right;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--;
                r++;
            }
            return r - l - 1;
        }
    }
}
