using ShareLib;
using System;

namespace _0237_Delete_Node_In_a_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void DeleteNode(ListNode node)
        {
            var next_node = node.next;
            node.val = next_node.val;
            node.next = next_node.next;
        }
    }
}
