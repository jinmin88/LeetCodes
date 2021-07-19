using System;
using System.Collections.Generic;
using System.Text;

namespace ShareLib
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x, TreeNode left = null, TreeNode right = null) 
        { 
            this.val = x;
            this.left = left;
            this.right = right;
        }

    }
}
