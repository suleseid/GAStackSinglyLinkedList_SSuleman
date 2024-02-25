using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAStackSinglyLinkedList_SSuleman
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            // Testing Push, Peek, and Pop
            stack.Push(11);
            stack.Push(15);
            stack.Push(23);
            stack.Push(44);
            stack.Push(55);

            Console.WriteLine("Peek: " + stack.Peek()); // Should print 3

            Console.WriteLine("Pop: " + stack.Pop()); // Should print 3
            Console.WriteLine("Pop: " + stack.Pop()); // Should print 2

            // stack.Push(44);
            Console.WriteLine("Peek: " + stack.Peek()); // Should print 4

            // Testing Clear
            stack.Clear();
            Console.WriteLine("Count after clear: " + stack.Count); // Should print 0

            // Testing error handling
            try
            {
                stack.Pop(); // This should throw InvalidOperationException
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught: " + e.Message); // Should print "Stack is empty"
            }

           
        }   
    }
}
