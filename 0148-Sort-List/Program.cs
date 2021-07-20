using ShareLib;
using System;

namespace _0148_Sort_List
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
        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode mid = MidList(head);
            ListNode left = SortList(head);
            ListNode right = SortList(mid);
            return Merge(left, right);
        }

        private ListNode MidList(ListNode head)
        {
            ListNode curr = null;
            while (head != null && head.next != null)
            {
                if (curr == null)
                {
                    curr = head;
                }
                else
                {
                    curr = curr.next;
                }
                head = head.next.next;
            }
            ListNode mid = curr.next;
            curr.next = null;
            return mid;
        }
    
        private ListNode Merge(ListNode left, ListNode right)
        {
            ListNode dummyHead = new ListNode();
            ListNode tail = dummyHead;

            while (left != null && right != null)
            {
                tail.next = left;
            }
        }
    
    
    }

}
