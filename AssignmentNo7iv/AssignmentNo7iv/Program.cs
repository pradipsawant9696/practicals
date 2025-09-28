using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo7iv
{
    internal class Program
    {
        // Function to delete the bottom element
        static void DeleteBottom(Stack<int> stack)
        {
            if (stack.Count == 0)
                return;

            int top = stack.Pop();

            if (stack.Count == 0)
            {
                // This is the bottom element → discard
                return;
            }

            // Recursive call
            DeleteBottom(stack);

            // Push back other elements
            stack.Push(top);
        }

        static void Main()
        {
            Stack<int> stack = new Stack<int>();

            // Push elements
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            Console.WriteLine("Original Stack: " + string.Join(", ", stack));

            DeleteBottom(stack);

            Console.WriteLine("After deleting bottom element: " + string.Join(", ", stack));
        }
    }
}
