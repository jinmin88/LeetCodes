using ShareLib;
using System;

namespace _0092_Reverse_Linked_List_II
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
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (head == null)
                return null;

            ListNode curr = head;
            ListNode prev = null;

            //move pointer to the first location need reverse
            while (m > 1)
            {
                prev = curr;
                curr = curr.next;
                m--;
                n--;
            }

            ListNode con = prev;
            ListNode tail = curr;
            ListNode next;

            while (n > 0)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
                n--;
            }

            if (con != null)
            {
                con.next = prev;
            }
            else
            {
                head = prev;
            }

            tail.next = curr;
            return head;

        }
    }
}
