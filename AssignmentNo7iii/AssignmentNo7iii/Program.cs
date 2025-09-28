using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo7iii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create a Hashtable
            Hashtable students = new Hashtable();

            // Adding student name and percentage
            students.Add("Alice", 85.5);
            students.Add("Bob", 92.3);
            students.Add("Charlie", 76.8);
            students.Add("David", 88.9);

            // Step 2: Display all details
            Console.WriteLine("Student Records:");
            foreach (DictionaryEntry entry in students)
            {
                Console.WriteLine("Name: " + entry.Key + " | Percentage: " + entry.Value);
            }

            // Step 3: Search for a student
            Console.Write("\nEnter student name to search: ");
            string name = Console.ReadLine();

            if (students.ContainsKey(name))
            {
                Console.WriteLine($"Percentage of {name}: {students[name]}");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }
    }
}
