using System;
using System.Collections.Generic;
using System.Linq;

namespace _0954_Array_of_Doubled_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1, 2, 1, -8, 8, -4, 4, -4, 2, -2 };
            Solution sol = new Solution();

            Console.WriteLine(sol.CanReorderDoubled(arr));
        }
    }

    public class Solution
    {
        public bool CanReorderDoubled(int[] arr)
        {
            Array.Sort(arr);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var val in arr)
            {
                if (dict.ContainsKey(val) == false)
                {
                    dict.Add(val, 1);
                }
                else
                {
                    dict[val]++;
                }
            }

            foreach (var val in arr)
            {
                if (dict.ContainsKey(val) == false)
                    continue;
                //1. 先把自己取出來
                dict[val]--;
                if (dict[val] == 0)
                {
                    dict.Remove(val);
                }

                if (val % 2 == 0)
                {
                    //偶數
                    int double_val = val * 2;
                    int half_val = val / 2;
                    if (dict.ContainsKey(double_val))
                    {
                        dict[double_val]--;
                        if (dict[double_val] == 0)
                        {
                            dict.Remove(double_val);
                        }
                    }
                    else
                    {
                        if (dict.ContainsKey(half_val))
                        {
                            dict[half_val]--;
                            if (dict[half_val] == 0)
                            {
                                dict.Remove(half_val);
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    //單數
                    int double_val = val * 2;
                    if (dict.ContainsKey(double_val))
                    {
                        dict[double_val]--;
                        if (dict[double_val] == 0)
                        {
                            dict.Remove(double_val);
                        }
                    }
                    else
                    {
                        return false;
                    }
                }


            }

            return true;
        }
    }
}
