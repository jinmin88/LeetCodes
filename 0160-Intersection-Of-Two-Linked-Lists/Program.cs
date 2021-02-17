using System;
using ShareLib;

namespace _0160_Intersection_Of_Two_Linked_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = LinkedListHelper.ConvertToIntersectionLinkedList(new int[] { 4, 1 }, new int[] { 5, 6, 1 }, new int[] { 8, 4, 5 });
            var t2 = LinkedListHelper.ConvertToIntersectionLinkedList(new int[] { 1, 9, 1 }, new int[] { 3 }, new int[] { 2, 4 });
            var t3 = new Tuple<ListNode, ListNode>(LinkedListHelper.ConvertToListNodes(new int[] { 2, 6, 4 }), LinkedListHelper.ConvertToListNodes(new int[] { 1, 5 }));
            var l1 = GetIntersectionNode(t1.Item1, t1.Item2);
            var l2 = GetIntersectionNode(t2.Item1, t2.Item2);
            var l3 = GetIntersectionNode(t3.Item1, t3.Item2);
            if (l1 == null)
            {
                Console.WriteLine("l1: null");
            }
            else
            {
                Console.WriteLine("l1: Reference of the node with value = " + l1.val);
            }
            if (l2 == null)
            {
                Console.WriteLine("l2: null");
            }
            else
            {
                Console.WriteLine("l2: Reference of the node with value = " + l2.val);
            }
            if (l3 == null)
            {
                Console.WriteLine("l3: null");
            }
            else
            {
                Console.WriteLine("l3: Reference of the node with value = " + l3.val);
            }
            Console.ReadKey();
        }


        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode pA = headA;
            ListNode pB = headB;

            if (pA == null || pB == null) return null;

            while (pA != pB)
            {
                pA = pA.next;
                pB = pB.next;

                if (pA == pB)
                {
                    return pA;
                }

                if (pA == null)
                {
                    pA = headB;
                }

                if (pB == null)
                {
                    pB = headA;
                }
            }
            return pA;
        }
    }
}
