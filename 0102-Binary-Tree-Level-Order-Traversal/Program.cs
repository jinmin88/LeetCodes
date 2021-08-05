using ShareLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _0102_Binary_Tree_Level_Order_Traversal
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
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

            Queue<Tuple<TreeNode, int>> queue = new Queue<Tuple<TreeNode, int>>();
            queue.Enqueue(new Tuple<TreeNode, int>(root, 0));
            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                var treeNode = item.Item1;
                var currentLevel = item.Item2;
                if (dict.ContainsKey(currentLevel) == false)
                {
                    dict.Add(currentLevel, new List<int>() { treeNode.val });
                }
                else
                {
                    dict[currentLevel].Add(treeNode.val);
                }
                if (treeNode.left != null)
                {
                    queue.Enqueue(new Tuple<TreeNode, int>(treeNode.left, currentLevel + 1));
                }
                if (treeNode.right != null)
                {
                    queue.Enqueue(new Tuple<TreeNode, int>(treeNode.right, currentLevel + 1));
                }
            }

            IList<IList<int>> result= new List<IList<int>>();
            var listKeys = dict.Keys.ToList().OrderBy(a => a);
            foreach (var key in listKeys)
            {
                result.Add(dict[key]);
            }
            return result;

        }
    }
}
