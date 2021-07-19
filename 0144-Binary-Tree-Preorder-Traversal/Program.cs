using ShareLib;
using System;
using System.Collections.Generic;

namespace _0144_Binary_Tree_Preorder_Traversal
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
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                result.Add(node.val);
                if (node.right != null)
                {
                    stack.Push(node.right);
                }
                if (node.left != null)
                {
                    stack.Push(node.left);
                }
            }
            return result;
        }
    }
}
