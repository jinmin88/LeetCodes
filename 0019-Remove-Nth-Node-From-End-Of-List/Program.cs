using ShareLib;
using System;

namespace _0019_Remove_Nth_Node_From_End_Of_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = LinkedListHelper.ConvertToListNodes(new int[] { 1, 2, 3, 4, 5 });
            var l2 = RemoveNthFromEnd_v2(l1, 2);
            LinkedListHelper.PrintListNodes(l2);
            Console.ReadKey();
        }

        public static ListNode RemoveNthFromEnd_v2(ListNode head, int n)
        {
            if (head == null) return null;
            if (head.next == null && n == 1) return null;



            ListNode curr = head;
            int total_len = 0;
            while (curr != null)
            {
                total_len += 1;
                curr = curr.next;
            }
            ListNode prev = null; 
            curr = head;

            int cnt = 1;
            while (curr != null)
            {
                if (total_len - cnt + 1 == n)
                {
                    if (prev != null && curr.next != null)
                    {   // p c
                        // 3 4 5
                        prev.next = curr.next;
                        return head;
                    }
                    else if (prev == null && curr.next != null)
                    {
                        //p c
                        //  3 4 5
                        head = curr.next;
                        return head;
                    }
                    else if (prev != null && curr.next == null)
                    {
                        prev.next = null;
                        return head;
                    }
                }
                else
                {
                    prev = curr;
                    curr = curr.next;
                    cnt++;
                }
            }


            return head;

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
