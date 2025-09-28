using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo2iii
{
    class Account
    {
        private int accId;
        private string accName;
        private double accBalance;

        // Constructor to initialize account details
        public Account(int id, string name, double balance)
        {
            accId = id;
            accName = name;
            accBalance = balance;
        }

        // Read-only property for AccId
        public int AccId
        {
            get { return accId; }
        }

        // Property for AccBalance
        public double AccBalance
        {
            get { return accBalance; }
            set { accBalance = value; }
        }

        // Property for AccName
        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }

        // Method to display account details
        public void Display()
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine("Account ID: " + AccId);
            Console.WriteLine("Account Name: " + AccName);
            Console.WriteLine("Account Balance: " + AccBalance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create account object
            Account acc = new Account(101, "Alice", 10000);

            // Display initial details
            Console.WriteLine("Initial Account Details:");
            acc.Display();

            // Update balance and name
            acc.AccBalance += 5000;
            acc.AccName = "Alice Johnson";

            // Display updated details
            Console.WriteLine("\nUpdated Account Details:");
            acc.Display();
        }
    }
}
