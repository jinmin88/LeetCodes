using System;
using ShareLib;
using System.Collections.Generic;

namespace _0098_Validate_Binary_Search_Tree
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
        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, long.MinValue, long.MaxValue);
        }

        public bool IsValidBST(TreeNode root, long minVal, long maxVal)
        {
            if (root == null) return true;
            if (root.val >= maxVal || root.val <= minVal) return false;
            return IsValidBST(root.left, minVal, root.val) && IsValidBST(root.right, root.val, maxVal);
        }
    }
}
