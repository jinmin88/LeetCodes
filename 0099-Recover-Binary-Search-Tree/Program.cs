using ShareLib;
using System;
using System.Collections.Generic;

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
            List<int> arr = new List<int>();
            InOrder(root, arr);

            // 1 3 2 4 5 6
            // v x v v v v

            // 1 5 3 4 2 6
            // v f v v s v
            // swap(x, x+1)

            // 3 1
            // x o

            int firstIdx = -1;
            int secondIdx = -1;

            for (int i=0; i<arr.Count - 1; i++)
            {
                if (arr[i] > arr[i+1])
                {
                    if (firstIdx == -1)
                        firstIdx = i;
                    else
                        secondIdx = i + 1;
                }
            }

            int swap1, swap2;
            if (secondIdx == -1)
            {
                swap1 = arr[firstIdx];
                swap2 = arr[firstIdx + 1];
            }
            else
            {
                swap1 = arr[firstIdx];
                swap2 = arr[secondIdx];
            }

            SwapInOrder(root, swap1, swap2);
        }

        public void SwapInOrder(TreeNode root, int swap1, int swap2)
        {
            if (root == null) return;
            SwapInOrder(root.left, swap1, swap2);
            if (root.val == swap1)
            {
                root.val = swap2;
            }
            else if (root.val == swap2)
            {
                root.val = swap1;
            }
            SwapInOrder(root.right, swap1, swap2);
        }


        public void InOrder(TreeNode root, List<int> arr)
        {
            if (root == null) return;
            InOrder(root.left, arr);
            arr.Add(root.val);
            InOrder(root.right, arr);
        }
    }


}
