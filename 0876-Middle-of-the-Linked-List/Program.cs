using ShareLib;
using System;

namespace _0876_Middle_of_the_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = LinkedListHelper.ConvertToListNodes(new int[] { 1, 2, 3, 4, 5 });
            ListNode l2 = LinkedListHelper.ConvertToListNodes(new int[] { 1, 2, 3, 4, 5, 6 });

            ListNode m1 = MiddleNode(l1);
            ListNode m2 = MiddleNode(l2);

            Console.WriteLine($"m1={m1.val}");
            Console.WriteLine($"m2={m2.val}");


        }

        public static ListNode MiddleNode(ListNode head)
        {
            ListNode f = head;
            ListNode s = head;

            while (s != null && s.next != null)
            {
                f = f.next;
                s = s.next.next;
            }
            return f;
        }
    }
}
