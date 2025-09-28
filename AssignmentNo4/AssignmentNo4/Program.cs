using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo4
{
    class Employee
    {
        private int id;
        private string name;
        private string department;
        private double salary;

        // Default constructor
        public Employee()
        {
            id = 0;
            name = "Unknown";
            department = "None";
            salary = 0.0;
        }

        // Parameterized constructor
        public Employee(int id, string name, string department, double salary)
        {
            this.id = id;
            this.name = name;
            this.department = department;
            this.salary = salary;
        }

        // Method to accept data
        public virtual void Accept()
        {
            Console.Write("Enter Employee ID: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Department: ");
            department = Console.ReadLine();

            Console.Write("Enter Salary: ");
            salary = double.Parse(Console.ReadLine());
        }

        // Method to display data
        public virtual void Display()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Salary: " + salary);
        }

        // Provide access to salary for derived classes
        public double GetSalary()
        {
            return salary;
        }

        // Provide access to other details if needed
        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public string GetDepartment()
        {
            return department;
        }
    }

    // Derived class
    class Manager : Employee
    {
        private double bonus;

        // Default constructor
        public Manager() : base()
        {
            bonus = 0.0;
        }

        // Parameterized constructor
        public Manager(int id, string name, string department, double salary, double bonus)
            : base(id, name, department, salary)
        {
            this.bonus = bonus;
        }

        // Override Accept method
        public override void Accept()
        {
            base.Accept();

            Console.Write("Enter Bonus: ");
            bonus = double.Parse(Console.ReadLine());
        }

        // Override Display method
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Bonus: " + bonus);
            Console.WriteLine("Total Salary (Salary + Bonus): " + (GetSalary() + bonus));
        }

        // Method to get total salary
        public double GetTotalSalary()
        {
            return GetSalary() + bonus;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of managers: ");
            int n = int.Parse(Console.ReadLine());

            Manager[] managers = new Manager[n];

            // Accept details for each manager
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter details for Manager {i + 1}:");
                managers[i] = new Manager();
                managers[i].Accept();
            }

            // Find manager with maximum total salary
            Manager maxManager = managers[0];
            for (int i = 1; i < n; i++)
            {
                if (managers[i].GetTotalSalary() > maxManager.GetTotalSalary())
                {
                    maxManager = managers[i];
                }
            }

            // Display manager with max total salary
            Console.WriteLine("\nManager with Maximum Total Salary:");
            maxManager.Display();
        }
    }
}
