using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo4ii
{
    // Define the interface for stack operations
    interface StackOperations
    {
        void Push(int item);
        int Pop();
        int Peek();
        void Display();
    }

    // Implement the stack in MyStack class
    class MyStack : StackOperations
    {
        private int[] stackArray;
        private int top;
        private int maxSize;

        // Constructor to initialize the stack
        public MyStack(int size)
        {
            maxSize = size;
            stackArray = new int[maxSize];
            top = -1;
        }

        // Push operation
        public void Push(int item)
        {
            if (top >= maxSize - 1)
            {
                Console.WriteLine("Stack Overflow! Cannot push item.");
                return;
            }
            stackArray[++top] = item;
            Console.WriteLine($"{item} pushed into the stack.");
        }

        // Pop operation
        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow! Cannot pop item.");
                return -1;
            }
            int item = stackArray[top--];
            Console.WriteLine($"{item} popped from the stack.");
            return item;
        }

        // Peek operation
        public int Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }
            Console.WriteLine($"Top element is {stackArray[top]}");
            return stackArray[top];
        }

        // Display operation
        public void Display()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack is empty!");
                return;
            }
            Console.WriteLine("Stack elements are:");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stackArray[i]);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the stack: ");
            int size = int.Parse(Console.ReadLine());

            MyStack stack = new MyStack(size);

            int choice;
            do
            {
                Console.WriteLine("\n--- Stack Operations Menu ---");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Display");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter element to push: ");
                        int item = int.Parse(Console.ReadLine());
                        stack.Push(item);
                        break;

                    case 2:
                        stack.Pop();
                        break;

                    case 3:
                        stack.Peek();
                        break;

                    case 4:
                        stack.Display();
                        break;

                    case 5:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }

            } while (choice != 5);
        }
    }
}
