using System;
using System.Text;

namespace _0006_ZigZag_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine(sol.Convert("PAYPALISHIRING", 3));
            Console.WriteLine(sol.Convert("PAYPALISHIRING", 4));

            Console.ReadKey();
        }
    }

    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (s.Length <= numRows || numRows == 1)
            {
                return s;
            }
            var sb = new StringBuilder();
            for (int i = 0; i<numRows; i++)
            {
                if (i == 0 || i == numRows - 1)
                {
                    int k = i;
                    while (k < s.Length)
                    {
                        sb.Append(s[k]);
                        k += (2 * numRows - 2);
                    }
                }
                else
                {
                    bool is_down = true;
                    int k = i;
                    while (k < s.Length)
                    {
                        sb.Append(s[k]);
                        if (is_down == true)
                        {
                            k += (numRows - i - 1) * 2;
                            is_down = false;
                        }
                        else
                        {
                            k += 2 * i;
                            is_down = true;
                        }
                    }
                }
            }
            return sb.ToString();
        }
    }
}
