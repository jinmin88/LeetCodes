using ShareLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _0437_Path_Sum_III
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
        public int PathSum(TreeNode root, int targetSum)
        {
            List<int> path = new List<int>();
            int result = 0;
            PreOrder(root, targetSum, ref result, path);
            return result;
        }


        public void PreOrder(TreeNode root, int targetSum, ref int cnt, List<int> path)
        {
            if (root == null) return;

            path.Add(root.val);

            if (root.left == null && root.right == null)
            {
                for (int len = path.Count; len >= 1; len--)
                {
                    for (int i=0; i<=path.Count-len; i++)
                    {
                        if (path.GetRange(i, len).Sum() == targetSum)
                        {
                            cnt++;
                        }
                    }
                }
            }

            if (root.left != null)
            {
                PreOrder(root.left, targetSum, ref cnt, path);
                path.RemoveAt(path.Count - 1);
            }

            if (root.right != null)
            {
                PreOrder(root.right, targetSum, ref cnt, path);
                path.RemoveAt(path.Count - 1);
            }
        }

    }
}
