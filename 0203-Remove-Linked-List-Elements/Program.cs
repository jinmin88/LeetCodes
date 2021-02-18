using ShareLib;
using System;

namespace _0203_Remove_Linked_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = LinkedListHelper.ConvertToListNodes(new int[] { 1, 2, 6, 3, 4, 5, 6 });
            l1 = RemoveElements(l1, 6);
            LinkedListHelper.PrintListNodes(l1);
            Console.ReadKey();

        }

        public static ListNode RemoveElements(ListNode head, int val)
        {
            ListNode current = head;
            ListNode prev = null;
            while (current != null)
            {
                if (current.val == val)
                {
                    if (prev == null)
                    {
                        if (current.next == null)
                        {
                            //prev ==  null && current.next == null, 代表只有一個節點，return null
                            return null;
                        }
                        else
                        {
                            //prev == null && current.next != null 代表需要刪除第一個節點
                            head = current.next;
                            current = current.next;
                            prev = null;
                        }
                    }
                    else
                    {
                        if (current.next == null)
                        {
                            //prev != null but current.next == null 代表在結尾處
                            prev.next = null;
                            current = current.next;
                        }
                        else
                        {
                            prev.next = current.next;
                            current = current.next;
                        }
                    }
                }
                else
                {
                    prev = current;
                    current = current.next;
                }
            }
            return head;

        }
    }
}
