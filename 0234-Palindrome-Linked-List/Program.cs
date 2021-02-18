using ShareLib;
using System;

namespace _0234_Palindrome_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = LinkedListHelper.ConvertToListNodes(new int[] { 1, 2 });
            ListNode l2 = LinkedListHelper.ConvertToListNodes(new int[] { 1, 2, 3, 2, 1 });

            Console.WriteLine($"l1 IsPalindrome={IsPalindrome(l1)}");
            Console.WriteLine($"l2 IsPalindrome={IsPalindrome(l2)}");

            Console.ReadKey();

        }

        
        public static bool IsPalindrome(ListNode head)
        {
            //首先，先複製一串同樣的link list
            var r_head = ReverseList(CloneList(head));

            ListNode current = head;
            ListNode r_current = r_head;

            while (current != null && r_current != null)
            {
                if (current.val != r_current.val)
                {
                    return false;
                }
                else
                {
                    current = current.next;
                    r_current = r_current.next;
                }
            }

            if (current == null && r_current == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        private static ListNode CloneList(ListNode head)
        {
            var current = head;
            ListNode head2 = null;
            ListNode current2 = null;

            while (current != null)
            {
                if (head2 == null)
                {
                    current2 = new ListNode(current.val);
                    head2 = current2;
                }
                else
                {
                    current2.next = new ListNode(current.val);
                    current2 = current2.next;
                }
                current = current.next;
            }
            return head2;
        }

        private static ListNode ReverseList(ListNode head)
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
