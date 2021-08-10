using System;
using System.Text;

namespace _0926_Flip_String_To_Monotone_Increasing
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine("010110=" + sol.MinFlipsMonoIncr("010110"));
        }
    }



    public class Solution
    {
        public int MinFlipsMonoIncr(string s)
        {
            /*
            if s[i] == '0'
                dp[i][0] = dp[i-1][0];
                dp[i][1] = min(dp[i-1][0], dp[i-1][1]) + 1;
            else s[i] == '1'
                dp[i][0] = dp[i-1][0] + 1;
                dp[i][1] = min(dp[i-1][0], dp[i-1][1])
        
            */





            for (int i=0; i<s.Length; i++)
            {
                if (s[i] == '1')
                {

                }
                else
                {

                }
            }

        }
    }
}
