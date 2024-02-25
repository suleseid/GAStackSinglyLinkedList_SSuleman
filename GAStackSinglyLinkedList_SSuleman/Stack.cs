using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAStackSinglyLinkedList_SSuleman
{
    public class Stack<T>
    {
        private class StackNode
        {
            public T Value;
            public StackNode Next;

            public int Data { get; internal set; }
        }

        private StackNode top; // Top of the stack
        public int Count { get; private set; } // Number of elements

        public Stack()
        {
            top = null; // Initialize top to null
            Count = 0; // Initialize count to zero
        }

        public void Push(T value)
        {
            var newNode = new StackNode { Value = value, Next = top };
            top = newNode; // Update top
            Count++;
        }

        public T Pop()
        {
            if (top == null)
                throw new InvalidOperationException("Stack is empty.");
            var poppedValue = top.Value;
            top = top.Next; // Move top to the next node
            Count--;
            return poppedValue;
        }

        public T Peek()
        {
            if (top == null)
                throw new InvalidOperationException("Stack is empty.");
            return top.Value;
        }
        // Method to check if the stack is empty
        public bool Empty()
        {
            return top == null;
        }
        // Method to check if the stack is empty
        public void Clear()
        {
            top = null; // Empty the stack
            Count = 0;
        }
        
        
    }

}
