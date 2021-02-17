using ShareLib;
using System;

namespace _0083_Remove_Duplicates_From_Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = LinkedListHelper.ConvertToListNodes(new int[] { 1, 1, 2, 3, 3 });
            var r = DeleteDuplicates(l1);
            LinkedListHelper.PrintListNodes(r);
        }


        public static ListNode DeleteDuplicates(ListNode head)
        {
            return null;
        }
    }
}
