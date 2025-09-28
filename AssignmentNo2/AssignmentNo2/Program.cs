using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo2
{
    class Student
    {
        public int RollNo;
        public string Name;
        public string Address;
        public string MobileNo;

        // Method to accept student details
        public void Accept()
        {
            Console.Write("Enter Roll No: ");
            RollNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Address: ");
            Address = Console.ReadLine();

            Console.Write("Enter Mobile No: ");
            MobileNo = Console.ReadLine();
        }
        // Method to display student details
        public void Display()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("Roll No: " + RollNo);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Mobile No: " + MobileNo);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            Student[] students = new Student[n];

            // Accept details for each student
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter details for Student {i + 1}:");
                students[i] = new Student();
                students[i].Accept();
            }

            // Display details for each student
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nDetails of Student {i + 1}:");
                students[i].Display();
            }
        }
    }
}
