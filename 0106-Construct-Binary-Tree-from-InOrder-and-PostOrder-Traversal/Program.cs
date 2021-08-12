using ShareLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _0106_Construct_Binary_Tree_from_InOrder_and_PostOrder_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inorder = new int[] { 9, 3, 15, 20, 7 };
            int[] postorder = new int[] { 9, 15, 7, 20, 3 };

            Solution sol = new Solution();


        }
    }

    public class Solution
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            Dictionary<int, int> inorder_map = new Dictionary<int, int>();
            for (int i=0; i<inorder.Length; i++)
            {
                inorder_map.Add(inorder[i], i);
            }
            return ConstructTree(inorder, 0, inorder.Length - 1, postorder, 0, postorder.Length - 1, inorder_map);
        }

        private TreeNode ConstructTree(int[] inorder, int in_start, int in_end, int[] postorder, int post_start, int post_end, Dictionary<int, int> inorder_map)
        {
            if (post_start > post_end || in_start > in_end) return null;

            TreeNode root = new TreeNode(postorder[post_end]);
            int inorder_idx = inorder_map[postorder[post_end]];

            // 0  1  2  3  4
            // 9  3 15 20  7
            // 9 15  7 20  3

            // post_end = 4
            // (post_end-post_start+1)  => 目前陣列長度
            // (1 - 0) = 1 => 左子樹陣列長度
            root.left = ConstructTree(inorder, in_start, inorder_idx - 1, postorder, post_start, post_start + (inorder_idx - in_start - 1), inorder_map);
            root.right = ConstructTree(inorder, inorder_idx + 1, in_end, postorder, post_start + (inorder_idx-in_start) , post_end - 1, inorder_map);
            return root;
        }


    }
}
