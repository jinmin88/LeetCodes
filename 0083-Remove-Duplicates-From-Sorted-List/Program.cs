using ShareLib;
using System;

namespace _0083_Remove_Duplicates_From_Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = LinkedListHelper.ConvertToListNodes(new int[] { 1, 1, 2, 3, 3 });
            var r = DeleteDuplicates(l1);
            LinkedListHelper.PrintListNodes(r);
            Console.ReadKey();
        }


        public static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode current = head;
            ListNode prev = null;
            while (current != null)
            {
                if (prev == null)
                {
                    prev = current;
                    current = current.next;
                }
                else
                {
                    if (prev.val == current.val)
                    {
                        prev.next = current.next;
                    }
                    else
                    {
                        prev = current;
                    }
                    current = current.next;
                }
            }
            return head;
        }
    }
}
