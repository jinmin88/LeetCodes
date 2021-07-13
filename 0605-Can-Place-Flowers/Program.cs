using System;

namespace _0605_Can_Place_Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine($"Test case 1 = {sol.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 1)}");
            Console.WriteLine($"Test case 2 = {sol.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 2)}");
        }
    }

    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int current = n;
            for (int i=0; i<flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    if (i == 0)
                    {
                        if (flowerbed.Length > 1)
                        {
                            if (flowerbed[i + 1] == 0)
                            {
                                flowerbed[i] = 1;
                                current--;
                            }
                        }
                        else
                        {
                            flowerbed[i] = 1;
                            current--;
                        }
                    }
                    else if (i == flowerbed.Length - 1)
                    {
                        if (flowerbed[i-1] == 0)
                        {
                            flowerbed[i] = 1;
                            current--;
                        }
                    }
                    else
                    {
                        if (flowerbed[i-1] == 0 && flowerbed[i+1] == 0)
                        {
                            flowerbed[i] = 1;
                            current--;
                        }
                    }
                }
            }
            return current <= 0 ? true : false;
        }
    }
}
