using System;
using ShareLib;
using System.Collections;
using System.Collections.Generic;

namespace _0061_Rotate_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = LinkedListHelper.ConvertToListNodes(new int[] { 1, 2, 3, 4, 5 });
            var l2 = RotateRight(l1, 2);
            LinkedListHelper.PrintListNodes(l2);
            Console.ReadKey();
        }

        static int[] maxXor(int[] arr, int[] queries)
        {
            // solve here
            Dictionary<int, int> _maxCache = new Dictionary<int, int>();
            Dictionary<KeyValuePair<int, int>, int> _xorCache = new Dictionary<KeyValuePair<int, int>, int>();

            List<int> result = new List<int>();
            foreach (var q in queries)
            {
                if (_maxCache.ContainsKey(q))
                {
                    result.Add(_maxCache[q]);
                }
                else
                {
                    int max = int.MinValue;
                    int temp;
                    foreach (var data in arr)
                    {
                        if (data == q)
                        {
                            if (_xorCache.ContainsKey(new KeyValuePair<int, int>(q, data)))
                            {
                                temp = _xorCache[new KeyValuePair<int, int>(q, data)];
                                if (temp > max) max = temp;
                            }
                            else
                            {
                                temp = q ^ data;
                                _xorCache.Add(new KeyValuePair<int, int>(q, data), temp);
                                if (temp > max) max = temp;
                            }
                        }
                        else
                        {
                            if (_xorCache.ContainsKey(new KeyValuePair<int, int>(q, data)))
                            {
                                temp = _xorCache[new KeyValuePair<int, int>(q, data)];
                                if (temp > max) max = temp;
                            }
                            else if (_xorCache.ContainsKey(new KeyValuePair<int, int>(data, q)))
                            {
                                temp = _xorCache[new KeyValuePair<int, int>(data, q)];
                                if (temp > max) max = temp;
                            }
                            else
                            {
                                temp = q ^ data;
                                _xorCache.Add(new KeyValuePair<int, int>(q, data), temp);
                                _xorCache.Add(new KeyValuePair<int, int>(data, q), temp);
                                if (temp > max) max = temp;
                            }
                        }
                    }
                    _maxCache.Add(q, max);
                    result.Add(max);
                }
            }
            return result.ToArray();

        }

        public static ListNode RotateRight(ListNode head, int k)
        {
            if (head == null) return null;
            int len = 0;
            ListNode current = head;
            while (current != null)
            {
                current = current.next;
                len++;
            }
            k %= len;
            if (k == 0)
                return head;
            else
            {
                int cnt = 1;
                ListNode curr = head;
                ListNode prev = null;
                ListNode newHead = null;

                //  1 2 3 4 5  , 2
                while (curr != null)
                {
                    // len - cnt + 1 == k
                    if (len - cnt + 1 == k)
                    {
                        newHead = curr;
                        prev.next = null;
                    }
                    prev = curr;
                    if (curr.next == null)
                    {
                        curr.next = head;
                        break;
                    }
                    else
                    {
                        curr = curr.next;
                        cnt++;
                    }
                }
                return newHead;
            }
        }
    }
}
