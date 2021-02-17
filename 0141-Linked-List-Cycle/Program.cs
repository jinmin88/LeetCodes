using ShareLib;
using System;

namespace _0141_Linked_List_Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = LinkedListHelper.ConvertToListNodesWithCycle(new int[] { 3, 2, 0, -4 }, 1);
            var l2 = LinkedListHelper.ConvertToListNodesWithCycle(new int[] { 1, 2 }, 0);
            var l3 = LinkedListHelper.ConvertToListNodes(new int[] { 1 });
            bool ll1 = HasCycle(l1);
            bool ll2 = HasCycle(l2);
            bool ll3 = HasCycle(l3);
            Console.WriteLine($"l1 has cycle :{ll1}");
            Console.WriteLine($"l2 has cycle :{ll2}");
            Console.WriteLine($"l3 has cycle :{ll3}");
            Console.ReadKey();
        }

        public static bool HasCycle(ListNode head)
        {
            var p1 = head;
            var p2 = head;

            while (p1 != null && p2 != null)
            {
                p1 = p1.next;
                if (p1 == null) return false;
                if (p2.next == null) return false;
                p2 = p2.next.next;
                if (p2 == null) return false;
                if (p1 == p2)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
