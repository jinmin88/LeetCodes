using ShareLib;
using System;

namespace _1290_Convert_Binary_Number_in_a_Linked_List_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = LinkedListHelper.ConvertToListNodes(new int[] { 1, 0, 1 });

            Console.WriteLine("l1=" + GetDecimalValue(l1));
        }


        public static int GetDecimalValue(ListNode head)
        {
            ListNode current = head;
            int result = 0;
            while (current != null)
            {
                result = (result << 1) + current.val;
                current = current.next;
            }
            return result;
        }
    }
}
