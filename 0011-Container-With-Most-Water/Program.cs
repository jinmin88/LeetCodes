using System;

namespace _0011_Container_With_Most_Water
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[] arr = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Console.WriteLine(sol.MaxArea(arr));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int MaxArea(int[] arr)
        {
            int low = 0;
            int height = arr.Length - 1;
            int maxArea = int.MinValue;
            int temp;
            while (low < height)
            {
                if (arr[low] <= arr[height])
                {
                    temp = arr[low] * (height - low);
                    if (temp > maxArea)
                    {
                        maxArea = temp;
                    }
                    low++;
                }
                else
                {
                    temp = arr[height] * (height - low);
                    if (temp > maxArea)
                    {
                        maxArea = temp;
                    }
                    height--;
                }
            }
            return maxArea;
        }
    }
}
