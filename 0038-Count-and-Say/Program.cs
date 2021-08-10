using System;
using System.Text;

namespace _0038_Count_and_Say
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine("n(4)=" + sol.CountAndSay(4));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public string CountAndSay(int n)
        {
            if (n == 1)
                return "1";
            else
            {
                string prev_str = CountAndSay(n - 1);
                char prev_char = ' ';
                int prev_len = 0;
                StringBuilder sb = new StringBuilder();
                for (int i=0; i<prev_str.Length; i++)
                {
                    if (i == 0)
                    {
                        prev_char = prev_str[i];
                        prev_len = 1;
                    }
                    else
                    {
                        if (prev_str[i] == prev_char)
                        {
                            prev_len++;
                        }
                        else
                        {
                            sb.Append(prev_len).Append(prev_char);
                            prev_char = prev_str[i];
                            prev_len = 1;
                        }
                    }
                }
                sb.Append(prev_len).Append(prev_char);
                return sb.ToString();
            }



        }
    }
}
