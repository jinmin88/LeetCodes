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
            int len = s.Length;
            int[][] dp = new int[len+1][];
            for (int i=0; i<dp.Length; i++)
            {
                dp[i] = new int[2];
            }

            for (int i=1; i<=len; i++)
            {
                if (s[i-1] == '0')
                {  
                    
                    //維持0的作法 => 讀到0不需要變化
                    dp[i][0] = dp[i - 1][0];

                    //變成最後一位是1的作法 => (維持目前是0序列 , 與最後幾位是1序列)兩者取小的+1(變自己)
                    dp[i][1] = Math.Min(dp[i - 1][0], dp[i - 1][1]) + 1;
                }
                else
                {
                    //維持0作法，把目前的1變0
                    dp[i][0] = dp[i - 1][0] + 1;

                    //變成最後一位是1的作法 => min(前面是0目前為1, 前面是1目前為1)
                    dp[i][1] = Math.Min(dp[i - 1][0], dp[i - 1][1]);
                }
            }

            return Math.Min(dp[len][0], dp[len][1]);
        }
    }
}
