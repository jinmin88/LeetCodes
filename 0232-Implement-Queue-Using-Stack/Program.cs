using System;
using System.Collections.Generic;

namespace _0232_Implement_Queue_Using_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class MyQueue
    {
        private readonly Stack<int> in_stack = new Stack<int>();
        private readonly Stack<int> out_stack = new Stack<int>();
        /** Initialize your data structure here. */
        public MyQueue()
        {
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            in_stack.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (out_stack.Count > 0)
            {
                return out_stack.Pop();
            }
            else
            {
                while (in_stack.Count > 0)
                {
                    out_stack.Push(in_stack.Pop());
                }
                return out_stack.Pop();
            }
        }

        /** Get the front element. */
        public int Peek()
        {
            if (out_stack.Count > 0)
            {
                return out_stack.Peek();
            }
            else
            {
                while (in_stack.Count > 0)
                {
                    out_stack.Push(in_stack.Pop());
                }
                return out_stack.Peek();
            }
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            if (out_stack.Count == 0 && in_stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
