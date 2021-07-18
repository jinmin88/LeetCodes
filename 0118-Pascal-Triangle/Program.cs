using System;
using System.Collections;
using System.Collections.Generic;

namespace _0118_Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            var ans5 = sol.Generate(5);
            
            foreach (var l in ans5)
            {
                foreach (var inner_l in l)
                {
                    Console.Write(inner_l.ToString().PadLeft(3, ' '));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>()
            {
                new List<int> { 1 }
            };
            if (numRows <= 1)
            {
                return result;
            } 
            
            for (int rowNum = 1; rowNum < numRows; rowNum++)
            {
                IList<int> row = new List<int>();
                IList<int> prevRow = result[rowNum - 1];

                //The first element is always 1
                row.Add(1);
                for (int j = 1; j<rowNum; j++)
                {
                    row.Add(prevRow[j - 1] + prevRow[j]);                    
                }
                //The last element is always 1
                row.Add(1);
                result.Add(row);
            }
            return result;

        }
    }
}
