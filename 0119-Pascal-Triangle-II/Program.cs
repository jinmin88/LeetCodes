using System;
using System.Collections.Generic;

namespace _0119_Pascal_Triangle_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            var list = sol.GetRow(21);
            foreach (var item in list)
            {
                Console.Write(item.ToString() + " ");
                
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            IList<int> row = new List<int>();
            if (rowIndex <= 0)
            {
                row.Add(1);
                return row;
            }
            else if (rowIndex == 1)
            {
                row.Add(1);
                row.Add(1);
                return row;
            }

            int[] temp = new int[rowIndex + 1];
            temp[0] = 1; temp[1] = 1;
            for (int i=2; i<=rowIndex; i++)
            {
                row.Clear();
                row.Add(1);
                for (int j=1; j<i; j++)
                {
                    row.Add(temp[j] + temp[j - 1]);
                }
                row.Add(1);
                for (int k=0; k < row.Count; k++)
                {
                    temp[k] = row[k];
                }
            }
            return row;
        }

    }
}
