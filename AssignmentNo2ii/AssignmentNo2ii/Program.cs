using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo2ii
{
    class Employee
    {
        private int Id;
        private string Name;
        private string Address;
        private double Salary;

        // Default Constructor
        public Employee()
        {
            Id = 0;
            Name = "Unknown";
            Address = "Not Provided";
            Salary = 0.0;
        }

        // Parameterized Constructor
        public Employee(int id, string name, string address, double salary)
        {
            Id = id;
            Name = name;
            Address = address;
            Salary = salary;
        }

        // Method to display employee details
        public void Display()
        {
            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Salary: " + Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create object using default constructor
            Employee emp1 = new Employee();
            Console.WriteLine("Details of Employee 1 (default constructor):");
            emp1.Display();

            // Create object using parameterized constructor
            Employee emp2 = new Employee(201, "John Doe", "Pune", 50000);
            Console.WriteLine("\nDetails of Employee 2 (parameterized constructor):");
            emp2.Display();
        }
    }
}
