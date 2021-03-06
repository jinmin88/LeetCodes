﻿using System;
using ShareLib;
namespace _0002_Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = LinkedListHelper.ConvertToListNodes(new int[] { 9, 9, 9, 9, 9, 9, 9 });
            var l2 = LinkedListHelper.ConvertToListNodes(new int[] { 9, 9, 9, 9 });

            var sub = AddTwoNumbers(l1, l2);
            LinkedListHelper.PrintListNodes(sub);

            Console.ReadKey();
        }


        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int overhead = 0;

            ListNode head = null;
            ListNode curr = null;

            while (l1 != null || l2 != null || overhead > 0)
            {
                if (l1 != null && l2 != null)
                {
                    var new_val = l1.val + l2.val + overhead;
                    overhead = new_val / 10;
                    new_val %= 10;
                    if (head == null)
                    {
                        head = new ListNode(new_val, null);
                        curr = head;
                    }
                    else
                    {
                        curr.next = new ListNode(new_val, null);
                        curr = curr.next;
                    }
                    l1 = l1.next;
                    l2 = l2.next;
                }
                else if (l1 != null && l2 == null)
                {
                    var new_val = l1.val + overhead;
                    overhead = new_val / 10;
                    new_val %= 10;
                    if (head == null)
                    {
                        head = new ListNode(new_val, null);
                        curr = head;
                    }
                    else
                    {
                        curr.next = new ListNode(new_val, null);
                        curr = curr.next;
                    }
                    l1 = l1.next;
                }
                else if (l1 == null && l2 != null)
                {
                    var new_val = l2.val + overhead;
                    overhead = new_val / 10;
                    new_val %= 10;
                    if (head == null)
                    {
                        head = new ListNode(new_val, null);
                        curr = head;
                    }
                    else
                    {
                        curr.next = new ListNode(new_val, null);
                        curr = curr.next;
                    }
                    l2 = l2.next;
                }
                else
                {
                    var new_val = overhead;
                    overhead = new_val / 10;
                    new_val %= 10;
                    if (head == null)
                    {
                        head = new ListNode(new_val, null);
                        curr = head;
                    }
                    else
                    {
                        curr.next = new ListNode(new_val, null);
                        curr = curr.next;
                    }
                }
            }

            return head;

        }


    }
}
