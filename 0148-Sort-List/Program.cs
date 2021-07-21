using ShareLib;
using System;

namespace _0148_Sort_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7, 3, 1, 9, 2, 6, 5
            ListNode head = new ListNode(7);
            var curr = head;
            curr.next = new ListNode(3);
            curr = curr.next;
            curr.next = new ListNode(1);
            curr = curr.next;
            curr.next = new ListNode(9);
            curr = curr.next;
            curr.next = new ListNode(2);
            curr = curr.next;
            curr.next = new ListNode(6);
            curr = curr.next;
            curr.next = new ListNode(5);

            LinkedListHelper.PrintListNodes(head);
            Solution sol = new Solution();
            head = sol.SortList(head);

            LinkedListHelper.PrintListNodes(head);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode mid = MidList(head);
            ListNode left = SortList(head);
            ListNode right = SortList(mid);
            head = Merge(left, right);
            return head;
        }

        private ListNode MidList(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode pre_prev = null;
            ListNode prev = head;
            while (head != null && head.next != null)
            {
                pre_prev = prev;
                prev = prev.next;
                head = head.next.next;
            }
            pre_prev.next = null;
            return prev;
        }
    
        private ListNode Merge(ListNode left, ListNode right)
        {
            ListNode head = null;
            ListNode tail = null;
            while (left != null && right != null)
            {
                if (left.val < right.val)
                {
                    if (head == null)
                    {
                        head = left;
                        tail = left;
                        left = left.next;
                    }
                    else
                    {
                        tail.next = left;
                        tail = tail.next;
                        left = left.next;
                    }
                }
                else
                {
                    if (head == null)
                    {
                        head = right;
                        tail = right;
                        right = right.next;
                    }
                    else
                    {
                        tail.next = right;
                        tail = tail.next;
                        right = right.next;
                    }
                }
            }
            if (right != null)
            {
                tail.next = right;
            }
            if (left != null)
            {
                tail.next = left;
            }
            return head;
        }
    
    }

}
