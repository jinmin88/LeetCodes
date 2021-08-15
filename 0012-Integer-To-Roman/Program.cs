using System;
using System.Text;

namespace _0012_Integer_To_Roman
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine("test 1994=" + sol.IntToRoman(3994));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        private static string[] Roman = { "I", "V", "X", "L", "C", "D", "M" };
        private static int[] Vals = { 1, 5, 10, 50, 100, 500, 1000 };

        public string IntToRoman(int num)
        {
            StringBuilder sb = new StringBuilder();
            int symbol = Roman.Length - 1;
            while (num > 0)
            {
                if (num >= Vals[symbol])
                {
                    sb.Append(Roman[symbol]);
                    num -= Vals[symbol];
                    continue;
                }

                if (symbol > 0)
                {
                    //900
                    int substracted = (symbol % 2 == 0) ? symbol - 2 : symbol - 1;
                    if (num >= Vals[symbol] - Vals[substracted])
                    {
                        sb.Append(Roman[substracted]).Append(Roman[symbol]);
                        num -= Vals[symbol] - Vals[substracted];
                    }
                }


                symbol--;
            }
            return sb.ToString();
        }
    }
}
