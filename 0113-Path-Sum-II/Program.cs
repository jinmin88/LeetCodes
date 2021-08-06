using ShareLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _0113_Path_Sum_II
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
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            List<int> path = new List<int>();
            List<IList<int>> result = new List<IList<int>>();
            PreOrder(root, 0, targetSum, path, result);
            return result;
        }

        public void PreOrder(TreeNode root, int sum, int targetSum, List<int> path, List<IList<int>> result)
        {
            if (root == null) return;

            sum += root.val;
            path.Add(root.val);

            if (root.left == null && root.right == null && sum == targetSum)
            {
                var clonePath = new List<int>();
                foreach (var p in path)
                {
                    clonePath.Add(p);
                }
                result.Add(clonePath);
            }

            if (root.left != null)
            {
                PreOrder(root.left, sum, targetSum, path, result);
                //出來之後把最後一個element移除掉
                path.RemoveAt(path.Count - 1);
            }

            if (root.right != null)
            {
                PreOrder(root.right, sum, targetSum, path, result);
                path.RemoveAt(path.Count - 1);
            }
        }

    }
}
