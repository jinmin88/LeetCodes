using System;
using System.Collections.Generic;
using System.Linq;

namespace _0045_Jump_Game_II
{

    //greedy and bfs
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
          //  Console.WriteLine("greedy sol1=" + sol.Jump_Greedy(new int[] { 2, 3, 1, 1, 4 }));
            Console.WriteLine("greedy sol2=" + sol.Jump_Greedy2(new int[] { 2, 3, 0, 1, 4 }));

            Console.ReadKey();
        }
    }

    public class Solution
    {

        public int Jump_Greedy(int[] nums)
        {
            int count = 0;
            int curFarthest = 0;
            int curEnd = 0;

            for (int i = 0; i<nums.Length-1; i++)
            {
                curFarthest = Math.Max(i + nums[i], curFarthest);
                if (i == curEnd)
                {
                    count++;
                    curEnd = curFarthest;
                }
            }
            return count;
        }
    
        public int Jump_Greedy2(int[] nums)
        {
            int end = 0;
            int maxPosition = 0;
            int steps = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                //找能跳的最远的
                maxPosition = Math.Max(maxPosition, nums[i] + i);
                if (i == end)
                { //遇到边界，就更新边界，并且步数加一
                    end = maxPosition;
                    steps++;
                }
            }
            return steps;
        }
    
    
    }

    /*
    public class Solution
    {
        public int Jump(int[] nums)
        {
            bool[] visited = new bool[nums.Length];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(0);
            visited[0] = true;
            int depth = 0;

            while (queue.Count > 0)
            {

            }

        }




    }
    */


}
