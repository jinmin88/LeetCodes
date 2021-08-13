using System;
using System.Collections.Generic;
using System.Linq;

namespace Group_Anagrams
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
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                var orderedStr = new string(str.ToCharArray().OrderBy(a => a).ToArray());
                if (!dict.ContainsKey(orderedStr))
                {
                    dict.Add(orderedStr, new List<string> { str });
                }
                else
                {
                    dict[orderedStr].Add(str);
                }
            }

            var result = new List<IList<string>>();
            foreach (var pair in dict)
            {
                result.Add(pair.Value);
            }
            return result;

        }
    }

}
