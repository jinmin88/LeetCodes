using System;

namespace _0274_H_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[] arr = new int[] { 1, 3, 1 };
            int h = sol.HIndex(arr);
            Console.WriteLine("h=" + h);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int HIndex(int[] citations)
        {
            Array.Sort(citations, 0, citations.Length);
            int papaer_num = citations.Length;
            for (int i=0; i<citations.Length; i++)
            {
                if (citations[i] >= papaer_num)
                {
                    return papaer_num;
                }
                papaer_num--;
            }
            return papaer_num;
        }
    }
}
