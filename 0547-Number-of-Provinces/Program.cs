using System;

namespace _0547_Number_of_Provinces
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

        public int FindCircleNum(int[][] isConnected)
        {
            int n = isConnected.Length;
            bool[] visited = new bool[n];
            int numOfProvinces = 0;

            for (int i=0; i < n; i++)
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    numOfProvinces++;
                    findProvinces(visited, i, isConnected);
                }
            }
            return numOfProvinces;
        }
        
        private void findProvinces(bool[] visited, int currentRow, int[][] isConnected)
        {
            for (int i=0; i<visited.Length; i++)
            {
                if (!visited[i] && currentRow != i && isConnected[currentRow][i] == 1)
                {
                    visited[i] = true;
                    findProvinces(visited, i, isConnected);
                }
            }
        }




    }
}
