using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo6
{
    // User-defined Exception
    class InvalidBirthdateException : Exception
    {
        public InvalidBirthdateException(string message) : base(message)
        {
        }
    }

    // Student class
    class Student
    {
        private string SName;
        private string Address;
        private DateTime BirthDate;

        // Accept student details
        public void Accept()
        {
            Console.Write("Enter Student Name: ");
            SName = Console.ReadLine();

            Console.Write("Enter Address: ");
            Address = Console.ReadLine();

            Console.Write("Enter Birthdate (yyyy-mm-dd): ");
            BirthDate = DateTime.Parse(Console.ReadLine());

            int age = CalculateAge(BirthDate);

            // Validate age
            if (age < 18 || age > 25)
            {
                throw new InvalidBirthdateException(
                    $"Invalid Age: {age}. Age must be between 18 and 25."
                );
            }
        }

        // Display student details
        public void Display()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("Name: " + SName);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Birthdate: " + BirthDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("Age: " + CalculateAge(BirthDate));
        }

        // Helper method to calculate age
        private int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student s = new Student();
                s.Accept();
                s.Display();
            }
            catch (InvalidBirthdateException ex)
            {
                Console.WriteLine("\nException: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nGeneral Error: " + ex.Message);
            }
        }
    }
}
