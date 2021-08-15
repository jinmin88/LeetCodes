using System;
using System.Collections.Generic;
using System.Linq;

namespace _0013_Roman_To_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution2
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                result += map[s[i]];
                switch (s[i])
                {
                    case 'V':
                    case 'X':
                        {
                            result += i > 0 && s[i - 1] == 'I' ? map[s[i - 1]] * -2 : 0;
                        }
                        break;
                    case 'L':
                    case 'C':
                        {
                            result += i > 0 && s[i - 1] == 'X' ? map[s[i - 1]] * -2 : 0;
                        }
                        break;
                    case 'D':
                    case 'M':
                        {
                            result += i > 0 && s[i - 1] == 'C' ? map[s[i - 1]] * -2 : 0;
                        }
                        break;
                    default:
                        break;
               }
            }
            return result;
        }

    }


    //https://leetcode.com/problems/roman-to-integer/
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            char prev = ' ';
            foreach (var ch in s)
            {
                // IV, IX => O -> (1,2)
                // XL, XC => 
                // CD, CM =>
                switch (ch)
                {
                    case 'I': 
                        result += 1; 
                        break;
                    case 'V': 
                        if (prev == 'I')
                        {
                            result += 3;
                        }
                        else
                        {
                            result += 5;
                        }
                        break;
                    case 'X': 
                        if (prev == 'I')
                        {
                            result += 8;
                        }
                        else
                        {
                            result += 10;
                        }
                        break;
                    case 'L':
                        if (prev == 'X')
                        {
                            result += 30;
                        }
                        else
                        {
                            result += 50;
                        }
                        break;
                    case 'C': 
                        if (prev == 'X')
                        {
                            result += 80;
                        }
                        else
                        {
                            result += 100;
                        }
                        break;
                    case 'D':
                        if (prev == 'C')
                        {
                            result += 300;
                        }
                        else
                        {
                            result += 500;
                        }
                        break;
                    case 'M':
                        if (prev == 'C')
                        {
                            result += 800;
                        }
                        else
                        {
                            result += 1000;
                        }
                        break;
                      
                }
                prev = ch;
            }
            return result;
        }
    }

}
