using ShareLib;
using System;

namespace _0083_Remove_Duplicates_From_Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = LinkedListHelper.ConvertToListNodes(new int[] { 1, 1, 2, 3, 3 });
            var r = DeleteDuplicates_v2(l1);
            LinkedListHelper.PrintListNodes(r);
            Console.ReadKey();
        }

        public static ListNode DeleteDuplicates_v2(ListNode head)
        {
            ListNode curr = head;
            ListNode prev = null;
            while (curr != null)
            {
                if (prev != null)
                {
                    if (prev.val == curr.val)
                    {
                        prev.next = curr.next;
                        curr = curr.next;
                    }
                    else
                    {
                        prev = curr;
                        curr = curr.next;
                    }
                }
                else
                {
                    prev = curr;
                    curr = curr.next;
                }
            }
            return head;
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


        public ListNode DeleteDuplicates_v3(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return head;

            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                if (prev != null)
                {
                    if (prev.val == curr.val)
                    {
                        //prev == curr => remove curr
                        prev.next = curr.next;
                        curr = curr.next;
                        continue;
                    }
                }
                prev = curr;
                curr = curr.next;
            }
            return head;
        }

    }
}
