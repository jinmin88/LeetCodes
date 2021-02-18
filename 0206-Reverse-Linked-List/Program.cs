using ShareLib;
using System;

namespace _0206_Reverse_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = LinkedListHelper.ConvertToListNodes(new int[] { 1, 2, 3, 4, 5 });
            l1 = ReverseList(l1);
            LinkedListHelper.PrintListNodes(l1);
            Console.ReadKey();
        }

        public static ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;

            while (current != null)
            {
                ListNode nextNode = current.next;
                current.next = prev;
                prev = current;
                current = nextNode;
            }
            return prev;
        }
    }
}
