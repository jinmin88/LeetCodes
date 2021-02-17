using ShareLib;
using System;

namespace _0021_Merge_Two_Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = LinkedListHelper.ConvertToListNodes(new int[] { 1, 2, 4 });
            ListNode l2 = LinkedListHelper.ConvertToListNodes(new int[] { 1, 3, 4 });

            var l3 = MergeTwoLists(l1, l2);
            LinkedListHelper.PrintListNodes(l3);
            Console.ReadKey();
        }


        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {

            if (l1 == null) return l2;
            if (l2 == null) return l1;

            ListNode ret = new ListNode(0);
            ListNode curr = ret;

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

            return ret.next;
        }



    }
}
