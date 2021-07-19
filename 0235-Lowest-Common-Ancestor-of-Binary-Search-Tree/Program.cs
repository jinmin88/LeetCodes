using ShareLib;
using System;

namespace _0235_Lowest_Common_Ancestor_of_Binary_Search_Tree
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
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            //假設root是null，則代表此棵樹沒有共同p或q的祖先
            if (root == null) return null;
            //假設p或q等於root，代表p/q共同祖先為root
            if (root == p || root == q) return root;
            //左子樹查看p or q共同祖先是否有值
            TreeNode left = LowestCommonAncestor(root.left, p, q);
            //右子樹查看p or q共同祖先是否有值
            TreeNode right = LowestCommonAncestor(root.right, p, q);
            //如果左子樹跟右子樹都有結果，則自己root則是共同祖先
            if (left != null && right != null)
            {
                return root;
            }
            if (left == null) 
                return right; //如果左邊是null，則是右邊
            else 
                return left; //否則是左邊
        }
    }
}
