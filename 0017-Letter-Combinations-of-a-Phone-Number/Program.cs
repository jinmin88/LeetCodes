using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _0017_Letter_Combinations_of_a_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            var result = sol.LetterCombinations("234");
        
            foreach (var str in result)
            {
                Console.Write(str + " ");
            }
            Console.ReadKey();
        }
    }


    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> result = new List<string>();
            Dictionary<char, List<char>> maps = new Dictionary<char, List<char>>();
            maps.Add('2', new List<char> { 'a', 'b', 'c' });
            maps.Add('3', new List<char> { 'd', 'e', 'f' });
            maps.Add('4', new List<char> { 'g', 'h', 'i' });
            maps.Add('5', new List<char> { 'j', 'k', 'l' });
            maps.Add('6', new List<char> { 'm', 'n', 'o' });
            maps.Add('7', new List<char> { 'p', 'q', 'r', 's' });
            maps.Add('8', new List<char> { 't', 'u', 'v' });
            maps.Add('9', new List<char> { 'w', 'x', 'y', 'z' });
            foreach (var ch in digits)
            {
                var m = maps[ch];
                if (result.Count == 0)
                {
                    foreach (var c in m)
                    {
                        result.Add(new string(c, 1));
                    }
                }
                else
                {
                    IList<string> templist = new List<string>();
                    foreach (var str in result)
                    {
                       foreach (var c in m)
                        {
                            var tempstr = str + new string(c, 1);
                            if (templist.IndexOf(tempstr) == -1)
                            {
                                templist.Add(str + new string(c, 1));
                            }
                        }
                    }
                    result.Clear();
                    foreach (var str in templist)
                    {
                        result.Add(str);
                    }
                }
            }
            return result;
        }
    }
}
