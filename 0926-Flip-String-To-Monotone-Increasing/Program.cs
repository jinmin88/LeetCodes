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
            dp0[0...n] = [0,0,0,...,0]
            dp1[0...n] = [0,0,0,...,0]

            if (s[i] == '0') {
                //目前是0
                dp1[i] = dp1[i-1] + 1;
            }
            else {
                //目前是1
                dp0[i] = dp0[i-1] + 1;
            }
            */
            int len = s.Length;
            int[] dp0 = new int[len + 1];
            int[] dp1 = new int[len + 1];
            for (int i=0; i<len+1; i++)
            {
                dp0[i] = 0;
                dp1[i] = 0;
            }

            for (int i=0; i<len; i++)
            {
                if (s[i] == '0')
                {
                    dp1[i + 1] = i == 0 ? 0 : dp1[i] + 1;
                }
                else
                {
                    dp0[i + 1] = i == 0 ? 0 : dp0[i] + 1;
                }
            }


            return Math.Min(dp0[len], dp1[len]);
        }
    }
}
