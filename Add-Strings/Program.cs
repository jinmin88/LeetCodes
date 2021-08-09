using System;
using System.Text;

namespace Add_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine("11+123=" + sol.AddStrings("11", "123"));
            Console.WriteLine("456+77=" + sol.AddStrings("456", "77"));
            Console.WriteLine("0+0=" + sol.AddStrings("0", "0"));
        }
    }

    public class Solution
    {
        public string AddStrings(string num1, string num2)
        {
            StringBuilder sb = new StringBuilder();
            int current = 0;
            int lookahead = 0; 
            while ((current < num1.Length || current < num2.Length) || (lookahead > 0))
            {
                if (current < num1.Length && current < num2.Length)
                {
                    //num1[num1.Length-current-1] + num2[num2.length-current-1]
                    lookahead += (num1[num1.Length - current - 1] - '0') + (num2[num2.Length - current - 1] - '0');
                    sb.Insert(0, (lookahead % 10).ToString());
                    lookahead = lookahead / 10;
                    current++;
                }
                else if (current < num1.Length)
                {
                    lookahead += (num1[num1.Length - current - 1] - '0');
                    sb.Insert(0, (lookahead % 10).ToString());
                    lookahead = lookahead / 10;
                    current++;
                }
                else if (current < num2.Length)
                {
                    lookahead += (num2[num2.Length - current - 1] - '0');
                    sb.Insert(0, (lookahead % 10).ToString());
                    lookahead = lookahead / 10;
                    current++;
                }
                else
                {
                    sb.Insert(0, (lookahead % 10).ToString());
                    lookahead = lookahead / 10;
                }
            }

            return sb.ToString();
        }

    }
}
