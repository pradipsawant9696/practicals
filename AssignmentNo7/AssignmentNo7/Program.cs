using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            SortedSet<int> numbers = new SortedSet<int>();

            Console.WriteLine("Enter the numbers:");
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!numbers.Add(num))   // Add() returns false if duplicate
                {
                    Console.WriteLine($"Duplicate {num} ignored!");
                }
            }

            Console.WriteLine("\nNumbers in sorted order (no duplicates):");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
