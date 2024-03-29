﻿using System;

namespace _0070_Climbing_Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public int ClimbStair(int n)
        {
            int[] arr = new int[n+1];

            arr[0] = 1;
            arr[1] = 1;
            for(int i=2; i<=n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            return arr[n];
        }
    }

}
