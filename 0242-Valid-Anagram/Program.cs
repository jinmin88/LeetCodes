using System;
using System.Linq;

namespace _0242_Valid_Anagram
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
        public bool IsAnagram(string s, string t)
        {
            return new string(s.ToCharArray().OrderBy(a => a).ToArray()) == new string(t.ToCharArray().OrderBy(a => a).ToArray());
        }
    }
}
