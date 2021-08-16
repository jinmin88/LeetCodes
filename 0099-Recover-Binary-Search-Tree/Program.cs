using ShareLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _0099_Recover_Binary_Search_Tree
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
        public void RecoverTree(TreeNode root)
        {
            List<int> orignal = new List<int>();
            InOrderTraversal(root, orignal);

            var ordered = orignal.OrderBy(a => a).ToList();

            int swap1 = 0; int swap2 = 0;
            for (int i=0; i<orignal.Count; i++)
            {
                if (orignal[i] != ordered[i])
                {
                    swap1 = orignal[i];
                    swap2 = ordered[i];
                }
            }
            InOrderSwap(root, swap1, swap2);
        }


        private void InOrderSwap(TreeNode root, int swap1, int swap2)
        {
            if (root == null) return;
            InOrderSwap(root.left, swap1, swap2);
            root.val = root.val == swap1 ? swap2 : root.val == swap2 ? swap1 : root.val;
            InOrderSwap(root.right, swap1, swap2);
        }

        private void InOrderTraversal(TreeNode root, List<int> arr)
        {
            if (root == null) return;
            InOrderTraversal(root.left, arr);
            arr.Add(root.val);
            InOrderTraversal(root.right, arr);
        }
    }
}
