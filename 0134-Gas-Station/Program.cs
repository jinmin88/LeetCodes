using System;

namespace _0134_Gas_Station
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine("Example 1=" + sol.CanCompleteCircuit(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 1, 2 }));
            Console.WriteLine("Example 2=" + sol.CanCompleteCircuit(new int[] { 2, 3, 4 }, new int[] { 3, 4, 3 }));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            for (int i = 0; i<gas.Length; i++)
            {
                bool val = CanCompleteStartFrom(gas, cost, i);
                if (val == true) return i;
            }
            return -1;
        }

        private bool CanCompleteStartFrom(int[] gas, int[] cost, int start)
        {
            int currentGas = 0;
            for (int i = start; i < start + cost.Length; i++)
            {
                //換算第為idx
                int idx = (i + cost.Length) % cost.Length;
                //先加idx的油
                currentGas += gas[idx];
                if (currentGas >= cost[idx])
                {
                    currentGas -= cost[idx];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
