using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo7vi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a collection for string data that does not allow duplicates.
            // HashSet<T> is ideal as it ensures all elements are unique.
            HashSet<string> uniqueList = new HashSet<string>();
            uniqueList.Add("Apple");
            uniqueList.Add("Banana");
            uniqueList.Add("Cherry");

            // Attempting to add a duplicate element. It will be ignored.
            bool added = uniqueList.Add("Apple");
            // 'added' will be false, and the set remains unchanged.

            Console.WriteLine("List 1 (Unique Elements - HashSet):");
            Console.WriteLine(string.Join(" -> ", uniqueList));
            Console.WriteLine("-----------------------------------");


            // 2. Create a standard singly linked list for string data.
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("Banana");
            linkedList.AddLast("Date");
            linkedList.AddLast("Fig");
            linkedList.AddLast("Banana"); // Duplicates are allowed here.

            Console.WriteLine("List 2 (Allows Duplicates - LinkedList):");
            Console.WriteLine(string.Join(" -> ", linkedList));
            Console.WriteLine("-----------------------------------");


            // a. Perform Union
            // The Union() method returns the unique elements from both collections.
            var unionResult = uniqueList.Union(linkedList);
            Console.WriteLine("\na. Union of the two lists:");
            Console.WriteLine(string.Join(" -> ", unionResult));
            Console.WriteLine("-----------------------------------");


            // b. Perform Intersection
            // The Intersect() method returns the elements that are common to both collections.
            var intersectionResult = uniqueList.Intersect(linkedList);
            Console.WriteLine("\nb. Intersection of the two lists:");
            Console.WriteLine(string.Join(" -> ", intersectionResult));
            Console.WriteLine("-----------------------------------");


            // c. Combining corresponding elements if lists are of the same size
            Console.WriteLine("\nc. Combining corresponding elements:");

            // We use .Count for both HashSet and LinkedList to check their sizes.
            if (uniqueList.Count == linkedList.Count)
            {
                // The Zip() method merges two sequences by combining elements at the same index.
                var combinedList = uniqueList.Zip(linkedList, (first, second) => $"{first} & {second}");

                Console.WriteLine("Combined List (since sizes are equal):");
                Console.WriteLine(string.Join(" -> ", combinedList));
            }
            else
            {
                Console.WriteLine($"Lists cannot be combined as they are of different sizes ({uniqueList.Count} and {linkedList.Count}).");
            }
            Console.WriteLine("-----------------------------------");

            // Example with lists of the same size to demonstrate combination
            HashSet<string> sameSizeList1 = new HashSet<string> { "One", "Two", "Three" };
            LinkedList<string> sameSizeList2 = new LinkedList<string>(new[] { "Four", "Five", "Six" });

            Console.WriteLine("\nExample with lists of the same size:");
            Console.WriteLine($"List A: {string.Join(" -> ", sameSizeList1)}");
            Console.WriteLine($"List B: {string.Join(" -> ", sameSizeList2)}");

            if (sameSizeList1.Count == sameSizeList2.Count)
            {
                var combinedList = sameSizeList1.Zip(sameSizeList2, (first, second) => $"{first} & {second}");
                Console.WriteLine("Combined List:");
                Console.WriteLine(string.Join(" -> ", combinedList));
            }
        }
    }
}
