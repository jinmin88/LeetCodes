using ShareLib;
using System;

namespace _0019_Remove_Nth_Node_From_End_Of_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = LinkedListHelper.ConvertToListNodes(new int[] { 1, 2, 3, 4, 5 });
            var l2 = RemoveNthFromEnd(l1, 2);
            LinkedListHelper.PrintListNodes(l2);
            Console.ReadKey();
        }


        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head.next == null && n == 1) { return null; }
            if (head.next != null && head.next.next == null)
            {
                if (n == 1)
                {
                    head.next = null;
                    return head;
                }
                else
                {
                    head = head.next;
                    return head;
                }
            }

            int all_node_count = 0;
            var current = head;
            while (current != null)
            {
                current = current.next;
                all_node_count++;
            }

            current = head;
            ListNode prev = null;
            int cnt = 1;
            while (current != null)
            {
                if (all_node_count - cnt + 1 == n)
                {
                    if (prev == null)
                    {
                        head = current.next;
                        break;
                    }
                    else
                    {
                        prev.next = current.next;
                        break;
                    }
                }
                prev = current;
                current = current.next;
                cnt++;
            }
            return head;
        }
    }
}
