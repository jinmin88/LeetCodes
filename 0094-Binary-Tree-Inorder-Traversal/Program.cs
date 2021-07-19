using ShareLib;
using System;
using System.Collections.Generic;

namespace _0094_Binary_Tree_Inorder_Traversal
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
        public IList<int> InorderTraversal(TreeNode root)
        {
            //使用stack來traversal binary tree
            IList<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            var curr = root;
            while (curr != null || stack.Count >0)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Pop();
                result.Add(curr.val);
                curr = curr.right;
            }
            return result;
        }

        public IList<int> InorderTraversal_Recursive(TreeNode root)
        {
            IList<int> result = new List<int>();
            InorderTraversal_Inner(root, result);
            return result;
        }

        public void InorderTraversal_Inner(TreeNode root, IList<int> res)
        {
            if (root != null)
            {
                if (root.left != null)
                {
                    InorderTraversal_Inner(root.left, res);
                }
                res.Add(root.val);
                if (root.right != null)
                {
                    InorderTraversal_Inner(root.right, res);
                }
            }
        }


        

    }
}
