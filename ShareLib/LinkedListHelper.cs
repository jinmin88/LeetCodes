using System;
using System.Collections.Generic;
using System.Text;

namespace ShareLib
{
    public class LinkedListHelper
    {
        public static ListNode ConvertToListNodes(int[] arrData)
        {
            ListNode head = null;
            ListNode current = null;
            for (int i = 0; i < arrData.Length; i++)
            {
                if (head == null)
                {
                    head = new ListNode
                    {
                        val = arrData[i],
                        next = null
                    };
                    current = head;
                    continue;
                }
                else
                {
                    var newNode = new ListNode
                    {
                        val = arrData[i],
                        next = null
                    };
                    current.next = newNode;
                    current = current.next;
                }
            }
            return head;
        }


        public static void PrintListNodes(ListNode listNode)
        {
            if (listNode == null)
            {
                Console.WriteLine("Empty linked list");
            }
            else
            {
                var current = listNode;
                while (current != null)
                {
                    if (current != listNode)
                    {
                        Console.Write($" -> {current.val}");
                    }
                    else
                    {
                        Console.Write($"{current.val}");
                    }
                    current = current.next;
                }
                Console.WriteLine();
            }
        }

    }
}
