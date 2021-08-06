using System;
using System.Collections.Generic;
using System.Linq;

namespace N_ary_Tree_Level_Order_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }

    public class Solution
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null) return result;
            Dictionary<int, IList<int>> map = new Dictionary<int, IList<int>>();

            Queue<Tuple<Node, int>> queue = new Queue<Tuple<Node, int>>();
            queue.Enqueue(new Tuple<Node, int>(root, 0));

            while (queue.Count > 0)
            {
                var currTuple = queue.Dequeue();
                var currNode = currTuple.Item1;
                var currLevel = currTuple.Item2;

                if (map.ContainsKey(currLevel) == false)
                {
                    map.Add(currLevel, new List<int> { currNode.val });
                }
                else
                {
                    map[currLevel].Add(currNode.val);
                }

                foreach (var child in currNode.children)
                {
                    queue.Enqueue(new Tuple<Node, int>(child, currLevel + 1));
                }
            }
            var keys = map.Keys.ToList();
            foreach (var key in keys.OrderBy(a => a))
            {
                result.Add(map[key]);
            }
            return result;
        }
    }

}
