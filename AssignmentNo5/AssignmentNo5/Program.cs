using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo5
{
    class Maximum
    {
        // Find maximum between two numbers
        public int FindMax(int a, int b)
        {
            return (a > b) ? a : b;
        }

        // Find maximum between three numbers
        public int FindMax(int a, int b, int c)
        {
            int max = (a > b) ? a : b;
            return (max > c) ? max : c;
        }

        // Find maximum between four numbers
        public int FindMax(int a, int b, int c, int d)
        {
            int max = FindMax(a, b, c); // reuse three-number version
            return (max > d) ? max : d;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Maximum max = new Maximum();

            // Find maximum between two numbers
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Maximum between {a} and {b} is: {max.FindMax(a, b)}");

            // Find maximum between three numbers
            Console.Write("\nEnter first number: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int d = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine($"Maximum between {c}, {d}, and {e} is: {max.FindMax(c, d, e)}");

            // Find maximum between four numbers
            Console.Write("\nEnter first number: ");
            int f = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int g = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int h = int.Parse(Console.ReadLine());

            Console.Write("Enter fourth number: ");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine($"Maximum between {f}, {g}, {h}, and {i} is: {max.FindMax(f, g, h, i)}");
        }
    }
}
