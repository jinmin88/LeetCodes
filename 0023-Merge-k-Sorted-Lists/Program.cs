using ShareLib;
using System;

namespace _0023_Merge_k_Sorted_Lists
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
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0) 
                return null;
            else if (lists.Length == 1) 
                return lists[0];
            else
            {
                var sortedList = lists[0];
                for (int i = 1; i < lists.Length; i++)
                {
                    sortedList = MergeSortedList(sortedList, lists[i]);
                }
                return sortedList;
            }
        }


        private ListNode MergeSortedList(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            ListNode head = new ListNode(0);
            ListNode curr = head;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    curr.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    curr.next = l2;
                    l2 = l2.next;
                }
                curr = curr.next;
            }

            if (l1 != null)
            {
                curr.next = l1;
            }
            if (l2 != null)
            {
                curr.next = l2;
            }
            return head.next;
        }
    }
}
