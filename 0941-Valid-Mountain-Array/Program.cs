using System;

namespace _0941_Valid_Mountain_Array
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
        public bool ValidMountainArray(int[] arr)
        {
            int mode = 0; //0: n/a 1: asc 2:desc
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int offset = arr[i + 1] - arr[i];
                if (offset == 0)
                {
                    return false;
                }
                else if (offset > 0)
                {
                    if (mode == 0)
                    {
                        mode = 1;
                    }
                    else if (mode == 2)
                    {
                        return false;
                    }
                }
                else
                {
                    if (mode == 0)
                    {
                        return false;
                    }
                    else if (mode == 1)
                    {
                        mode = 2;
                    }
                }

            }

            if (mode != 2)
            {
                return false;
            }
            return true;

        }
    }
}
