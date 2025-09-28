using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo7v
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable students = new Hashtable();

            while (true)
            {
                Console.WriteLine("\n--- Student Menu ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display All Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Find Student with Highest Marks");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Student Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Percentage: ");
                        double percentage = double.Parse(Console.ReadLine());

                        if (!students.ContainsKey(name))
                        {
                            students.Add(name, percentage);
                            Console.WriteLine("Student added successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Student already exists!");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n--- All Students ---");
                        if (students.Count == 0)
                            Console.WriteLine("No records found.");
                        else
                        {
                            foreach (DictionaryEntry entry in students)
                            {
                                Console.WriteLine($"Name: {entry.Key}, Percentage: {entry.Value}");
                            }
                        }
                        break;

                    case 3:
                        Console.Write("Enter Student Name to Search: ");
                        string searchName = Console.ReadLine();

                        if (students.ContainsKey(searchName))
                            Console.WriteLine($"Percentage of {searchName}: {students[searchName]}");
                        else
                            Console.WriteLine("Student not found!");
                        break;

                    case 4:
                        Console.WriteLine("\n--- Student with Highest Marks ---");
                        if (students.Count == 0)
                            Console.WriteLine("No records available.");
                        else
                        {
                            string topStudent = "";
                            double maxMarks = double.MinValue;

                            foreach (DictionaryEntry entry in students)
                            {
                                if ((double)entry.Value > maxMarks)
                                {
                                    maxMarks = (double)entry.Value;
                                    topStudent = (string)entry.Key;
                                }
                            }
                            Console.WriteLine($"Topper: {topStudent}, Percentage: {maxMarks}");
                        }
                        break;

                    case 5:
                        return; // exit program

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }
    }
}
