using System;
using System.Collections.Generic;

namespace _0255_Implement_Stack_Using_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class MyStack
    {
        private readonly Queue<int> main_queue = new Queue<int>();
        private readonly Queue<int> temp_queue = new Queue<int>();
        /** Initialize your data structure here. */
        public MyStack()
        {
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            main_queue.Enqueue(x);
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            int val = 0;
            while (main_queue.Count > 0)
            {
                if (main_queue.Count > 1)
                {
                    temp_queue.Enqueue(main_queue.Dequeue());
                }
                else
                {
                    val = main_queue.Dequeue();
                }
            }

            while (temp_queue.Count > 0)
            {
                main_queue.Enqueue(temp_queue.Dequeue());
            }
            return val;
        }

        /** Get the top element. */
        public int Top()
        {
            int val = 0;
            while (main_queue.Count > 0)
            {
                if (main_queue.Count > 1)
                {
                    temp_queue.Enqueue(main_queue.Dequeue());
                }
                else
                {
                    val = main_queue.Dequeue();
                    temp_queue.Enqueue(val);
                }
            }

            while (temp_queue.Count > 0)
            {
                main_queue.Enqueue(temp_queue.Dequeue());
            }
            return val;
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return main_queue.Count == 0 ? true : false;
        }
    }
}
