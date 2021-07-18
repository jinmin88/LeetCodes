using System;
using System.Collections.Generic;

namespace _0299_Bulls_and_Cows
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine("guess=1807, hint=" + sol.GetHint("1807", "7810"));
            Console.WriteLine("guess=1123, hint=" + sol.GetHint("1123", "0111"));
            Console.WriteLine("guess=1, hint=" + sol.GetHint("1", "0"));
            Console.WriteLine("guess=1, hint=" + sol.GetHint("1", "1"));
        }
    }

    public class Solution
    {
        public string GetHint(string secret, string guess)
        {
            int countA = 0;
            int countB = 0;

            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i=0; i<guess.Length; i++)
            {
                if (guess[i] == secret[i])
                {
                    countA++;
                }
                else
                {
                    if (dict.ContainsKey(secret[i]))
                    {
                        dict[secret[i]]++;
                    }
                    else
                    {
                        dict.Add(secret[i], 1);
                    }
                }
            }

            for (int i=0; i<guess.Length; i++)
            {
                if (secret[i] != guess[i])
                {
                    if (dict.ContainsKey(guess[i]))
                    {
                        countB++;
                        dict[guess[i]]--;
                        if (dict[guess[i]] == 0)
                        {
                            dict.Remove(guess[i]);
                        }
                    }
                }
            }

            return $"{countA}A{countB}B";

        }
    }
}
