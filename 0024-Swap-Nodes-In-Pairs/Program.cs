using ShareLib;
using System;

namespace _0024_Swap_Nodes_In_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = LinkedListHelper.ConvertToListNodes(new int[] { 1, 2, 3, 4 , 5});
            var l2 = SwapPairs(l1);
            LinkedListHelper.PrintListNodes(l2);
            Console.ReadKey();
        }

        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null) { return null; }
            else if (head.next == null) { return head; }
            else
            {
                ListNode prev = null;
                ListNode first = head;
                ListNode second = head.next;

                while (first != null && second != null)
                {
                    first.next = second.next;
                    second.next = first;
                    if (prev != null)
                    {
                        prev.next = second;
                    }
                    else
                    {
                        head = second;
                    }
                    if (first.next != null && first.next.next != null)
                    {
                        second = first.next.next;
                        prev = first;
                        first = first.next;
                    }
                    else if (first.next != null && first.next.next == null)
                    {
                        break;
                    }
                    else if (first.next == null)
                    {
                        break;
                    }
                }
                return head;
            }
        }
    }
}
